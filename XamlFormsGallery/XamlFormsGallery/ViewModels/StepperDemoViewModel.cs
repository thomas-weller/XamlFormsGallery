using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class StepperDemoViewModel : ViewModelBase
    {
        private string _labelText;
        private double _stepperValue;

        public string LabelText
        {
            get { return _labelText; }
            private set { SetProperty(ref _labelText, value); }
        }

        public double StepperValue
        {
            private get { return _stepperValue; }
            set { SetProperty(ref _stepperValue, value); }
        }

        public StepperDemoViewModel()
        {
            PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "StepperValue")
                {
                    LabelText = string.Format("Stepper value is {0:F1}", StepperValue);
                }
            };

            LabelText = "Stepper value is 0";
        }
    }
}