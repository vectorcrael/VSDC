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
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response));
            return Ok(response);
        }

        [HttpGet("update-select-codes")]
        public async Task<IActionResult> UpdateSelectCodes()
        {
            await fiscalService.updateSelectCodes();
            return Ok("Select Coded Updated");
        }

            // 

            // await _fiscalInfoService.updateClassificationCodes();

            // await _fiscalInfoService.updateStockMaster();

            // await _fiscalInfoService.updateImports();

            // await _fiscalInfoService.receivedImports();

            // await _fiscalInfoService.fiscalizePurchases();

            // await _fiscalInfoService.fiscalizeInvoices();

            // await _fiscalInfoService.getPurchases();


    }
}
