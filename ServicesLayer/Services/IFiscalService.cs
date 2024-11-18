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
        Task receivedImports();
        Task fiscalizePurchases();
        Task fiscalizeInvoices();
        Task getPurchases();
        Task updateStockAdjustments();
    }

}