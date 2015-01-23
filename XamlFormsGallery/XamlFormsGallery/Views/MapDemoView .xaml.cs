using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamlFormsGallery.ViewModels;

namespace XamlFormsGallery.Views
{
    public partial class MapDemoView : ContentPage
    {
        public MapDemoView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var viewModel = (MapDemoViewModel)BindingContext;

            viewModel.PropertyChanged += ViewModelOnPropertyChanged;
            viewModel.InitializeMapData();
        }

        private void ViewModelOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            var viewModel = (MapDemoViewModel)BindingContext;

            if (viewModel == null)
            {
                return;
            }

            if (args.PropertyName == "Pins")
            {
                Map.Pins.Clear();
                foreach (Pin pin in viewModel.Pins)
                {
                    Map.Pins.Add(pin);
                }
            }
            else
            {
                Map.MoveToRegion(new MapSpan(
                    viewModel.CenterPosition,
                    viewModel.LatitudeDegrees,
                    viewModel.LongitudeDegrees));
            }
        }
    }
}
