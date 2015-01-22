using System;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class BoxViewDemoViewModel : ViewModelBase
    {
        private ImageSource _imageSource;

        public ImageSource ImageSource
        {
            get { return _imageSource; }
            private set { SetProperty(ref _imageSource, value); }
        }

        public BoxViewDemoViewModel()
        {
            ImageSource = Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                            ImageSource.FromFile("ide_xamarin_studio.png"),
                                            ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")));

        }
    }
}