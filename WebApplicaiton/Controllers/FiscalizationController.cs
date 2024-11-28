using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServicesLayer.Services;

namespace WebApplicaiton.Controllers;

[Route("[controller]")]
[ApiController]
public class FiscalizationController(IFiscalService fiscalService) : ControllerBase
{
    [HttpGet("initialize-device")]
    public async Task<IActionResult> InitializeDevice()
    {
        var response = await fiscalService.InitializeDeviceAsync();
        return Ok(JsonConvert.SerializeObject(response));
    }

    [HttpGet("update-select-codes")]
    public async Task<IActionResult> UpdateSelectCodes()
    {
        await fiscalService.UpdateSelectCodes();
        return Ok("Select Codes Updated");
    }

    [HttpGet("update-classification-codes")]
    public async Task<IActionResult> UpdateClassificationCodes()
    {
        await fiscalService.UpdateClassificationCodes();
        return Ok("Classification Codes Updated");
    }

    [HttpGet("update-stock-master")]
    public async Task<IActionResult> UpdateStockMaster()
    {
        var response = await fiscalService.UpdateStockMaster();
        return Ok(JsonConvert.SerializeObject(response));
    }

    [HttpGet("update-imports")]
    public async Task<IActionResult> UpdateImports()
    {
        await fiscalService.UpdateImports();
        return Ok("Imports Updated");
    }

    [HttpGet("received-imports")]
    public async Task<IActionResult> ReceivedImports()
    {
        await fiscalService.ReceivedImports();
        return Ok("Received Imports Updated");
    }

    [HttpGet("fiscalise-purchases")]
    public async Task<IActionResult> FiscalisePurchases()
    {
        await fiscalService.FiscalizePurchases();
        return Ok("Purchases Fiscalised and Stocks Updated");
    }

    [HttpGet("fiscalise-invoices")]
    public async Task<IActionResult> FiscaliseInvoices()
    {
        var responses = await fiscalService.FiscalizeInvoices();
        Console.Write("Invoices Fiscalised and Stocks Adjusted");
        return Ok(JsonConvert.SerializeObject(responses));
    }

    [HttpGet("get-smart-purchases")]
    public async Task<IActionResult> GetSmartPurchases()
    {
        var purchases = await fiscalService.GetPurchases();
        return Ok(JsonConvert.SerializeObject(purchases));
    }
    
    [HttpGet("other-stock-adjustments")]
    public async Task<IActionResult> OtherStockAdjustments()
    {
        var stocks = await fiscalService.saveItemFromStockAdjustments();
        return Ok(JsonConvert.SerializeObject(stocks));
    }
}