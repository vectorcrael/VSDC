using ServicesLayer.Services;

namespace BackgroundWorkerService;

public class Worker(ILogger<Worker> _logger, IFiscalInfoServiceFactory fiscalServicefactory) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //RUN ALL THE BACKGROUND WORK IN HERE
            //await FiscalizeInvoice();
            await Task.Delay(2 * 60 * 1000, stoppingToken);
        }
    }
}