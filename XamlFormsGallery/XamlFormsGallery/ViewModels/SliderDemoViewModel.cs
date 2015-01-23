using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class SliderDemoViewModel : ViewModelBase
    {
        private string _labelText;
        private double _sliderValue;

        public string LabelText
        {
            get { return _labelText; }
            private set { SetProperty(ref _labelText, value); }
        }

        public double SliderValue
        {
            private get { return _sliderValue; }
            set { SetProperty(ref _sliderValue, value); }
        }

        public SliderDemoViewModel()
        {
            PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "SliderValue")
                {
                    LabelText = string.Format("Slider value is {0:F1}", SliderValue);
                }
            };

            LabelText = "Slider value is 0";
        }
    }
}