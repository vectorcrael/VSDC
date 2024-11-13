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
        Task<ZraResponse?> GetClassificationCodes(RequestParameters request);
        Task<ZraResponse?> Notices(RequestParameters request);
        Task<ZraResponse?> Branches(RequestParameters request);
        Task<ZraResponse?> GetItems(RequestParameters request);
        Task<ZraResponse?> Customers(CustomersRequest request);
        Task<ZraResponse?> SaveStockMaster(SaveStockMasterRequest request);
        Task<ZraResponse?> GetPurchases(CustomersRequest request);
        Task<ZraResponse?> GetStockItems(CustomersRequest request);
        Task<ZraResponse?> SaveStockItem(SaveStockItemRequest request);
        Task<ZraResponse?> SavePurchases(SavePurchasesRequest request);
        Task<ZraResponse?> SelectInvoice(SelectInvoiceRequest request);
        Task<ZraResponse> SaveSales(SaveSalesRequest request);
        Task<ZraResponse?> UpdateImportItems(UpdateImportItemsRequest request);
        Task<ZraResponse?> GetImports(GetImportsRequest request);
        Task<ZraResponse?> GetItems2(CustomersRequest request);
        Task<ZraResponse?> SaveItemComposition(SaveItemCompositionRequest request);
        Task<ZraResponse?> UpdateItem(UpdateItemRequest request);
        Task<ZraResponse?> SaveItems(UpdateItemRequest request);
        Task<ZraResponse?> BranchCustomers(BranchCustomersRequest request);
        Task<ZraResponse?> BranchUser(BranchUserRequest request);
        Task<ZraResponse?> DeviceInitializationTest(DeviceInitializationRequest request);
    }
}