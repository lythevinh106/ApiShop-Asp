using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace ShopBlazor.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {



        private readonly ClaimsPrincipal anonymous = new(new ClaimsIdentity());
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;

        public CustomAuthenticationStateProvider(

       ILocalStorageService localStorageService


            , HttpClient httpClient
            )
        {
            _localStorageService = localStorageService;

            _httpClient = httpClient;
        }


        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string token = null;
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);
            _httpClient.DefaultRequestHeaders.Authorization = null;

            //bool checkExits = await _localStorageService.ContainKeyAsync<st>("token");
            token = await _localStorageService.GetItemAsync<string>("token");


            if (!string.IsNullOrEmpty(token))
            {
                identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Replace("\"", ""));
                user = new ClaimsPrincipal(identity);
                state = new AuthenticationState(user);
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;


        }

        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
        }
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }




        //public async Task UpdateAuthenticationState(string? token)
        //{
        //    ClaimsPrincipal claimsPrincipal = new();
        //    if (!string.IsNullOrWhiteSpace(token))
        //    {
        //        var userSession = AuthenticationGeneric.GetClaimsFromToken(token);
        //        claimsPrincipal = AuthenticationGeneric.SetClaimPrincipal(userSession);
        //        await localStorageService.SetItemAsStringAsync("token", token);
        //    }
        //    else
        //    {
        //        claimsPrincipal = anonymous;
        //        await localStorageService.RemoveItemAsync("token");
        //    }
        //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        //}
    }
}
