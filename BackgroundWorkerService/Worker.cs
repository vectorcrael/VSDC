using DataLayer.Services;
using Newtonsoft.Json;
using VSDCAPI;
using VSDCAPIApiClient;

namespace BackgroundWorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IFiscalInfoService _fiscalInfoService;
    private readonly IVSDCAPIApiClient _client;

    public Worker(ILogger<Worker> logger, IFiscalInfoService fiscalInfoService, IVSDCAPIApiClient vSDCAPIApiClient)
    {
        _logger = logger;
        _fiscalInfoService = fiscalInfoService;
        _client = vSDCAPIApiClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                await FiscalizeInvoice();

            }
            await Task.Delay(2*60*1000, stoppingToken);
        }
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

            //if response is OK THEN save items
            foreach (var item in saveInvoices.itemList)
            {
                var updateRequest = DataMapper.MapToUpdateItemRequest(item);
                var itemResponse = await _client.SaveItems(updateRequest);
            }
        }
    }
}
