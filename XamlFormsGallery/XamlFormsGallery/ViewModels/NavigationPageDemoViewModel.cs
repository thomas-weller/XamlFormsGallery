using System.Windows.Input;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class NavigationPageDemoViewModel : ViewModelBase
    {
        public ICommand NavigateCommand
        {
            get { return new Command<string>(async s => await Navigator.PushAsync(s)); }
        }
    }
}