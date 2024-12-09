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
    Task<List<ZraResponse?>> SaveItemFromStockAdjustments(); 
    Task<List<ZraResponse?>> SaveStockItem();
    Task<List<ZraResponse?>> SaveStockMaster(StockList stockList);
    Task<List<ZraResponse?>> SaveItemFromPurchases(List<ZraPurchase> purchases);
}