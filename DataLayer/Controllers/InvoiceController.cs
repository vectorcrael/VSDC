using System;
using DataLayer.Models;
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
        public async Task<IActionResult> UpdateFiscalDetails(byte [] signature, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string qrCode, string vsdcDate)
        {
            await _fiscalInfoService.UpdateFiscalDetailsAsync(signature, internalData, invoiceNumber, invoiceType, invoiceSequence, qrCode, vsdcDate);
            return NoContent();
        }
    }
}

