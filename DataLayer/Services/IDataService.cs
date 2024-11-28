using DataLayer.Models;

namespace DataLayer.Services;

public interface IDataService
{
    Task<List<FiscalInfo>> GetAllFiscalInfosAsync();
    Task AddFiscalInfoAsync(FiscalInfo fiscalInfo);
    Task<List<ZraInvoice>> GetZraInvoicesAsync();
    Task<List<ZraInvoiceItem>> GetInvoiceItemsAsync(string refId);
    Task<List<PurchaseInfo>> GetAllPurchasesAsync();
    Task<List<ZraPurchaseItem>> GetPurchaseItemsAsync(string refId);

    Task<int> UpdateFiscalDetailsAsync(byte[] qrCodeBinary, string internalData, string invoiceNumber,
        string invoiceType, string invoiceSequence, string signature, string vsdcDate);

    Task<List<ZraStockMaster>> GetStockMastersAsync();
    Task<List<ZraStockMaster>> GetStockAdjustmentsAsync();
    Task<ZraPurchase?> GetZraSinglePurchaseAsync(string refId);
    Task<int> UpdateZraPurchaseAsync(ZraPurchase zraPurchase);
    Task<int> UpdateZraPurchaseRegTcdAsync(string refId);
    Task<List<ZraPurchase>> GetZraPurchasesAsync();
    Task<List<DeviceInit>> GetAllDeviceInitsAsync();
    Task<int> SetDeviceInitsAsync(DeviceInit deviceInit);
    Task<List<ZraSelectCode>> GetAllZraSelectCodesAsync();
    Task<List<ZraClassCode>> GetAllZraClassCodesAsync();
    Task<int> SetZraClassCodeAsync(ZraClassCode zraClassCodes);
    Task<int> SetZraSelectCodesAsync(ZraSelectCode zraSelectCode);
    Task<int> SetImportsAsync(ZraImportData item);
    Task<int> UpdatePurchaseAsync(int invcNo, string message, string resultDt);
    Task<List<ZraImportData>> GetReceivedImportAsync();
    Task<int> SetSmartInvoiceAsync(SmartPurchase smartPurchase);
    Task<List<ZRASTockAdjustment>> GetOtherSrockAdjustmentsAsync();
}