using Newtonsoft.Json;
using VSDCAPI;

namespace BackgroundWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IFiscalService _fiscalService;

    public Worker(ILogger<Worker> logger, IFiscalService fiscalService )
    {
        _logger = logger;
        _fiscalService = fiscalService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                //RUN ALL THE BACKGROUND WORK IN HERE
                //await FiscalizeInvoice();

            }
            await Task.Delay(2*60*1000, stoppingToken);
        }
    }
}
