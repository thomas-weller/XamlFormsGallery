using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class WebViewDemoViewModel : ViewModelBase
    {
        private string _url;

        public string Url
        {
            get { return _url; }
            private set { SetProperty(ref _url, value); }
        }

        public WebViewDemoViewModel()
        {
            Url = "http://blog.xamarin.com/";
        }
    }
}