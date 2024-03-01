using Fluxor;

namespace ShopBlazor.FluxorServices.ErrorResponse
{
    public class ErrorResponseReducer
    {

        [ReducerMethod]
        public static ErrorResponseState ReduceActiveErrorResponse(
           ErrorResponseState state,
           ErrorResponseAction action)
        {
            return new ErrorResponseState(

                action._responseModelErrors


                );
        }
    }
}
