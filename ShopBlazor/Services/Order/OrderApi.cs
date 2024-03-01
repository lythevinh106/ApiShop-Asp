using DtoShared.FetchData;
using DtoShared.ModulesDto;
using DtoShared.Pagging;
using Fluxor;
using ShopBlazor.FluxorServices.Error;
using ShopBlazor.FluxorServices.Loading;
using ShopBlazor.Helpers;
using System.Net.Http.Json;

namespace ShopBlazor.Services.Order
{
    public class OrderApi : IOrderApi
    {
        private readonly HttpClient _httpClient;
        private readonly IDispatcher _dispatcher;
        private readonly StringHelper _stringHelper;

        public OrderApi(HttpClient httpClient, IDispatcher dispatcher, StringHelper stringHelper)
        {
            _httpClient = httpClient;
            _dispatcher = dispatcher;
            _stringHelper = stringHelper;
        }

        public async Task<List<AnalysisDataInfo>> AnalysisData(int dayNumber)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                List<AnalysisDataInfo> response = await _httpClient.GetFromJsonAsync<List<AnalysisDataInfo>>($"/api/Order/AnalysisData/{dayNumber}");
                // await Task.Delay(500);
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

        public async Task<GroupAnalysisDataLineInfo> AnalysisDataLine(int dayNumber)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                GroupAnalysisDataLineInfo response = await _httpClient.GetFromJsonAsync<GroupAnalysisDataLineInfo>($"/api/Order/AnalysisDataLine/{dayNumber}");
                //  await Task.Delay(500);
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

        public async Task<CountOrderInfo> CountSoldInfo()
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                CountOrderInfo response = await _httpClient.GetFromJsonAsync<CountOrderInfo>($"/api/Order/CountSoldInfo");
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

        public async Task<OrderResponse> CreateOrder(OrderRequest orderRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PostAsJsonAsync($"/api/Order", orderRequest);

                if (response.IsSuccessStatusCode)
                {
                    OrderResponse data = await response.Content.ReadFromJsonAsync<OrderResponse>();

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

        public async Task<OrderDeleteResponse> DeleteOrderById(string id)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response = await _httpClient.DeleteAsync($"/api/Order/{id}");

                if (response.IsSuccessStatusCode)
                {
                    OrderDeleteResponse parsedResponse = await response.Content.ReadFromJsonAsync<OrderDeleteResponse>();
                    //
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

        public async Task<PaggingResponse<ProductOrderWithUserResponse>> FetchOrder(FetchDataOrderRequest fetchDataOrderRequest)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                string query = _stringHelper.ConvertObjectToSearchParam(fetchDataOrderRequest);
                Console.WriteLine("query-------" + query);

                PaggingResponse<ProductOrderWithUserResponse> response =
                    await _httpClient.GetFromJsonAsync<PaggingResponse<ProductOrderWithUserResponse>>($"/api/Order/FetchOrder?{query}&PageSize={fetchDataOrderRequest.PageSize} ");

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

        public async Task<ProductOrderWithUserResponse> GetOrderByID(string productId, string orderId)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));
                ProductOrderWithUserResponse response = await _httpClient.GetFromJsonAsync<ProductOrderWithUserResponse>($"/api/Order/getProductOrder?productId={productId}&orderId={orderId}");
                // await Task.Delay(500);
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

        public async Task<OrderResponse> UpdateOrder(string id, OrderUpdate orderUpdate)
        {
            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));

                var response =
                    await _httpClient.PutAsJsonAsync($"/api/Order/{id}", orderUpdate);

                if (response.IsSuccessStatusCode)
                {
                    OrderResponse data = await response.Content.ReadFromJsonAsync<OrderResponse>();

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
