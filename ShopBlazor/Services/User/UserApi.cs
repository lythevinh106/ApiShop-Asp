using DtoShared.ModulesDto;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Newtonsoft.Json;
using ShopBlazor.EnumGeneric;
using ShopBlazor.FluxorServices.Error;
using ShopBlazor.FluxorServices.ErrorResponse;
using ShopBlazor.FluxorServices.Loading;
using ShopBlazor.Helpers;
using System.Net.Http.Json;


namespace ShopBlazor.Services.User
{
    public class UserApi
    {


        private readonly HttpClient _httpClient;
        private readonly IDispatcher _dispatcher;
        private readonly NavigationManager _navigationManager;
        private readonly ILocalStorageService _localStorageService;
        private AuthenticationStateProvider _authenticationStateProvider;



        public UserApi(HttpClient httpClient, IDispatcher dispatcher, StringHelper stringHelper,
            ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider
           , NavigationManager navigationManager

            )
        {
            _httpClient = httpClient;
            _dispatcher = dispatcher;
            _localStorageService = localStorageService;
            _authenticationStateProvider = authenticationStateProvider;
            _navigationManager = navigationManager;



        }

        public async Task<SingInResponse> Login(SingInUser singInUser)
        {


            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));


                var response = await _httpClient.PostAsJsonAsync($"/api/User/SingIn", singInUser);


                if (response.IsSuccessStatusCode)
                {
                    SingInResponse data = await response.Content.ReadFromJsonAsync<SingInResponse>();

                    _dispatcher.Dispatch(new LoadingAction(false));
                    _localStorageService.SetItemAsync("token", data.jwtToken);
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




        public async Task<bool> Register(RegisterUser registerUser)
        {


            try
            {
                _dispatcher.Dispatch(new LoadingAction(true));


                var response = await _httpClient.PostAsJsonAsync($"/api/User", registerUser);


                if (!response.IsSuccessStatusCode)
                {
                    _dispatcher.Dispatch(new LoadingAction(false));

                    var errorDetails = await response.Content.ReadAsStringAsync();

                    ResponseModelErrors errorObject = JsonConvert.DeserializeObject<ResponseModelErrors>(errorDetails);

                    _dispatcher.Dispatch(new ErrorResponseAction(errorObject));
                    return false;

                }
                bool data = await response.Content.ReadFromJsonAsync<bool>();

                _dispatcher.Dispatch(new LoadingAction(false));

                return data;

            }
            catch (Exception ex)
            {
                _dispatcher.Dispatch(new LoadingAction(false));

                _dispatcher.Dispatch(new ActiveError(true, ex.Message));
                throw new Exception(ex.Message);
            }

        }









        public async Task Logout()
        {


            await _localStorageService.RemoveItemAsync("token");
            await _authenticationStateProvider.GetAuthenticationStateAsync();
            _navigationManager.NavigateTo("/login");

        }




    }
}

