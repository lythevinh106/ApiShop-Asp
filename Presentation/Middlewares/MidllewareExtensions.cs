﻿namespace Presentation.Middlewares
{

    public static class MiddlewareExtensions
    {

        public static IApplicationBuilder UseHandleExceptionsMiddleware(this IApplicationBuilder builder)
        {
            // Log.Information("MiddlewareExtensions----");
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }


}
