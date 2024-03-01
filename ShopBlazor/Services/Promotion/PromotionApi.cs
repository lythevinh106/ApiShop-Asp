using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Fluxor;
using ShopBlazor.FluxorServices.Error;
using ShopBlazor.FluxorServices.Loading;
using ShopBlazor.Helpers;
using ShopBlazor.Services.Promotion;
using System.Net.Http.Json;

namespace ShopBlazor.Services.Prmotion
{
    public class PromotionApi : IPromotionApi

    {
        private readonly HttpClient _httpClient;
        private readonly IDispatcher _dispatcher;
        private readonly StringHelper _stringHelper;

        public PromotionApi(HttpClient httpClient, IDispatcher dispatcher, StringHelper stringHelper)
        {
            _httpClient = httpClient;
            _dispatcher = dispatcher;
            _stringHelper = stringHelper;
        }

        public async Task<List<PromotionResponse>> All()
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                   await _httpClient.GetFromJsonAsync<List<PromotionResponse>>($"/api/Promotion/all");


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

        public async Task<PromotionResponse> CreatePromotion(PromotionRequest promotionRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PostAsJsonAsync($"/api/Promotion", promotionRequest);

                if (response.IsSuccessStatusCode)
                {
                    PromotionResponse data = await response.Content.ReadFromJsonAsync<PromotionResponse>();

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

        public async Task<PromotionResponse> DeletePromotionById(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response = await _httpClient.DeleteAsync($"/api/Promotion/{id}");

                if (response.IsSuccessStatusCode)
                {
                    PromotionResponse parsedResponse = await response.Content.ReadFromJsonAsync<PromotionResponse>();
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

        public async Task<PaggingResponse<PromotionResponse>> FetchPromotion(FetchDataPromotionRequest fetchDataPromotionRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                string query = _stringHelper.ConvertObjectToSearchParam(fetchDataPromotionRequest);
                Console.WriteLine("query-------" + query);

                PaggingResponse<PromotionResponse> response =
                    await _httpClient.GetFromJsonAsync<PaggingResponse<PromotionResponse>>($"/api/Promotion/FetchPromotion?{query}&PageSize={fetchDataPromotionRequest.PageSize} ");

                // await Task.Delay(1000);

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

        public async Task<PromotionResponse> GetPromotionByID(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));
                PromotionResponse response = await _httpClient.GetFromJsonAsync<PromotionResponse>($"/api/Promotion/{id}");
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

        public async Task<PromotionResponse> UpdatePromotion(string id, PromotionRequest promotionRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PutAsJsonAsync($"/api/Promotion/{id}", promotionRequest);

                if (response.IsSuccessStatusCode)
                {
                    PromotionResponse data = await response.Content.ReadFromJsonAsync<PromotionResponse>();

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