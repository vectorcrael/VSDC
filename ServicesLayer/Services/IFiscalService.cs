using ServicesLayer.DTOs;

namespace VSDCAPI
{
    public interface IFiscalService
    {
        Task testServerRunning();
        Task<ZraResponse> initializeDeviceAsync();
        Task updateSelectCodes();
        Task updateClassificationCodes();
        Task updateStockMaster();
        Task updateImports();
        Task <List<ZraResponse>>receivedImports();
        Task fiscalizePurchases();
        Task fiscalizeInvoices();
        Task<SmartPurchases> getPurchases();
        Task updateStockAdjustments();
    }

}