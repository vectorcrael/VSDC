using System;
using DataLayer.Models;
using DataLayer.Models2;

namespace DataLayer.Services
{
    public interface IFiscalInfoService
    {
        Task<List<FiscalInfo>> GetAllFiscalInfosAsync();
        Task AddFiscalInfoAsync(FiscalInfo fiscalInfo);
        Task<List<ZraInvoice>> GetZraInvoicesAsync();
        Task<List<ZraInvoiceItem>> GetInvoiceItemsAsync(string refId);
        Task<List<PurchaseInfo>> GetAllPurchasesAsync();
        Task<List<ZraInvoiceItem>> GetPurchaseItemsAsync(string refId);
        Task<int> UpdateFiscalDetailsAsync(byte [] signature, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string qrCode, string vsdcDate);
        Task<List<ZraStockMaster>> GetStockMastersAsync();

    }
}

