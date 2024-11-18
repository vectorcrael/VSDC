using System;
using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicaiton.Controllers
{
    public class InvoiceController(IDataService fiscalInfoService) : ControllerBase
    {
        [HttpGet("fiscal-info")]
        public async Task<IActionResult> GetFiscalInfos()
        {
            var fiscalInfos = await fiscalInfoService.GetAllFiscalInfosAsync();
            return Ok(fiscalInfos);
        }

        [HttpPost("fiscal-info")]
        public async Task<IActionResult> AddFiscalInfo([FromBody] FiscalInfo fiscalInfo)
        {
            await fiscalInfoService.AddFiscalInfoAsync(fiscalInfo);
            return CreatedAtAction(nameof(GetFiscalInfos), new { id = fiscalInfo.Id }, fiscalInfo);
        }

        [HttpGet("invoices")]
        public async Task<IActionResult> GetInvoices()
        {
            var invoices = await fiscalInfoService.GetZraInvoicesAsync();
            return Ok(invoices);
        }

        [HttpGet("invoice-items/{refId}")]
        public async Task<IActionResult> GetInvoiceItems(string refId)
        {
            var items = await fiscalInfoService.GetInvoiceItemsAsync(refId);
            return Ok(items);
        }

        [HttpGet("purchases")]
        public async Task<IActionResult> GetPurchases()
        {
            var purchases = await fiscalInfoService.GetAllPurchasesAsync();
            return Ok(purchases);
        }

        [HttpGet("purchase-items/{refId}")]
        public async Task<IActionResult> GetPurchaseItems(string refId)
        {
            var items = await fiscalInfoService.GetPurchaseItemsAsync(refId);
            return Ok(items);
        }

        [HttpPost("update-fiscal-details")]
        public async Task<IActionResult> UpdateFiscalDetails(byte[] signature, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string qrCode, string vsdcDate)
        {
            await fiscalInfoService.UpdateFiscalDetailsAsync(signature, internalData, invoiceNumber, invoiceType, invoiceSequence, qrCode, vsdcDate);
            return NoContent();
        }

        [HttpGet("purchases/{refId}")]
        public async Task<IActionResult> GetPurchase(string refId)
        {
            var purchase = await fiscalInfoService.GetZraSinglePurchaseAsync(refId);
            return Ok(purchase);
        }

        [HttpGet("purchases-update/{refId}")]
        public async Task<IActionResult> UpdatePurchaseTegTcd(string refId)
        {
            var status = 2;
            var purchase = await fiscalInfoService.GetZraSinglePurchaseAsync(refId);
            if (purchase != null)
            {
                status = await fiscalInfoService.UpdateZraPurchaseRegTcdAsync(refId);
            }
            if (status == 2)
                return NotFound(refId);
            else
                return Ok(purchase);
        }

        [HttpGet("stock-masters")]
        public async Task<IActionResult> GetStockMasters()
        {
            var stockMasters = await fiscalInfoService.GetStockMastersAsync();
            return Ok(stockMasters);
        }

        [HttpGet("device-init")]
        public async Task<IActionResult> GetDeviceInitInfo()
        {
            var deviceInits = await fiscalInfoService.GetAllDeviceInitsAsync();
            return Ok(deviceInits);
        }

        [HttpPost("device-init")]
        public async Task<IActionResult> UpdateDeviceInitInfo([FromBody] DeviceInit deviceInit)
        {
            await fiscalInfoService.SetDeviceInitsAsync(deviceInit);
            return NoContent();
        }

        [HttpGet("classification-codes")]
        public async Task<IActionResult> GetZraClassCodes()
        {
            var codes = await fiscalInfoService.GetAllZraClassCodesAsync();
            return Ok(codes);
        }

        [HttpPost("classification-codes")]
        public async Task<IActionResult> UpdateClassificationCodes([FromBody] ZraClassCode zraClassCode)
        {
            await fiscalInfoService.SetZraClassCodeAsync(zraClassCode);
            return NoContent();
        }

        [HttpGet("selected-codes")]
        public async Task<IActionResult> GetZraSelectCodes()
        {
            var codes = await fiscalInfoService.GetAllZraSelectCodesAsync();
            return Ok(codes);
        }

        [HttpPost("selected-codes")]
        public async Task<IActionResult> UpdateSelectedCodes([FromBody] ZraSelectCode zraClassCode)
        {
            await fiscalInfoService.SetZraSelectCodesAsync(zraClassCode);
            return NoContent();
        }
    }
}

