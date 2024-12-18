using DataLayer.Models;
using DataLayer.Services;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServicesLayer.DTOs;
using ServicesLayer.Utilites;
using VSDCAPI;

namespace ServicesLayer.Services;

public class FiscalService(
    ILogger<FiscalService> logger,
    IDataService dataService,
    IVSDCAPIApiClient apiClient) : IFiscalService
{
    private bool deviceInitialized { get; set; }
    private bool selectCodesUpdated { get; set; }
    private bool classificationCodesUpdated { get; set; }

    public async Task<SmartPurchases> GetPurchases()
    {
        logger.LogInformation("Smart Purchases ");

        var request = new CustomersRequest
        {
            tpin = DataMapper.DeviceDetails.Tpin,
            bhfId = DataMapper.DeviceDetails.BhfId,
            lastReqDt = "20240923000000" //DataMapper.DeviceDetails.LastReqDt
        };
        var response = await apiClient.GetPurchases(request);

        if (response is null || response!.ResultCd != "000")
        {
            logger.LogInformation("Failed to get purchases");
            throw new ApplicationException("Failed to get purchases\n" + JsonConvert.SerializeObject(response));
        }

        var jsonData = (JObject)response!.Data!;
        var purchases = jsonData.ToObject<SmartPurchases>();

        foreach (var saveToSave in purchases!.saleList.Select(DataMapper.MapToSmartPurchase))
        {
            var saved = await dataService.SetSmartInvoiceAsync(saveToSave);
            logger.LogInformation("Saved Purchase with code " + saved);
        }

        return purchases;
    }

    public async Task<List<ZraResponse>> ReceivedImports()
    {
        logger.LogInformation("Received Imports ");
        var updatedImports = new List<ZraResponse>();

        var receivedImports = await dataService.GetImportsAsync();
        
        foreach (var import in receivedImports)
        {
            var itemSeq = 1;
            var request = new UpdateImportItemsRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                taskCd = import.taskCd,
                dclDe = import.dclDe,
                importItemList = import.lines.Select(item => new ImportItem
                {
                    itemSeq = itemSeq++,
                    hsCd = import.hsCd ?? "",
                    itemClsCd = item.itemClsCd ?? "",
                    itemCd = item.itemCd ?? "",
                    imptItemSttsCd = (item.imptItemSttsCd ?? 0).ToString(),
                    remark = "",
                    modrNm = DataMapper.DeviceDetails.modrNm,
                    modrId = DataMapper.DeviceDetails.modrId
                }).ToList()
            };

            var response = await apiClient.UpdateImportItems(request);
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

    public async Task UpdateImports()
    {
        logger.LogInformation("Updating Imports ");
        var request = new GetImportsRequest
        {
            tpin = DataMapper.DeviceDetails.Tpin,
            bhfId = DataMapper.DeviceDetails.BhfId,
            lastReqDt = "20240910000000" // DataMapper.DeviceDetails.LastReqDt
        };

        var response = await apiClient.GetImports(request);
        logger.LogInformation("Updated Imports: {JsonObject}", JsonConvert.SerializeObject(response));

        if (response is null || response!.ResultCd != "000")
        {
            logger.LogInformation("Failed to update imports");
            return;
        }

        var jsonData = (JObject)response!.Data;
        var imports = jsonData.ToObject<GetImports>();

        foreach (var item in imports!.itemList.Select(DataMapper.MapData))
        {
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var saveResponse = await dataService.SetImportsAsync(item);
            logger.LogInformation("Updated Import: {JsonObject}", JsonConvert.SerializeObject(saveResponse));
        }
    }

    public async Task<List<ZraResponse?>> UpdateStockMaster()
    {
        logger.LogInformation("Updating StockList Master");
        var stockMasterItems = await dataService.GetStockMastersAsync();
        var stockMasters = new List<ZraResponse?>();

        foreach (var request in stockMasterItems.Select(DataMapper.MapData))
        {
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveItems(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }

    public async Task<List<ZraResponse?>> AdjustStockMaster()
    {
        logger.LogInformation("Adjusting StockList Master");
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
                modrId = DataMapper.DeviceDetails.modrId,
                itemList = []
            };

            const int itemSeq = 1;
            request.itemList.Add(DataMapper.MapDataItem(item, itemSeq));

            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveStockItem(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }

    public async Task UpdateStockAdjustments()
    {
        logger.LogInformation("Updating StockList Master");

        var stockMasterItems = await dataService.GetStockMastersAsync();
        var itemSeq = 0;
        var itemList = stockMasterItems.Select(item => DataMapper.MapDataItem(item, ++itemSeq)).ToList();

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
        var response = await apiClient.SaveStockItem(request);
        logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
    }

    public async Task UpdateSelectCodes()
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
        var response = await apiClient.GetUnitsOfMeasure(request);

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
        foreach (var code in codeGroup.dtlList)
        {
            var zraClassCode = DataMapper.MapSelectCode(code);
            zraClassCode.ResultDt = DateTime.Today.AddDays(-1).ToString("yyyyMMddHHmmss");
            zraClassCode.CdCls = codeGroup.cdCls;
            zraClassCode.CdClsNm = codeGroup.cdClsNm;
            var savedCode = await dataService.SetZraSelectCodesAsync(zraClassCode);
            logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode,
                JsonConvert.SerializeObject(zraClassCode));
        }

        logger.LogInformation("Done uploading the Select Codes.");
        selectCodesUpdated = true;
    }

    public async Task UpdateClassificationCodes()
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
        var response = await apiClient.GetClassificationCodes(request);

        if (response is null || response!.ResultCd != "000")
        {
            logger.LogInformation("Failed to update Classification Codes");
            logger.LogInformation("API response is: {JsonObject}", JsonConvert.SerializeObject(response));
            return;
        }

        var jsonData = (JObject)response.Data;
        var zraCodes = jsonData.ToObject<ClassificationCodes>();
        logger.LogInformation("Logging Zra Codest: {JsonObject}", JsonConvert.SerializeObject(zraCodes));
        //save the data back to the database

        foreach (var zraClassCode in zraCodes!.itemClsList.Select(DataMapper.MapClassCode))
        {
            var savedCode = await dataService.SetZraClassCodeAsync(zraClassCode);
            logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode,
                JsonConvert.SerializeObject(zraClassCode));
        }


        logger.LogInformation("Done uploading the Classification Codes.");
        classificationCodesUpdated = true;
    }

    public async Task TestServerRunning()
    {
        logger.LogInformation("Running the Test Server call!");
        var testResp = await apiClient.TestServerRunning();
        logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(testResp));
    }

    public async Task<List<ZraResponse?>> FiscalizePurchases()
    {
        logger.LogInformation("Purchases running.");

        var purchases = await dataService.GetZraPurchasesAsync();
        List<ZraResponse?> responses = [];
        foreach (var purchase in purchases)
        {
            var request = DataMapper.ConvertPurchase(purchase);
            logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SavePurchases(request);
            responses.Add(response!);
            logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));

            if (response!.ResultCd == "000")
            {
                var dbUpdate =
                    await dataService.UpdatePurchaseAsync(request.invcNo, response.ResultMsg, response.ResultDt);
                logger.LogInformation("Purchase Saved: {JsonObject}", JsonConvert.SerializeObject(dbUpdate));

                var dbInvUpdate =
                    await dataService.AddPurchasFiscalInfoAsync(request.invcNo, Convert.ToInt32(purchase.Id));
                logger.LogInformation("Purchase Update: {JsonObject}", JsonConvert.SerializeObject(dbInvUpdate));

            }
        }

        if (purchases.Count > 0)
        {
            logger.LogInformation("Purchase object: {JsonObject}", JsonConvert.SerializeObject(purchases));
            responses.AddRange((await SaveItemFromPurchases(purchases))!);
            responses.AddRange((await SaveStockMaster(DataMapper.ConvertToStockList(purchases)))!);
        }

        return responses;
    }

    public async Task<List<ZraResponse>> FiscalizeInvoices()
    {
        var responses = new List<ZraResponse>();
        var invoices = await dataService.GetZraInvoicesAsync();

        foreach (var invoice in invoices)
        {
            var saveInvoices = DataMapper.ConvertInvoice(invoice);
            var response = await apiClient.SaveSales(saveInvoices);
            logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(saveInvoices));
            responses.Add(response);

            if (response!.Data != null && response.ResultCd == "000")
            {
                var jsonData = (JObject)response.Data;
                var sd = jsonData.ToObject<SaveInvoiceData>();
                var qrCode = QrCodeGenerator.GenerateQrCodeAsBinary(sd!.qrCodeUrl);

                var dbUpdate = await dataService.UpdateFiscalDetailsAsync(
                    new FiscalDetails()
                    {
                        qrCodeBinary = qrCode,
                        internalData = sd.intrlData,
                        invoiceNumber = saveInvoices.cisInvcNo,
                        invoiceType = saveInvoices.rcptTyCd,
                        invoiceSequence = sd.rcptNo.ToString(),
                        signature = sd.rcptSign,
                        vsdcDate = sd.vsdcRcptPbctDate
                    });

                var converted = DateTime.TryParse(response.ResultDt, out var resultDt);

                var fiscalInfo = new FiscalInfo
                {
                    InvoiceNumber = saveInvoices.cisInvcNo,
                    Message = response.ResultMsg,
                    CreateDate = converted ? resultDt : DateTime.Now
                };
                await dataService.AddFiscalInfoAsync(fiscalInfo);
            }
        }

        if (invoices.Count > 0)
        {
            responses.AddRange((await SaveItemFromInvoices(invoices))!);
            StockList stocklist = DataMapper.ConvertToStockList(invoices);
            responses.AddRange((await SaveStockMaster(stocklist))!);
        }

        return responses;
    }

    public async Task<ZraResponse> InitializeDeviceAsync()
    {
        var response = new ZraResponse
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

        response = await apiClient.DeviceInitialization(request);
        logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));

        if (response is { Data: not null } && response!.ResultCd == "000")
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
                logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(device));

            deviceInitialized = true;
        }
        else
        {
            deviceInitialized = false;
            //throw new Exception("Cannot work with a device that is not initialized");
        }


        return response;
    }

    public async Task<List<ZraResponse?>> SaveItemFromPurchases(List<ZraPurchase> purchases)
    {
        logger.LogInformation("Save Purchase Items to stocks");
        var stockMasters = new List<ZraResponse?>();

        foreach (var request in purchases.Select(DataMapper.MapStockData))
        {
            logger.LogInformation("Stockitem Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveStockItem(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }

    public async Task<List<ZraResponse?>> SaveItemFromInvoices(List<ZraInvoice> invoices)
    {
        logger.LogInformation("Save Invoice Items to stocks");
        var stockMasters = new List<ZraResponse?>();

        foreach (var request in invoices.Select(DataMapper.MapStockData))
        {
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveStockItem(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }

    public async Task<List<ZraResponse?>> SaveItemFromStockAdjustments()
    {
        logger.LogInformation("Save items from stocks");
        var stocks = await dataService.GetOtherStockAdjustmentsAsync();
        var stockMasters = new List<ZraResponse?>();

        foreach (var request in stocks.Select(DataMapper.MapData))
        {
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveItems(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }

    public async Task<List<ZraResponse?>> SaveStockItem()
    {
        logger.LogInformation("Save items from stocks");
        var stocks = await dataService.GetOtherStockAdjustmentsAsync();
        var stockMasters = new List<ZraResponse?>();

        foreach (var request in stocks.Select(DataMapper.MapStockData))
        {
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveStockItem(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        if (stocks.Count > 0)
        {
            StockList stocklist = DataMapper.ConvertToStockList(stocks);
            var stockAdjust = await SaveStockMaster(stocklist);
            stockMasters.AddRange(stockAdjust!);
        }

        return stockMasters;
    }

    public async Task<List<ZraResponse?>> SaveStockMaster(StockList stockList)
    {
        logger.LogInformation("Save items from stocks");
        var stockMasters = new List<ZraResponse?>();
        if (stockList.stockItemList.Count > 0)
        {
            var request = DataMapper.MapStockMaster(stockList);
            logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await apiClient.SaveStockMaster(request);
            stockMasters.Add(response);
            logger.LogInformation("Updated StockList Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        return stockMasters;
    }
}