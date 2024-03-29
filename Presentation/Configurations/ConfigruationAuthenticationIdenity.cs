﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Model;
using Model.Modules.UserModel;
using System.Text;

namespace Presentation.Congigruations
{
    public static class ConfigruationAuthenticationIdenity
    {

        public static void ConfigureAuthentication(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;


            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new
                Microsoft.IdentityModel.Tokens.TokenValidationParameters

                {
                    ValidateIssuer = true,

                    ValidateAudience = true,

                    ValidAudience = configuration["JWT:ValidAudience"],

                    ValidIssuer = configuration["JWT:ValidIssuer"],

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Serect"]


                        ))
                };



                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];

                        // If the request is for our hub...
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            (path.StartsWithSegments("/hub/AppChat")))
                        {

                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };



            }).AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = "160242434444-j1q01on5dfqkt3h27e1e1j9idqfjgivs.apps.googleusercontent.com";
                googleOptions.ClientSecret = "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";
            }); ;

        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            ///register identity
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DBApiContext>()
                .AddDefaultTokenProviders();



            //identity option
            services.Configure<IdentityOptions>(
                options =>

                {
                    options.SignIn.RequireConfirmedEmail = true;

                    ///// Default Password settings.
                    // Password settings.
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 0;


                    /////
                    // User settings.
                    options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = true;

                }

            );

            //token for confirm mail. re-password......
            services.Configure<DataProtectionTokenProviderOptions>(
                op =>
                {

                    op.TokenLifespan = TimeSpan.FromHours(30);
                });

        }
    }
}
