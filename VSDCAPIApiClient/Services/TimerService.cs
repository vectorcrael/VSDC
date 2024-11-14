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
    public class TimerService(ILogger<TimerService> logger, IFiscalService fiscalService) : IHostedService, IDisposable
    {

        private readonly int timeOut = 120000;
        private readonly ILogger<TimerService> _logger = logger;
        private System.Timers.Timer? _timer;
        private readonly IFiscalService _fiscalInfoService = fiscalService;

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

            //await _fiscalInfoService.testServerRunning();

            await _fiscalInfoService.initializeDeviceAsync();

            await _fiscalInfoService.updateSelectCodes();

            await _fiscalInfoService.updateClassificationCodes();

            await _fiscalInfoService.updateStockMaster();

            await _fiscalInfoService.updateImports();

            await _fiscalInfoService.receivedImports();

            await _fiscalInfoService.fiscalizePurchases();

            await _fiscalInfoService.fiscalizeInvoices();

            await _fiscalInfoService.getPurchases();

            //remove this in production
            await StopAsync(CancellationToken.None);
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

