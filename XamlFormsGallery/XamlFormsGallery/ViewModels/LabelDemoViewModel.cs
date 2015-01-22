using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class LabelDemoViewModel : ViewModelBase
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            private set { SetProperty(ref _text, value); }
        }

        public LabelDemoViewModel()
        {
            Text = "Xamarin.Forms is a cross-platform natively " +
                   "backed UI toolkit abstraction that allows " +
                   "developers to easily create user interfaces " +
                   "that can be shared across Android, iOS, and " +
                   "Windows Phone.";
        }
    }
}