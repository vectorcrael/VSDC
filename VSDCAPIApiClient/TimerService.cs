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

namespace VSDCAPI
{


    public class TimerService : IHostedService, IDisposable
    {
        private bool deviceInitialized { get; set; } = false;
        private readonly int timeOut = 60000;
        private readonly ILogger<TimerService> _logger;
        private System.Timers.Timer _timer;
        private readonly IFiscalInfoService _fiscalInfoService;
        private readonly IVSDCAPIApiClient _client;

        public TimerService(ILogger<TimerService> logger, IFiscalInfoService fiscalInfoService, IVSDCAPIApiClient vSDCAPIApiClient)
        {
            _logger = logger;
            _fiscalInfoService = fiscalInfoService;
            _client = vSDCAPIApiClient;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timer Service is starting.");

            _timer = new System.Timers.Timer(timeOut);
            _timer.Elapsed += OnTimedEventAsync;
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

            await FiscalizeInvoice();

            //remove this in production
            await StopAsync(CancellationToken.None);
        }

        private async Task testServerRunning()
        {
            _logger.LogInformation("Running the Test Server call!");
            var testResp = await _client.TestServerRunning();
            _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(testResp));
        }

        private async Task FiscalizeInvoice()
        {

            //steps to fiscalise invoices
            var invoices = await _fiscalInfoService.GetZraInvoicesAsync();

            foreach (var invoice in invoices)
            {
                var saveInvoices = DataMapper.ConvertInvoice(invoice);
                var response = await _client.SaveSales(saveInvoices);
                _logger.LogInformation("Logging JSON object: {JsonObject}", JsonConvert.SerializeObject(saveInvoices));

                if (response.ResultCd == "000")
                {
                    //once the signature is generated save back to the database
                    var jsonData = (JObject)response.Data; // Cast response.Data to JObject
                    var sd = jsonData.ToObject<SaveInvoiceData>();
                    var qrCode = QrCodeGenerator.GenerateQrCodeAsBinary(sd.qrCodeUrl);

                    var dbUpdate = await _fiscalInfoService.UpdateFiscalDetailsAsync(
                        signature: qrCode, //sd.rcptSign
                        internalData: sd.intrlData,
                        invoiceNumber: saveInvoices.cisInvcNo,
                        invoiceType: saveInvoices.rcptTyCd,
                        invoiceSequence: sd.rcptNo.ToString(),
                        qrCode: sd.qrCodeUrl,
                        vsdcDate: sd.vsdcRcptPbctDate);
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

            if (response!.ResultCd == "000")
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

