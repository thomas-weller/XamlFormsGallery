using System;
using System.ComponentModel;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class SwitchDemoViewModel : ViewModelBase
    {
        private string _labelText;
        private bool _switchIsToggled;

        public string LabelText
        {
            get { return _labelText; }
            private set { SetProperty(ref _labelText, value); }
        }

        public bool SwitchIsToggled
        {
            private get { return _switchIsToggled; }
            set { SetProperty(ref _switchIsToggled, value); }
        }

        public SwitchDemoViewModel()
        {
            PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "SwitchIsToggled")
                {
                    LabelText = string.Format("Switch is now {0}", SwitchIsToggled);
                }
            };

            LabelText = "Switch is now False";
        }
    }
}