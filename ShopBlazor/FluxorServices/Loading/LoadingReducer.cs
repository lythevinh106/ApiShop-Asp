using Fluxor;

namespace ShopBlazor.FluxorServices.Loading
{
    public static class LoadingReducer
    {
        [ReducerMethod]
        public static LoadingState ReduceActiveLoadingAction(
            LoadingState state,
           LoadingAction action)
        {
            return new LoadingState(
                 isActive: action._active
                );
        }
    }
}