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
            await fiscalService.updateStockMaster();
            return Ok("Stock Master Updated");
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

            // 

            // 

            // await fiscalService.fiscalizePurchases();

            // await fiscalService.fiscalizeInvoices();

            // await fiscalService.getPurchases();


    }
}
