using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class TableViewFormDemoViewModel : ViewModelBase
    {
        private ImageSource _imageCellImageSource;

        public ImageSource ImageCellImageSource
        {
            get { return _imageCellImageSource; }
            private set { SetProperty(ref _imageCellImageSource, value); }
        }

        public TableViewFormDemoViewModel()
        {
            ImageCellImageSource = Device.OnPlatform(
                ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                ImageSource.FromFile("ide_xamarin_studio.png"),
                ImageSource.FromFile("Images/ide-xamarin-studio.png"));
        }
    }
}