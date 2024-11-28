using ServicesLayer.DTOs;

namespace ServicesLayer.Services;

public interface IFiscalService
{
    Task TestServerRunning();
    Task<ZraResponse> InitializeDeviceAsync();
    Task UpdateSelectCodes();
    Task UpdateClassificationCodes();
    Task<List<ZraResponse?>> UpdateStockMaster();
    Task<List<ZraResponse?>> AdjustStockMaster();
    Task UpdateImports();
    Task<List<ZraResponse>> ReceivedImports();
    Task FiscalizePurchases();
    Task<List<ZraResponse>> FiscalizeInvoices();
    Task<SmartPurchases> GetPurchases();
    Task UpdateStockAdjustments();
}