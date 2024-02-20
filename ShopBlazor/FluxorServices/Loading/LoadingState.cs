using Fluxor;

namespace ShopBlazor.FluxorServices.Loading
{

    [FeatureState]
    public class LoadingState
    {

        public bool _isActive { get; }


        private LoadingState() { }

        public LoadingState(bool isActive

           )
        {

            _isActive = isActive;
        }
    }
}
