using Presentation.EnumsPresention;

namespace Presentation.Middlewares
{
    public class ExceptionMiddleware
    {

        private readonly RequestDelegate next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            try
            {
                await next(context);

            }

            catch (Exception ex)
            {


                context.Response.ContentType = "application/json";

                var (code, message) = HandleException(ex);

                context.Response.StatusCode = code;

                var errorResponse = new ResponseErrors
                {
                    StatusCode = code,
                    Message = ex.Message
                };

                await context.Response.WriteAsync(errorResponse.ToString());

            }


        }

        private (int, string) HandleException(Exception ex)
        {
            int statusCode = StatusCodes.Status500InternalServerError;

            switch (ex)
            {
                case KeyNotFoundException or FileNotFoundException:

                    statusCode = StatusCodes.Status404NotFound;
                    break;

                case ArgumentException
                or InvalidOperationException:
                    statusCode = StatusCodes.Status400BadRequest;
                    break;

                case UnauthorizedAccessException:
                    statusCode = StatusCodes.Status401Unauthorized;
                    break;

                default:
                    statusCode = StatusCodes.Status500InternalServerError;
                    break;




            }
            return (statusCode, ex.Message);



        }
    }


}

