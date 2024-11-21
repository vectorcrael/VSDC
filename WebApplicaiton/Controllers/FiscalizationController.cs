using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VSDCAPI;

namespace WebApplicaiton.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FiscalizationController (IFiscalService fiscalService) : ControllerBase
    {
        [HttpGet("initialize-device")]
        public async Task<IActionResult> InitializeDevice()
        {
            var response = await fiscalService.initializeDeviceAsync();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(response));
        }

        [HttpGet("update-select-codes")]
        public async Task<IActionResult> UpdateSelectCodes()
        {
            await fiscalService.updateSelectCodes();
            return Ok("Select Codes Updated");
        }

        [HttpGet("update-classification-codes")]
        public async Task<IActionResult> UpdateClassificationCodes()
        {
            await fiscalService.updateClassificationCodes();
            return Ok("Classification Codes Updated");
        }
        
        [HttpGet("update-stock-master")]
        public async Task<IActionResult> UpdateStockMaster()
        {
            var response = await fiscalService.updateStockMaster();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(response));
        }

        [HttpGet("update-imports")]
        public async Task<IActionResult> UpdateImports()
        {
            await fiscalService.updateImports();
            return Ok("Imports Updated");
        }
        
        [HttpGet("received-imports")]
        public async Task<IActionResult> ReceivedImports()
        {
            await fiscalService.receivedImports();
            return Ok("Received Imports Updated");
        }
        
        [HttpGet("fiscalise-purchases")]
        public async Task<IActionResult> FiscalisePurchases()
        {
            await fiscalService.fiscalizePurchases();
            return Ok("Purchases Fiscalised");
        }
        
        [HttpGet("fiscalise-invoices")]
        public async Task<IActionResult> FiscaliseInvoices()
        {
            await fiscalService.fiscalizeInvoices();
            return Ok("Invoices Fiscalised");
        }
        
        [HttpGet("get-smart-purchases")]
        public async Task<IActionResult> GetSmartPurchases()
        {
            var purchases = await fiscalService.getPurchases();
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(purchases));
        }
    }
}
