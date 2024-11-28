using System;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DataLayer.Services;
using ServicesLayer;
using Newtonsoft.Json;
using ServicesLayer.DTOs;
using Newtonsoft.Json.Linq;
using Microsoft.Identity.Client;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using ServicesLayer.Services;
using ServicesLayer.Utilites;

namespace VSDCAPI
{
    public class FiscalService(
        ILogger<FiscalService> logger,
        IDataService dataService,
        IVSDCAPIApiClient vSDCAPIApiClient) : IFiscalService
    {
        private bool deviceInitialized { get; set; } = false;
        private bool selectCodesUpdated { get; set; } = false;
        private bool classificationCodesUpdated { get; set; } = false;

        public async Task<SmartPurchases> getPurchases()
        {
            logger.LogInformation("Smart Purchases ");
            SmartPurchases purchases = new SmartPurchases();

            var request = new CustomersRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = "20240923000000" //DataMapper.DeviceDetails.LastReqDt
            };
            var response = await vSDCAPIApiClient.GetPurchases(request);

            if (response is null || response!.ResultCd != "000")
            {
                logger.LogInformation("Failed to get purchases");
                throw new ApplicationException("Failed to get purchases\n" + JsonConvert.SerializeObject(response));
            }

            var jsonData = (JObject)response!.Data;
            purchases = jsonData.ToObject<SmartPurchases>();

            foreach (var sale in purchases!.saleList)
            {
                var saveToSave = DataMapper.MapToSmartPurchase(sale);
                var saved = await dataService.SetSmartInvoiceAsync(saveToSave);
                logger.LogInformation("Saved Purchase with code " + saved);
            }

            return purchases;
        }

        public async Task<List<ZraResponse>> receivedImports()
        {
            logger.LogInformation("Received Imports ");
            var updatedImports = new List<ZraResponse>();

            var receivedImports = await dataService.GetReceivedImportAsync();

            foreach (var import in receivedImports)
            {
                var request = new UpdateImportItemsRequest
                {
                    tpin = DataMapper.DeviceDetails.Tpin,
                    bhfId = DataMapper.DeviceDetails.BhfId,
                    taskCd = import.taskCd,
                    dclDe = import.dclDe,
                    importItemList = new List<ImportItem>
                    {
                        new ImportItem
                        {
                            itemSeq = (int)(import.itemSeq ?? 0),
                            hsCd = import.hsCd,
                            itemClsCd = "10101504",
                            itemCd = "Chemicals",
                            imptItemSttsCd = "3",
                            remark = "remark",
                            modrNm = "Admin",
                            modrId = "Admin"
                        }
                    }
                };

                var response = await vSDCAPIApiClient.UpdateImportItems(request);
                logger.LogInformation("Updated Imports: {JsonObject}", JsonConvert.SerializeObject(response));

                if (response is null || response!.ResultCd != "000")
                {
                    logger.LogInformation("Failed to update imports");
                    logger.LogInformation("Failed Payload: {JsonObject}", JsonConvert.SerializeObject(request));
                }
                else
                {
                    updatedImports.Add(response);
                }
            }

            return updatedImports;
        }

        public async Task updateImports()
        {
            logger.LogInformation("Updating Imports ");
            var request = new GetImportsRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = "20240910000000" // DataMapper.DeviceDetails.LastReqDt
            };

            var response = await vSDCAPIApiClient.GetImports(request);
            logger.LogInformation("Updated Imports: {JsonObject}", JsonConvert.SerializeObject(response));

            if (response is null || response!.ResultCd != "000")
            {
                logger.LogInformation("Failed to update imports");
                return;
            }

            var jsonData = (JObject)response!.Data;
            var imports = jsonData.ToObject<GetImports>();

            foreach (var import in imports!.itemList)
            {
                var item = DataMapper.MapData(import);
                logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                var saveResponse = await dataService.SetImportsAsync(item);
                logger.LogInformation("Updated Import: {JsonObject}", JsonConvert.SerializeObject(saveResponse));
            }
        }

        public async Task<List<ZraResponse?>> updateStockMaster()
        {
            logger.LogInformation("Updating Stock Master");
            var stockMasterItems = await dataService.GetStockMastersAsync();
            var stockMasters = new List<ZraResponse?>();

            foreach (var item in stockMasterItems)
            {
                var request = DataMapper.MapData(item);
                logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                var response = await vSDCAPIApiClient.SaveItems(request);
                stockMasters.Add(response);
                logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));
            }

            return stockMasters;
        }
        
        public async Task<List<ZraResponse?>> saveItemFromPurchases(List<ZraPurchase> purchases)
        {
            logger.LogInformation("Save Invoice Items to stocks");
            var stockMasters = new List<ZraResponse?>();

            foreach (var purchase in purchases)
            {
                //No need to save items individually
                //if response is OK THEN save items
                if (purchase.Items != null)
                    foreach (var item in purchase.Items)
                    {
                        var request = DataMapper.MapData(item);
                        logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                        var response = await vSDCAPIApiClient.SaveItems(request);
                        stockMasters.Add(response);
                        logger.LogInformation("Updated Stock Items: {JsonObject}",
                            JsonConvert.SerializeObject(response));
                    }
            }

            return stockMasters;
        }
        
        public async Task<List<ZraResponse?>> saveItemFromInvoices(List<ZraInvoice> invoices)
        {
            logger.LogInformation("Save Invoice Items to stocks");
            var stockMasters = new List<ZraResponse?>();

            foreach (var invoice in invoices)
            {
                //No need to save items individually
                //if response is OK THEN save items
                foreach (var item in invoice.Items)
                {
                    var request = DataMapper.MapData(item);
                    logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                    var response = await vSDCAPIApiClient.SaveItems(request);
                    stockMasters.Add(response);
                    logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));
                }
            }

            return stockMasters;
        }

        public async Task<List<ZraResponse?>> adjustStockMaster()
        {
            logger.LogInformation("Adjusting Stock Master");
            var stockMasterItems = await dataService.GetStockAdjustmentsAsync();
            var stockMasters = new List<ZraResponse?>();

            foreach (var item in stockMasterItems)
            {
                var request = new SaveStockItemRequest
                {
                    tpin = DataMapper.DeviceDetails.Tpin,
                    bhfId = item.BranchId ?? "",
                    regrNm = DataMapper.DeviceDetails.regrNm,
                    regrId = DataMapper.DeviceDetails.regrId,
                    modrNm = DataMapper.DeviceDetails.modrNm,
                    modrId = DataMapper.DeviceDetails.modrId
                };

                request.itemList = new List<ItemList>();
                var itemSeq = 1;
                request.itemList.Add(DataMapper.MapDataItem(item, itemSeq));

                logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                var response = await vSDCAPIApiClient.SaveStockItem(request);
                stockMasters.Add(response);
                logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));
            }

            return stockMasters;
        }

        public async Task UpdateStockAdjustments()
        {
            logger.LogInformation("Updating Stock Master");

            var stockMasterItems = await dataService.GetStockMastersAsync();
            var itemList = new List<ItemList>();
            var itemSeq = 0;
            foreach (var item in stockMasterItems)
            {
                itemList.Add(DataMapper.MapDataItem(item, ++itemSeq));
            }

            var request = new SaveStockItemRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                sarNo = 0,
                orgSarNo = 0,
                regTyCd = "",
                custTpin = "",
                custNm = "",
                custBhfId = "",
                sarTyCd = "",
                ocrnDt = "",
                totItemCnt = itemList.Count,
                totTaxblAmt = itemList.Sum(item => item.taxblAmt),
                totTaxAmt = itemList.Sum(item => item.taxAmt),
                totAmt = itemList.Sum(item => item.totAmt),
                remark = "",
                regrId = "",
                regrNm = "",
                modrNm = "",
                modrId = "",
                itemList = itemList
            };
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await vSDCAPIApiClient.SaveStockItem(request);
            logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        public async Task updateSelectCodes()
        {
            if (selectCodesUpdated)
                return;

            logger.LogInformation("Updating Select Codes");
            var request = new RequestParameters
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = DataMapper.DeviceDetails.LastReqDt
            };
            var response = await vSDCAPIApiClient.GetUnitsOfMeasure(request);

            if (response is null || response!.ResultCd != "000")
            {
                logger.LogInformation("Failed to update Select Codes");
                logger.LogInformation("API response is: {JsonObject}", JsonConvert.SerializeObject(response));
                return;
            }

            var jsonData = (JObject)response!.Data;
            var zraCodes = jsonData.ToObject<SelectCodes>();
            logger.LogInformation("Logging Zra Codest: {JsonObject}", JsonConvert.SerializeObject(zraCodes));
            //save the data back to the database

            foreach (var codeGroup in zraCodes!.clsList)
            {
                foreach (var code in codeGroup.dtlList)
                {
                    ZraSelectCode zraClassCode = DataMapper.MapSelectCode(code);
                    zraClassCode.ResultDt = DateTime.Today.AddDays(-1).ToString("yyyyMMddHHmmss");
                    zraClassCode.CdCls = codeGroup.cdCls;
                    zraClassCode.CdClsNm = codeGroup.cdClsNm;
                    var savedCode = await dataService.SetZraSelectCodesAsync(zraClassCode);
                    logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode,
                        JsonConvert.SerializeObject(zraClassCode));
                }
            }

            logger.LogInformation("Done uploading the Select Codes.");
            selectCodesUpdated = true;
        }

        public async Task updateClassificationCodes()
        {
            if (classificationCodesUpdated)
                return;

            logger.LogInformation("Updating Classification Codes");
            var request = new RequestParameters
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = DataMapper.DeviceDetails.LastReqDt
            };
            var response = await vSDCAPIApiClient.GetClassificationCodes(request);

            if (response is null || response!.ResultCd != "000")
            {
                logger.LogInformation("Failed to update Classification Codes");
                logger.LogInformation("API response is: {JsonObject}", JsonConvert.SerializeObject(response));
                return;
            }

            var jsonData = (JObject)response!.Data;
            var zraCodes = jsonData.ToObject<ClassificationCodes>();
            logger.LogInformation("Logging Zra Codest: {JsonObject}", JsonConvert.SerializeObject(zraCodes));
            //save the data back to the database

            foreach (var itemClass in zraCodes!.itemClsList)
            {
                ZraClassCode zraClassCode = DataMapper.MapClassCode(itemClass);
                var savedCode = await dataService.SetZraClassCodeAsync(zraClassCode);
                logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode,
                    JsonConvert.SerializeObject(zraClassCode));
            }

            logger.LogInformation("Done uploading the Classification Codes.");
            classificationCodesUpdated = true;
        }

        public async Task testServerRunning()
        {
            logger.LogInformation("Running the Test Server call!");
            var testResp = await vSDCAPIApiClient.TestServerRunning();
            logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(testResp));
        }

        public async Task fiscalizePurchases()
        {
            logger.LogInformation("Purchases running.");

            var purchases = await dataService.GetZraPurchasesAsync();
            foreach (var purchase in purchases)
            {
                var request = DataMapper.ConvertPurchase(purchase);
                logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(request));
                var response = await vSDCAPIApiClient.SavePurchases(request);
                logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));

                if (response!.ResultCd == "000")
                {
                    var dbUpdate = await dataService.UpdatePurchaseAsync(request.invcNo, response.ResultMsg, response.ResultDt);
                    logger.LogInformation("Purchase Saved: {JsonObject}", JsonConvert.SerializeObject(dbUpdate));
                }
            }
            await saveItemFromPurchases(purchases);
        }

        public async Task<List<ZraResponse>> fiscalizeInvoices()
        {
            var responses = new List<ZraResponse>();

            //steps to fiscalise invoices
            var invoices = await dataService.GetZraInvoicesAsync();

            foreach (var invoice in invoices)
            {
                var saveInvoices = DataMapper.ConvertInvoice(invoice);
                var response = await vSDCAPIApiClient.SaveSales(saveInvoices);
                logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(saveInvoices));
                responses.Add(response);

                if (response!.Data != null && response.ResultCd == "000")
                {
                    //once the signature is generated save back to the database
                    var jsonData = (JObject)response.Data; // Cast response.Data to JObject
                    var sd = jsonData.ToObject<SaveInvoiceData>();
                    var qrCode = QrCodeGenerator.GenerateQrCodeAsBinary(sd!.qrCodeUrl);

                    var dbUpdate = await dataService.UpdateFiscalDetailsAsync(
                        qrCodeBinary: qrCode, //sd.rcptSign
                        internalData: sd.intrlData,
                        invoiceNumber: saveInvoices.cisInvcNo,
                        invoiceType: saveInvoices.rcptTyCd,
                        invoiceSequence: sd.rcptNo.ToString(),
                        signature: sd.rcptSign, //sd.qrCodeUrl,
                        vsdcDate: sd.vsdcRcptPbctDate);

                    var converted = DateTime.TryParse(response.ResultDt, out DateTime resultDt);

                    var fiscalInfo = new FiscalInfo
                    {
                        InvoiceNumber = saveInvoices.cisInvcNo,
                        Message = response.ResultMsg,
                        CreateDate = converted ? resultDt : DateTime.Now
                    };
                    await dataService.AddFiscalInfoAsync(fiscalInfo);
                }
            }
            var stockSave = await saveItemFromInvoices(invoices);
            responses.AddRange(stockSave!);
            return responses;
        }

        public async Task<ZraResponse> initializeDeviceAsync()
        {
            ZraResponse? response = new ZraResponse
            {
                ResultMsg = "Device already initialized"
            };

            if (deviceInitialized)
                return response;

            var request = new DeviceInitializationRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                dvcSrlNo = DataMapper.DeviceDetails.DvcSrlNo
            };

            response = await vSDCAPIApiClient.DeviceInitialization(request);
            logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));


            if (response!.Data != null && response!.ResultCd == "000")
            {
                var jsonData = (JObject)response.Data;
                var deviceInfo = jsonData.ToObject<Device>();
                var deviceInit = DataMapper.MapToDeviceInit(deviceInfo!.info);

                deviceInit.ResultCd = response!.ResultCd;
                deviceInit.ResultDt = response!.ResultDt;
                deviceInit.ResultMsg = response!.ResultMsg;

                var dbUpdate = await dataService.SetDeviceInitsAsync(deviceInit);
                logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(dbUpdate));
                deviceInitialized = true;
            }
            else if (response!.ResultCd == "902")
            {
                // continue work
                var deviceInit = await dataService.GetAllDeviceInitsAsync();

                foreach (var device in deviceInit)
                {
                    logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(device));
                }

                deviceInitialized = true;
            }
            else
            {
                deviceInitialized = false;
                //throw new Exception("Cannot work with a device that is not initialized");
            }


            return response;
        }
    }
}