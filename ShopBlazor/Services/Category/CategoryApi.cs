using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Fluxor;
using ShopBlazor.FluxorServices.Error;
using ShopBlazor.FluxorServices.Loading;
using ShopBlazor.Helpers;
using System.Net.Http.Json;

namespace ShopBlazor.Services.Category
{
    public class CategoryApi : ICategoryApi

    {
        private readonly HttpClient _httpClient;
        private readonly IDispatcher _dispatcher;

        public CategoryApi(HttpClient httpClient, IDispatcher dispatcher)
        {
            _httpClient = httpClient;
            _dispatcher = dispatcher;
        }

        public async Task<List<CategoryResponse>> All()
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                   await _httpClient.GetFromJsonAsync<List<CategoryResponse>>($"/api/Category/all");


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

        public async Task<CategoryResponse> CreateCategory(CategoryRequest categoryRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PostAsJsonAsync($"/api/Category", categoryRequest);

                if (response.IsSuccessStatusCode)
                {
                    CategoryResponse data = await response.Content.ReadFromJsonAsync<CategoryResponse>();

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

        public async Task<CategoryResponse> DeleteCategoryById(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response = await _httpClient.DeleteAsync($"/api/Category/{id}");

                if (response.IsSuccessStatusCode)
                {
                    CategoryResponse parsedResponse = await response.Content.ReadFromJsonAsync<CategoryResponse>();
                    await Task.Delay(500);

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

        public async Task<PaggingResponse<CategoryResponse>> FetchCategory(FetchDataCategoryRequest fetchDataCategoryRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                string query = StringHelper.ConvertObjectToSearchParam(fetchDataCategoryRequest);
                Console.WriteLine("query-------" + query);

                PaggingResponse<CategoryResponse> response =
                    await _httpClient.GetFromJsonAsync<PaggingResponse<CategoryResponse>>($"/api/Category/FetchCategory?{query}&PageSize={fetchDataCategoryRequest.PageSize} ");

                await Task.Delay(1000);

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

        public async Task<CategoryResponse> GetCategoryByID(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));
                CategoryResponse response = await _httpClient.GetFromJsonAsync<CategoryResponse>($"/api/Category/{id}");
                await Task.Delay(500);
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

        public async Task<CategoryResponse> UpdateCategory(string id, CategoryRequest categoryRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PutAsJsonAsync($"/api/Category/{id}", categoryRequest);

                if (response.IsSuccessStatusCode)
                {
                    CategoryResponse data = await response.Content.ReadFromJsonAsync<CategoryResponse>();

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