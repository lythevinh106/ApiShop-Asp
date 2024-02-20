using DataAccess.Infrastructure;
using DataAccess.Repositories;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Model;
using Presentation.Congigruations;
using Presentation.Middlewares;
using Serilog;
using Service.ServiceTools.Blob;
using Service.ServiceTools.Mail;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            //implement context

            builder.Services.AddDbContext<DBApiContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.UseLazyLoadingProxies();
            });



            //implement Identity
            builder.Services.ConfigureIdentity();

            //implement Authentication
            builder.Services.ConfigureAuthentication(builder.Configuration);


            builder.Services.AddScoped<IAccountRepository, UserRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            //builder.Services.AddSingleton<IUserIdProvider, EmailBaseUserIdProvider>();


            //cors
            builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
             policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));



            //AzureService
            ////add azure service bus :
            builder.Services.AddAzureClients((clientBuilder) =>
            {
                var conectionString = builder.Configuration.GetSection("Azure")["AzureNameSpace"];

                clientBuilder.AddServiceBusClient(conectionString).WithName("NameSpace");

                //var conectionString2 = "Endpoint=sb://demotopicsubnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=EBioRTP0KmzU8ACz13l7W46zAgmAz+cWf+ASbKrspYA=";

                //clientBuilder.AddServiceBusClient(conectionString2).WithName("client2");

                var conectionStringBlob = builder.Configuration.GetSection("Azure")["AzureBlob"];

                clientBuilder.AddBlobServiceClient(conectionStringBlob).WithName("blob1");
            });

            builder.Services.AddScoped<IBlob, BLobService>();
            //  builder.Services.AddScoped(typeof(IServiceBus<>), typeof(ServiceBus<>));





            //implement Di

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            //  builder.Services.AddScoped<ICacheService, CacheService>();


            //implement automapper


            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            //Mail

            builder.Services.AddScoped<MailKit.Net.Smtp.SmtpClient>();

            builder.Services.AddScoped<IMail, MailService>();





            //implement MediatR

            builder.Services.AddMediatR(cfg =>

            {
                cfg.RegisterServicesFromAssemblyContaining<Service.Application.BaseHandler>();

                //cfg.AddOpenBehavior(typeof(CacheBehavior<,>));
                //cfg.AddOpenBehavior(typeof(UpdateCacheBehavior<,>));
            });




            //implement  Serilog
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();
            builder.Host.UseSerilog();




            //implement HangFire
            builder.Services.AddHangfire(configuration => configuration
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(builder.Configuration.GetConnectionString("HangfireConnection")));

            /// implement hangFire server
            builder.Services.AddHangfireServer();













            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors();


            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();





            //implement Middlewares
            app.UseHandleExceptionsMiddleware();

            app.MapControllers();


            ///hangfire
            app.UseHangfireDashboard();
            app.MapHangfireDashboard("/hangfire");





            app.Run();
        }
    }
}
