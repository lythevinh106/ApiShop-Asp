using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Fluxor;
using Microsoft.AspNetCore.Components.Forms;
using ShopBlazor.FluxorServices.Error;
using ShopBlazor.FluxorServices.Loading;
using ShopBlazor.Helpers;
using ShopBlazor.Pages.Product;
using System.Net.Http.Json;

namespace ShopBlazor.Services.Product
{
    public class ProductApi : IProductApi
    {



        private readonly HttpClient _httpClient;
        private readonly IDispatcher _dispatcher;
        private readonly StringHelper _stringHelper;

        public ProductApi(HttpClient httpClient, IDispatcher dispatcher, StringHelper stringHelper)
        {
            _httpClient = httpClient;
            _dispatcher = dispatcher;
            _stringHelper = stringHelper;
        }



        public Task<List<ProductResponse>> All()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductResponse> CreateProduct(ProductCreateRequestClient productCreateRequestClient)
        {



            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));


                using var multipartContent = new MultipartFormDataContent();

                multipartContent.Add(new StringContent(productCreateRequestClient.Name), "Name");
                multipartContent.Add(new StringContent(productCreateRequestClient.Description), "Description");
                multipartContent.Add(new StringContent(productCreateRequestClient.Price.ToString()), "Price");
                multipartContent.Add(new StringContent(productCreateRequestClient.CategoryId), "CategoryId");

                if (!string.IsNullOrEmpty(productCreateRequestClient.PromotionId))
                {
                    multipartContent.Add(new StringContent(productCreateRequestClient.PromotionId), "PromotionId");

                }

                if (productCreateRequestClient?.ImageFile != null)
                {
                    IBrowserFile fileImage = productCreateRequestClient.ImageFile;

                    StreamContent fileContent = new StreamContent(fileImage.OpenReadStream(fileImage.Size));

                    if (!string.IsNullOrWhiteSpace(fileImage.ContentType))
                    {
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(fileImage.ContentType);
                    }
                    multipartContent.Add(content: fileContent, name: "Image", fileName: fileImage.Name);
                }

                var response =
                    await _httpClient.PostAsync($"/api/Product", multipartContent);

                if (response.IsSuccessStatusCode)
                {
                    ProductResponse data = await response.Content.ReadFromJsonAsync<ProductResponse>();

                    _dispatcher.Dispatch(new LoadingAction(false));

                    return data;
                }
                _dispatcher.Dispatch(new LoadingAction(false));
                return null;
            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));

                _dispatcher.Dispatch(new ActiveError(true, ex.Message));
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductResponse> DeleteProductById(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response = await _httpClient.DeleteAsync($"/api/Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    ProductResponse parsedResponse = await response.Content.ReadFromJsonAsync<ProductResponse>();
                    //await Task.Delay(500);

                    _dispatcher.Dispatch(new LoadingAction(false));
                    return parsedResponse;
                }

                return null;
            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));

                _dispatcher.Dispatch(new ActiveError(true, ex.Message));

                throw new Exception(ex.Message);
            }
        }

        public async Task<PaggingResponse<ProductResponse>> FetchProduct(FetchDataProductRequest fetchDataProductRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                string query = _stringHelper.ConvertObjectToSearchParam(fetchDataProductRequest);
                Console.WriteLine("query-------" + query);

                PaggingResponse<ProductResponse> response =
                    await _httpClient.GetFromJsonAsync<PaggingResponse<ProductResponse>>($"/api/Product/FetchProduct?{query}&PageSize={fetchDataProductRequest.PageSize} ");

                //await Task.Delay(500);

                _dispatcher.Dispatch(new LoadingAction(false));
                return response;
            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));
                _dispatcher.Dispatch(new ActiveError(true, ex.Message));
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductResponse> GetProductByID(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));




                ProductResponse response = await _httpClient.GetFromJsonAsync<ProductResponse>($"/api/Product/{id}");
                //await Task.Delay(500);
                ;
                _dispatcher.Dispatch(new LoadingAction(false));
                return response;
            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));

                _dispatcher.Dispatch(new ActiveError(true, ex.Message));

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductResponse> UpdateProduct(string id, ProductUpdateRequestClient productUpdateRequestClient)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                using var multipartContent = new MultipartFormDataContent();
                multipartContent.Add(new StringContent(id), "Id");
                multipartContent.Add(new StringContent(productUpdateRequestClient.Name), "Name");
                multipartContent.Add(new StringContent(productUpdateRequestClient.Description), "Description");
                multipartContent.Add(new StringContent(productUpdateRequestClient.Price.ToString()), "Price");
                multipartContent.Add(new StringContent(productUpdateRequestClient.CategoryId), "CategoryId");

                if (!string.IsNullOrEmpty(productUpdateRequestClient.PromotionId))
                {
                    multipartContent.Add(new StringContent(productUpdateRequestClient.PromotionId), "PromotionId");

                }

                if (productUpdateRequestClient?.ImageFile != null)
                {
                    IBrowserFile fileImage = productUpdateRequestClient.ImageFile;

                    StreamContent fileContent = new StreamContent(fileImage.OpenReadStream(fileImage.Size));

                    if (!string.IsNullOrWhiteSpace(fileImage.ContentType))
                    {
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(fileImage.ContentType);
                    }
                    multipartContent.Add(content: fileContent, name: "Image", fileName: fileImage.Name);
                }








                var response =
                     await _httpClient.PutAsync($"/api/Product/{id}", multipartContent);

                if (response.IsSuccessStatusCode)
                {
                    ProductResponse data = await response.Content.ReadFromJsonAsync<ProductResponse>();

                    _dispatcher.Dispatch(new LoadingAction(false));

                    return data;
                }
                _dispatcher.Dispatch(new LoadingAction(false));
                return null;
            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));

                _dispatcher.Dispatch(new ActiveError(true, ex.Message));
                throw new Exception(ex.Message);
            }
        }
    }
}
