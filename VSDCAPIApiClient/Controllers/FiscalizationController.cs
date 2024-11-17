using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VSDCAPI;

namespace VSDCAPIApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiscalizationController (IFiscalService fiscalService) : ControllerBase
    {
         private readonly IFiscalService _fiscalInfoService = fiscalService;

        [HttpGet("initialize-device")]
        public async Task<IActionResult> InitializeDevice()
        {
            var response = await _fiscalInfoService.initializeDeviceAsync();
            return Ok(response);
        }

        [HttpGet("update-select-codes")]
        public async Task<IActionResult> UpdateSelectCodes()
        {
            await _fiscalInfoService.updateSelectCodes();
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