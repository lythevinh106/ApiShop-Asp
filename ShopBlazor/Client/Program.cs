global using Blazored.LocalStorage;
using Fluxor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopBlazor.Authentication;
using ShopBlazor.Helpers;
using ShopBlazor.Services.Category;
using ShopBlazor.Services.Order;
using ShopBlazor.Services.Prmotion;
using ShopBlazor.Services.Product;
using ShopBlazor.Services.Promotion;
using ShopBlazor.Services.User;

namespace ShopBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7148") });
            builder.Services.AddScoped<JsHelper>();
            builder.Services.AddScoped<StringHelper>();

            builder.Services.AddScoped<ICategoryApi, CategoryApi>();
            builder.Services.AddScoped<IProductApi, ProductApi>();
            builder.Services.AddScoped<IOrderApi, OrderApi>();
            builder.Services.AddScoped<IPromotionApi, PromotionApi>();

            builder.Services.AddFluxor(o =>
            {
                o.ScanAssemblies(typeof(Program).Assembly);

                o.UseReduxDevTools(rdt =>
                {
                    rdt.Name = "My application";
                });
            });






            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            builder.Services.AddScoped<UserApi>();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazorBootstrap();




            await builder.Build().RunAsync();
        }
    }
}
