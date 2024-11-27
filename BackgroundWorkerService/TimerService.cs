using System;
using System.Timers;
using ServicesLayer.Services;
using VSDCAPI;

namespace BackgroundWorkerService
{
    public class TimerService(ILogger<TimerService> logger, IFiscalInfoServiceFactory fiscalServiceFactory) : IHostedService, IDisposable
    {
        private const int TimeOut = 120000;
        private System.Timers.Timer? _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Timer Service is starting.");
            _timer = new System.Timers.Timer(TimeOut);
            _timer.Elapsed += OnTimedEventAsync!;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            return Task.CompletedTask;
        }

        private async void OnTimedEventAsync(object source, ElapsedEventArgs e)
        {
            // Logic to execute on timer event
            logger.LogInformation("Timer event triggered at: {time}", e.SignalTime);
            
            var fiscalInfoService = fiscalServiceFactory.Create();
            
            //await _fiscalInfoService.testServerRunning();

            await fiscalInfoService.initializeDeviceAsync();

            await fiscalInfoService.updateSelectCodes();

            await fiscalInfoService.updateClassificationCodes();

            await fiscalInfoService.updateStockMaster();

            await fiscalInfoService.updateImports();

            await fiscalInfoService.receivedImports();

            await fiscalInfoService.fiscalizePurchases();

            await fiscalInfoService.fiscalizeInvoices();

            await fiscalInfoService.getPurchases();

            //remove this in production
            await StopAsync(CancellationToken.None);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Timer Service is stopping.");
            _timer?.Stop();
            return Task.CompletedTask;
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}

