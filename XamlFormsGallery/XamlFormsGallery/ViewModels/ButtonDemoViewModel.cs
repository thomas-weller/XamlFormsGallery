using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class ButtonDemoViewModel : ViewModelBase
    {
        private int _clickTotal;
        private string _clickCountText;
        private ICommand _clickedCommand;

        public ICommand ClickedCommand
        {
            get { return _clickedCommand ?? (_clickedCommand = new Command(ExecuteClickedCommand)); }
        }

        private void ExecuteClickedCommand()
        {
            ClickCountText = String.Format("{0} button clicks", ++_clickTotal);
        }

        public string ClickCountText
        {
            get { return _clickCountText; }
            private set { SetProperty(ref _clickCountText, value); }
        }

        public ButtonDemoViewModel()
        {
            ClickCountText = "0 button clicks";
        }
    }
}