using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class MapDemoViewModel : ViewModelBase
    {
        private string _androidDisclaimerText;
        private readonly ObservableCollection<Pin> _pins;
        private Position _centerPosition;
        private double _latitudeDegrees;
        private double _longitudeDegrees;

        public string AndroidDisclaimerText
        {
            get { return _androidDisclaimerText; }
            private set { SetProperty(ref _androidDisclaimerText, value); }
        }

        public ObservableCollection<Pin> Pins
        {
            get { return _pins; }
        }

        public Position CenterPosition
        {
            get { return _centerPosition; }
            set { SetProperty(ref _centerPosition, value); }
        }

        public double LongitudeDegrees
        {
            get { return _longitudeDegrees; }
            internal set { SetProperty(ref _longitudeDegrees, value); }
        }

        public double LatitudeDegrees
        {
            get { return _latitudeDegrees; }
            internal set { SetProperty(ref _latitudeDegrees, value); }
        }

        public MapDemoViewModel()
        {
            _pins = new ObservableCollection<Pin>();
            _pins.CollectionChanged += (sender, args) => OnPropertyChanged("Pins");
        }

        internal void InitializeMapData()
        {
            if (Device.OS == TargetPlatform.Android)
            {
                AndroidDisclaimerText = "Android applications require API key " +
                                        "to use the Google Map service.";
            }
            else
            {
                _latitudeDegrees = 0.01;
                _longitudeDegrees = 0.01;
                CenterPosition = new Position(37.79762, -122.40181);

                Pins.Add(new Pin
                {
                    Label = "Xamarin",
                    Position = CenterPosition
                });
            }
        }
    }
}