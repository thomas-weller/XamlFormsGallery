using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class MapDemoViewModel : ViewModelBase
    {
        private string _androidDisclaimerText;
        private Map _map;

        public string AndroidDisclaimerText
        {
            get { return _androidDisclaimerText; }
            private set { SetProperty(ref _androidDisclaimerText, value); }
        }

        public MapDemoViewModel()
        {
            if (Device.OS == TargetPlatform.Android)
            {
                AndroidDisclaimerText = "Android applications require API key " +
                                        "to use the Google Map service.";
            }
        }

        internal void InitializeMap(Map map)
        {
            _map = map;

            // Let's visit Xamarin HQ in San Francisco!
            var position = new Position(37.79762, -122.40181);
            _map.MoveToRegion(new MapSpan(position, 0.01, 0.01));
            _map.Pins.Add(new Pin
            {
                Label = "Xamarin",
                Position = position
            });
        }
    }
}