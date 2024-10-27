using System.IO;
using System.Threading.Tasks;
using VSDCAPIApiClient.DTOs;

namespace VSDCAPI
{
    public interface IVSDCAPIApiClient
    {
        Task<Stream> TestServerRunning();
        Task<ZraResponse?> DeviceInitialization(DeviceInitializationRequest request);
        Task<ZraResponse?> GetUnitsOfMeasure(RequestParameters request);
        Task<ZraResponse?> ClassificationCodes(RequestParameters request);
        Task<Stream> Notices(RequestParameters request);
        Task<Stream> Branches(RequestParameters request);
        Task<Stream> GetItems(RequestParameters request);
        Task<Stream> Customers(CustomersRequest request);
        Task<Stream> SaveStockMaster(SaveStockMasterRequest request);
        Task<Stream> GetPurchases(CustomersRequest request);
        Task<Stream> GetStockItems(CustomersRequest request);
        Task<Stream> SaveStockItem(SaveStockItemRequest request);
        Task<Stream> SavePurchases(SavePurchasesRequest request);
        Task<Stream> SelectInvoice(SelectInvoiceRequest request);
        Task<ZraResponse> SaveSales(SaveSalesRequest request);
        Task<Stream> UpdateImportItems(UpdateImportItemsRequest request);
        Task<Stream> GetImports(GetImportsRequest request);
        Task<Stream> GetItems2(CustomersRequest request);
        Task<Stream> SaveItemComposition(SaveItemCompositionRequest request);
        Task<Stream> UpdateItem(UpdateItemRequest request);
        Task<Stream> SaveItems(UpdateItemRequest request);
        Task<Stream> BranchCustomers(BranchCustomersRequest request);
        Task<Stream> BranchUser(BranchUserRequest request);
        Task<Stream> DeviceInitializationTest(DeviceInitializationRequest request);
    }
}