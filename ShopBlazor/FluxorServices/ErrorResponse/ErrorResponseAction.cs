using ShopBlazor.EnumGeneric;

namespace ShopBlazor.FluxorServices.ErrorResponse
{
    public class ErrorResponseAction
    {

        public ResponseModelErrors _responseModelErrors { get; } = null;

        public ErrorResponseAction(ResponseModelErrors responseModelErrors)
        {

            _responseModelErrors = responseModelErrors;
        }
    }
}
