using System;
using DataLayer.Models;
using DataLayer.Models2;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataLayer.Controllers
{
    public class InvoiceController : ControllerBase
    {
        private readonly IFiscalInfoService _fiscalInfoService;

        public InvoiceController(IFiscalInfoService fiscalInfoService)
        {
            _fiscalInfoService = fiscalInfoService;
        }

        [HttpGet("fiscal-info")]
        public async Task<IActionResult> GetFiscalInfos()
        {
            var fiscalInfos = await _fiscalInfoService.GetAllFiscalInfosAsync();
            return Ok(fiscalInfos);
        }

        [HttpPost("fiscal-info")]
        public async Task<IActionResult> AddFiscalInfo([FromBody] FiscalInfo fiscalInfo)
        {
            await _fiscalInfoService.AddFiscalInfoAsync(fiscalInfo);
            return CreatedAtAction(nameof(GetFiscalInfos), new { id = fiscalInfo.Id }, fiscalInfo);
        }

        [HttpGet("invoices")]
        public async Task<IActionResult> GetInvoices()
        {
            var invoices = await _fiscalInfoService.GetZraInvoicesAsync();
            return Ok(invoices);
        }

        [HttpGet("invoice-items/{refId}")]
        public async Task<IActionResult> GetInvoiceItems(string refId)
        {
            var items = await _fiscalInfoService.GetInvoiceItemsAsync(refId);
            return Ok(items);
        }

        [HttpGet("purchases")]
        public async Task<IActionResult> GetPurchases()
        {
            var purchases = await _fiscalInfoService.GetAllPurchasesAsync();
            return Ok(purchases);
        }

        [HttpGet("purchase-items/{refId}")]
        public async Task<IActionResult> GetPurchaseItems(string refId)
        {
            var items = await _fiscalInfoService.GetPurchaseItemsAsync(refId);
            return Ok(items);
        }

        [HttpPost("update-fiscal-details")]
        public async Task<IActionResult> UpdateFiscalDetails(byte[] signature, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string qrCode, string vsdcDate)
        {
            await _fiscalInfoService.UpdateFiscalDetailsAsync(signature, internalData, invoiceNumber, invoiceType, invoiceSequence, qrCode, vsdcDate);
            return NoContent();
        }

        [HttpGet("stock-masters")]
        public async Task<IActionResult> GetStockMasters()
        {
            var stockMasters = await _fiscalInfoService.GetStockMastersAsync();
            return Ok(stockMasters);
        }

        [HttpGet("device-init")]
        public async Task<IActionResult> GetDeviceInitInfo()
        {
            var deviceInits = await _fiscalInfoService.GetAllDeviceInitsAsync();
            return Ok(deviceInits);
        }

        [HttpPost("device-init")]
        public async Task<IActionResult> UpdateDeviceInitInfo([FromBody] DeviceInit deviceInit)
        {
            await _fiscalInfoService.SetDeviceInitsAsync(deviceInit);
            return NoContent();
        }

        [HttpGet("classification-codes")]
        public async Task<IActionResult> GetZraClassCodes()
        {
            var codes = await _fiscalInfoService.GetAllZraClassCodesAsync();
            return Ok(codes);
        }

        [HttpPost("classification-codes")]
        public async Task<IActionResult> UpdateClassificationCodes([FromBody] ZraClassCode zraClassCode)
        {
            await _fiscalInfoService.SetZraClassCodeAsync(zraClassCode);
            return NoContent();
        }

        [HttpGet("selected-codes")]
        public async Task<IActionResult> GetZraSelectCodes()
        {
            var codes = await _fiscalInfoService.GetAllZraSelectCodesAsync();
            return Ok(codes);
        }

        [HttpPost("selected-codes")]
        public async Task<IActionResult> UpdateSelectedCodes([FromBody] ZraSelectCode zraClassCode)
        {
            await _fiscalInfoService.SetZraSelectCodesAsync(zraClassCode);
            return NoContent();
        }
    }
}

