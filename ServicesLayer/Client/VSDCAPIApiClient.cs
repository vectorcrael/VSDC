using System.Net.Http.Headers;
using System.Text;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ServicesLayer.DTOs;

namespace VSDCAPI
{
    public class VSDCAPIApiClient : IVSDCAPIApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<VSDCAPIApiClient> _logger;
        private readonly string _currentUrl = "localhost:8080/zrasandboxvsdc";
        public VSDCAPIApiClient(HttpClient httpClient, ILogger<VSDCAPIApiClient> logger)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri($"http://{_currentUrl}/");
            _logger = logger;
        }

        public async Task<Stream> TestServerRunning()
        {
            try
            {
                var response = await _httpClient.GetAsync($"");
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "TestServerRunning");
                throw;
            }
        }

        public async Task<ZraResponse?> DeviceInitialization(DeviceInitializationRequest request)
        {
            try
            {
                // get the response
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"initializer/selectInitInfo", request);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the content as a string
                var contentString = await response.Content.ReadAsStringAsync();

                // Deserialize the stream content 
                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);

                // Convert the string back to a stream
                return responseDeserialized;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeviceInitialization");
                throw;
            }
        }

        public async Task<ZraResponse?> GetUnitsOfMeasure(RequestParameters request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"code/selectCodes", request);
                var contentString = await response.Content.ReadAsStringAsync();
                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetUnitsOfMeasure");
                throw;
            }
        }

        public async Task<ZraResponse?> GetClassificationCodes(RequestParameters request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"itemClass/selectItemsClass", request);
                var contentString = await response.Content.ReadAsStringAsync();
                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ClassificationCodes");
                throw;
            }
        }

        public async Task<ZraResponse?> Notices(RequestParameters request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"notices/selectNotices", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Notices");
                throw;
            }
        }

        public async Task<ZraResponse?> Branches(RequestParameters request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/selectBranches", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Branches");
                throw;
            }
        }

        public async Task<ZraResponse?> GetItems(RequestParameters request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/selectItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetItems");
                throw;
            }
        }

        public async Task<ZraResponse?> Customers(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"customers/selectCustomer", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Customers");
                throw;
            }
        }

        public async Task<ZraResponse?> SaveStockMaster(SaveStockMasterRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stockMaster/saveStockMaster", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SaveStockMaster");
                throw;
            }
        }

        public async Task<ZraResponse?> GetPurchases(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsPurchase/selectTrnsPurchaseSales", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetPurchases");
                throw;
            }
        }

        public async Task<ZraResponse?> GetStockItems(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stock/selectStockItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetStockItems");
                throw;
            }
        }

        public async Task<ZraResponse?> SaveStockItem(SaveStockItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stock/saveStockItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> SavePurchases(SavePurchasesRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsPurchase/savePurchase", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> SelectInvoice(SelectInvoiceRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsSales/selectInvoice", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> SaveSales(SaveSalesRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsSales/saveSales", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> UpdateImportItems(UpdateImportItemsRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"imports/updateImportItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> GetImports(GetImportsRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"imports/selectImportItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> GetItems2(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/selectItems", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> SaveItemComposition(SaveItemCompositionRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/saveItemComposition", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> UpdateItem(UpdateItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/updateItem", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> SaveItems(UpdateItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/saveItem", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> BranchCustomers(BranchCustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/saveBrancheCustomers", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> BranchUser(BranchUserRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/saveBrancheUser", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<ZraResponse?> DeviceInitializationTest(DeviceInitializationRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"initializer/selectInitInfo", request);
                var contentString = await response.Content.ReadAsStringAsync();

                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);
                return responseDeserialized;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    }
}