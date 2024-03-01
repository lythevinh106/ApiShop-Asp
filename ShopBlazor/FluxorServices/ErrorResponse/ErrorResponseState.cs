using Fluxor;
using ShopBlazor.EnumGeneric;

namespace ShopBlazor.FluxorServices.ErrorResponse
{



    [FeatureState]
    public class ErrorResponseState
    {

        public ResponseModelErrors _responseModelErrors { get; } = null;

        private ErrorResponseState()
        {
            // Hàm tạo không tham số
        }

        public ErrorResponseState(
            ResponseModelErrors responseModelErrors

            )
        {

            _responseModelErrors = responseModelErrors;
        }

    }
}
