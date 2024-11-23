using ServicesLayer.DTOs;

namespace VSDCAPI
{
    public interface IFiscalService
    {
        Task testServerRunning();
        Task<ZraResponse> initializeDeviceAsync();
        Task updateSelectCodes();
        Task updateClassificationCodes();
        Task<List<ZraResponse?>> updateStockMaster();
        Task<List<ZraResponse?>> adjustStockMaster();
        Task updateImports();
        Task <List<ZraResponse>>receivedImports();
        Task fiscalizePurchases();
        Task <List<ZraResponse>> fiscalizeInvoices();
        Task<SmartPurchases> getPurchases();
        Task UpdateStockAdjustments();
    }

}