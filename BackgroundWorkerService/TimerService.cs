using System.Timers;
using ServicesLayer.Services;
using Timer = System.Timers.Timer;

namespace BackgroundWorkerService;

public class TimerService(ILogger<TimerService> logger, IFiscalInfoServiceFactory fiscalServiceFactory)
    : IHostedService, IDisposable
{
    private const int TimeOut = 120000;
    private Timer? _timer;

    public void Dispose()
    {
        _timer?.Dispose();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Timer Service is starting.");
        _timer = new Timer(TimeOut);
        _timer.Elapsed += OnTimedEventAsync!;
        _timer.AutoReset = true;
        _timer.Enabled = true;
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Timer Service is stopping.");
        _timer?.Stop();
        return Task.CompletedTask;
    }

    private async void OnTimedEventAsync(object source, ElapsedEventArgs e)
    {
        // Logic to execute on timer event
        logger.LogInformation("Timer event triggered at: {time}", e.SignalTime);

        var fiscalInfoService = fiscalServiceFactory.Create();

        //await _fiscalInfoService.testServerRunning();

        await fiscalInfoService.InitializeDeviceAsync();

        await fiscalInfoService.UpdateSelectCodes();

        await fiscalInfoService.UpdateClassificationCodes();

        await fiscalInfoService.UpdateStockMaster();

        await fiscalInfoService.UpdateImports();

        await fiscalInfoService.ReceivedImports();

        await fiscalInfoService.FiscalizePurchases();

        await fiscalInfoService.FiscalizeInvoices();

        await fiscalInfoService.GetPurchases();

        //remove this in production
        await StopAsync(CancellationToken.None);
    }
}