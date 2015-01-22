using System;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class ImageDemoViewModel : ViewModelBase
    {
        private string _header;
        private ImageSource _imageSource;

        public string Header
        {
            get { return _header; }
            private set { SetProperty(ref _header, value); }
        }

        public ImageSource ImageSource
        {
            get { return _imageSource; }
            private set { SetProperty(ref _imageSource, value); }
        }

        public ImageDemoViewModel()
        {
            Header = "Image";
            ImageSource = Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                            ImageSource.FromFile("ide_xamarin_studio.png"),
                                            ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")));

        }
    }
}