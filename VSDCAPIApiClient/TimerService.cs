using System;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DataLayer.Services;
using VSDCAPIApiClient;
using Newtonsoft.Json;
using VSDCAPIApiClient.DTOs;
using Newtonsoft.Json.Linq;
using DataLayer.Models2;
using Microsoft.Identity.Client;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace VSDCAPI
{
    public class TimerService(ILogger<TimerService> logger, IFiscalInfoService fiscalInfoService, IVSDCAPIApiClient vSDCAPIApiClient) : IHostedService, IDisposable
    {
        private bool deviceInitialized { get; set; } = false;
        private bool selectCodesUpdated { get; set; } = false;
        private bool classificationCodesUpdated { get; set; } = false;
        private readonly int timeOut = 60000;
        private readonly ILogger<TimerService> _logger = logger;
        private System.Timers.Timer? _timer;
        private readonly IFiscalInfoService _fiscalInfoService = fiscalInfoService;
        private readonly IVSDCAPIApiClient _client = vSDCAPIApiClient;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timer Service is starting.");
            _timer = new System.Timers.Timer(timeOut);
            _timer.Elapsed += OnTimedEventAsync!;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            return Task.CompletedTask;
        }

        private async void OnTimedEventAsync(object source, ElapsedEventArgs e)
        {
            // Logic to execute on timer event
            _logger.LogInformation("Timer event triggered at: {time}", e.SignalTime);
            // Add your code here to do something every minute

            //await testServerRunning();
            if (!deviceInitialized)
                await initializeDeviceAsync();

            if (!selectCodesUpdated)
                await updateSelectCodes();

            if (!classificationCodesUpdated)
                await updateClassificationCodes();

            await updateStockMaster();

            await updateImports();

            await receivedImports();

            await fiscalizePurchases();

            await fiscalizeInvoices();

            //remove this in production
            await StopAsync(CancellationToken.None);
        }

        private async Task receivedImports()
        {
            _logger.LogInformation("Received Imports ");

            var receivedImports = await _fiscalInfoService.GetReceivedImportAsync();

            foreach (var import in receivedImports)
            {
                var request = new UpdateImportItemsRequest
                {
                    tpin = DataMapper.DeviceDetails.Tpin,
                    bhfId = DataMapper.DeviceDetails.BhfId,
                    taskCd = DataMapper.DeviceDetails.LastReqDt,
                    dclDe = import.dclDe,
                    importItemList = new List<ImportItem>
                    {
                        new ImportItem
                        {
                            itemSeq = (int) (import.itemSeq ?? 0),
                            hsCd = import.hsCd,
                            itemClsCd = import.orgnNatCd,
                            itemCd = "RW1NTXU0000006",
                            imptItemSttsCd =  import.invcFcurCd,
                            remark = "remark",
                            modrNm = "Admin",
                            modrId = "Admin"
                        }
                    }
                };

                var response = await _client.UpdateImportItems(request);
                _logger.LogInformation("Updated Imports: {JsonObject}", JsonConvert.SerializeObject(response));

                if (response is null || response!.ResultCd != "000")
                {
                    _logger.LogInformation("Failed to update imports");
                    _logger.LogInformation("Failed Payload: {JsonObject}", JsonConvert.SerializeObject(request));
                }
            }
        }

        private async Task updateImports()
        {
            _logger.LogInformation("Updating Imports ");
            var request = new GetImportsRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = "20240523000000"// DataMapper.DeviceDetails.LastReqDt
            };

            var response = await _client.GetImports(request);
            _logger.LogInformation("Updated Imports: {JsonObject}", JsonConvert.SerializeObject(response));

            if (response is null || response!.ResultCd != "000")
            {
                _logger.LogInformation("Failed to update imports");
                return;
            }

            var jsonData = (JObject)response!.Data;
            var imports = jsonData.ToObject<GetImports>();
            foreach (var import in imports!.itemList)
            {
                var item = new ZraImportData
                {
                    taskCd = import.taskCd,
                    dclDe = import.dclDe,
                    itemSeq = import.itemSeq,
                    dclNo = import.dclNo,
                    hsCd = import.hsCd,
                    itemNm = import.itemNm,
                    orgnNatCd = import.orgnNatCd,
                    exptNatCd = import.exptNatCd,
                    pkg = import.pkg,
                    pkgUnitCd = import.pkgUnitCd,
                    qty = import.qty,
                    qtyUnitCd = import.qtyUnitCd,
                    totWt = import.totWt,
                    netWt = import.netWt,
                    spplrNm = import.spplrNm,
                    agntNm = import.agntNm,
                    invcFcurAmt = import.invcFcurAmt,
                    invcFcurCd = import.invcFcurCd,
                    invcFcurExcrt = import.invcFcurExcrt,
                    dclRefNum = import.dclRefNum,
                };
                _logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                var saveResponse = await _fiscalInfoService.SetImportsAsync(item);
                _logger.LogInformation("Updated Import: {JsonObject}", JsonConvert.SerializeObject(saveResponse));

            }
        }

        private async Task updateStockMaster()
        {
            _logger.LogInformation("Updating Stock Master");

            var stockMasterItems = await _fiscalInfoService.GetStockMastersAsync();

            foreach (var item in stockMasterItems)
            {
                var request = new UpdateItemRequest
                {

                    tpin = DataMapper.DeviceDetails.Tpin,
                    bhfId = DataMapper.DeviceDetails.BhfId,
                    itemCd = item.ItemCode ?? "",
                    itemClsCd = Convert.ToInt32(item.ItemClassificationCode ?? "0"),
                    itemTyCd = item.ItemTypeCode ?? "",
                    itemNm = item.Description ?? "",
                    //  itemStdNm = item.Description ?? "",
                    orgnNatCd = item.OriginNationCode ?? "",
                    pkgUnitCd = item.PackagingUnitCode ?? "",
                    qtyUnitCd = item.QuantityUnitCode ?? "",
                    vatCatCd = item.VatCatCd ?? "",
                    iplCatCd = null,
                    tlCatCd = null,
                    exciseTxCatCd = null,
                    btchNo = null,
                    // bcd = null,
                    dftPrc = (double)(item.Prc ?? 0),
                    // addInfo = null,
                    //sftyQty = 0,
                    isrcAplcbYn = "N",
                    useYn = "Y",
                    regrNm = "ADMIN",
                    regrId = "ADMIN",
                    modrNm = "ADMIN",
                    modrId = "ADMIN"
                };
                _logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
                var response = await _client.SaveItems(request);
                _logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));

            }
        }

        private async Task updateStockAdjustments()
        {
            _logger.LogInformation("Updating Stock Master");

            var stockMasterItems = await _fiscalInfoService.GetStockMastersAsync();
            List<ItemList> ItemList = new List<ItemList>();
            var itemSeq = 0;
            foreach (var item in stockMasterItems)
            {
                ItemList.Add(new VSDCAPI.ItemList
                {
                    ItemSeq = ++itemSeq,
                    ItemCd = item.ItemCode ?? "",
                    ItemClsCd = Convert.ToString(item.ItemClassificationCode ?? ""),
                    itemTyCd = item.ItemTypeCode ?? "",
                    ItemNm = item.ItemTypeCode ?? "",
                    PkgUnitCd = item.PackagingUnitCode ?? "",
                    QtyUnitCd = item.QuantityUnitCode ?? "",
                    Qty = item.Quantity,
                    Prc = (double)(item.Prc ?? 0),
                    SplyAmt = (double)(item.SplyAmt ?? 0),
                    TaxblAmt = (double)(item.TaxblAmt ?? 0),
                    VatCatCd = item.TaxLabel ?? "",
                    TaxAmt = (double)(item.TaxAmt ?? 0),
                    TotAmt = (double)(item.TotAmt ?? 0)
                });
            }

            var request = new SaveStockItemRequest
            {
                Tpin = DataMapper.DeviceDetails.Tpin,
                BhfId = DataMapper.DeviceDetails.BhfId,
                SarNo = 0,
                OrgSarNo = 0,
                RegTyCd = "",
                CustTpin = "",
                CustNm = "",
                CustBhfId = "",
                SarTyCd = "",
                OcrnDt = "",
                TotItemCnt = ItemList.Count,
                TotTaxblAmt = ItemList.Sum(item => item.TaxblAmt),
                TotTaxAmt = ItemList.Sum(item => item.TaxAmt),
                TotAmt = ItemList.Sum(item => item.TotAmt),
                Remark = "",
                RegrId = "",
                RegrNm = "",
                ModrNm = "",
                ModrId = "",
                ItemList = ItemList
            };
            _logger.LogInformation("Request object: {JsonObject}", JsonConvert.SerializeObject(request));
            var response = await _client.SaveStockItem(request);
            _logger.LogInformation("Updated Stock Items: {JsonObject}", JsonConvert.SerializeObject(response));
        }

        private async Task updateSelectCodes()
        {
            _logger.LogInformation("Updating Select Codes");
            var request = new RequestParameters
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = DataMapper.DeviceDetails.LastReqDt
            };
            var response = await _client.GetUnitsOfMeasure(request);

            if (response is null || response!.ResultCd != "000")
            {
                _logger.LogInformation("Failed to update Select Codes");
                _logger.LogInformation("API response is: {JsonObject}", JsonConvert.SerializeObject(response));
                return;
            }

            var jsonData = (JObject)response!.Data;
            var zraCodes = jsonData.ToObject<SelectCodes>();
            _logger.LogInformation("Logging Zra Codest: {JsonObject}", JsonConvert.SerializeObject(zraCodes));
            //save the data back to the database
            foreach (var codeGroup in zraCodes!.clsList)
            {
                foreach (var code in codeGroup.dtlList)
                {
                    ZraSelectCode zraClassCode = DataMapper.MapSelectCode(code);
                    zraClassCode.ResultDt = DateTime.Today.AddDays(-1).ToString("yyyyMMddHHmmss");
                    zraClassCode.CdCls = codeGroup.cdCls;
                    zraClassCode.CdClsNm = codeGroup.cdClsNm;
                    var savedCode = await _fiscalInfoService.SetZraSelectCodesAsync(zraClassCode);
                    _logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode, JsonConvert.SerializeObject(zraClassCode));
                }
            }
            _logger.LogInformation("Done uploading the Select Codes.");
            selectCodesUpdated = true;
        }

        private async Task updateClassificationCodes()
        {
            _logger.LogInformation("Updating Classification Codes");
            var request = new RequestParameters
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                lastReqDt = DataMapper.DeviceDetails.LastReqDt
            };
            var response = await _client.GetClassificationCodes(request);

            if (response is null || response!.ResultCd != "000")
            {
                _logger.LogInformation("Failed to update Classification Codes");
                _logger.LogInformation("API response is: {JsonObject}", JsonConvert.SerializeObject(response));
                return;
            }

            var jsonData = (JObject)response!.Data;
            var zraCodes = jsonData.ToObject<ClassificationCodes>();
            _logger.LogInformation("Logging Zra Codest: {JsonObject}", JsonConvert.SerializeObject(zraCodes));
            //save the data back to the database
            foreach (var itemClass in zraCodes!.itemClsList)
            {

                ZraClassCode zraClassCode = DataMapper.MapClassCode(itemClass);
                var savedCode = await _fiscalInfoService.SetZraClassCodeAsync(zraClassCode);
                _logger.LogInformation("record updated {savedCode}: {JsonObject}", savedCode, JsonConvert.SerializeObject(zraClassCode));

            }
            _logger.LogInformation("Done uploading the Classification Codes.");
            classificationCodesUpdated = true;
        }
        private async Task testServerRunning()
        {
            _logger.LogInformation("Running the Test Server call!");
            var testResp = await _client.TestServerRunning();
            _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(testResp));
        }
        private async Task fiscalizePurchases()
        {
            _logger.LogInformation("Purchases running.");
            var purchases = await _fiscalInfoService.GetZraPurchasesAsync();
            foreach (var purchase in purchases)
            {
                var request = DataMapper.ConvertPurchase(purchase);
                _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(request));
                var response = await _client.SavePurchases(request);
                _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));

                if (response!.ResultCd == "000")
                {
                    var dbUpdate = await _fiscalInfoService.UpdatePurchaseAsync(request.invcNo, response.ResultMsg, response.ResultDt);
                    _logger.LogInformation("Purchase Saved: {JsonObject}", JsonConvert.SerializeObject(dbUpdate));
                }
            }
        }
        private async Task fiscalizeInvoices()
        {

            //steps to fiscalise invoices
            var invoices = await _fiscalInfoService.GetZraInvoicesAsync();

            foreach (var invoice in invoices)
            {
                var saveInvoices = DataMapper.ConvertInvoice(invoice);
                var response = await _client.SaveSales(saveInvoices);
                _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(saveInvoices));

                if (response!.Data != null && response.ResultCd == "000")
                {
                    //once the signature is generated save back to the database
                    var jsonData = (JObject)response.Data; // Cast response.Data to JObject
                    var sd = jsonData.ToObject<SaveInvoiceData>();
                    var qrCode = QrCodeGenerator.GenerateQrCodeAsBinary(sd!.qrCodeUrl);

                    var dbUpdate = await _fiscalInfoService.UpdateFiscalDetailsAsync(
                        signature: qrCode, //sd.rcptSign
                        internalData: sd.intrlData,
                        invoiceNumber: saveInvoices.cisInvcNo,
                        invoiceType: saveInvoices.rcptTyCd,
                        invoiceSequence: sd.rcptNo.ToString(),
                        qrCode: sd.qrCodeUrl,
                        vsdcDate: sd.vsdcRcptPbctDate);

                    var converted = DateTime.TryParse(response.ResultDt, out DateTime resultDt);

                    var fiscalInfo = new FiscalInfo
                    {
                        InvoiceNumber = saveInvoices.cisInvcNo,
                        Message = response.ResultMsg,
                        CreateDate = converted ? resultDt : DateTime.Now
                    };

                    await _fiscalInfoService.AddFiscalInfoAsync(fiscalInfo);
                }

                // //No need to save items individually
                // //if response is OK THEN save items
                // foreach (var item in saveInvoices.itemList)
                // {
                //     var updateRequest = DataMapper.MapToUpdateItemRequest(item);
                //     var itemResponse = await _client.SaveItems(updateRequest);
                // }
            }
        }
        private async Task initializeDeviceAsync()
        {
            var request = new DeviceInitializationRequest
            {
                tpin = DataMapper.DeviceDetails.Tpin,
                bhfId = DataMapper.DeviceDetails.BhfId,
                dvcSrlNo = DataMapper.DeviceDetails.DvcSrlNo
            };

            var response = await _client.DeviceInitialization(request);
            _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(response));

            if (response!.Data != null && response!.ResultCd == "000")
            {
                var jsonData = (JObject)response.Data;
                var deviceInfo = jsonData.ToObject<Device>();
                var deviceInit = DataMapper.MapToDeviceInit(deviceInfo!.info);

                deviceInit.ResultCd = response!.ResultCd;
                deviceInit.ResultDt = response!.ResultDt;
                deviceInit.ResultMsg = response!.ResultMsg;

                var dbUpdate = await _fiscalInfoService.SetDeviceInitsAsync(deviceInit);
                _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(dbUpdate));
            }
            else if (response!.ResultCd == "902")
            {
                // continue work
                var deviceInit = await _fiscalInfoService.GetAllDeviceInitsAsync();

                foreach (var device in deviceInit)
                {
                    _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(device));
                }
            }
            else
            {
                throw new Exception("Cannot work with a device that is not initialized");
            }

            deviceInitialized = true;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timer Service is stopping.");
            _timer?.Stop();
            return Task.CompletedTask;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}

