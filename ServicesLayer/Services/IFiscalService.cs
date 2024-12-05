using DataLayer.Models;
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
    Task<List<ZraResponse?>> FiscalizePurchases();
    Task<List<ZraResponse>> FiscalizeInvoices();
    Task<SmartPurchases> GetPurchases();
    Task UpdateStockAdjustments();
    Task<List<ZraResponse?>> saveItemFromStockAdjustments();
    Task<List<ZraResponse?>> saveItemFromPurchases(List<ZraPurchase> purchases);
}