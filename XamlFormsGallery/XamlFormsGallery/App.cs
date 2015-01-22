using Autofac;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery
{
    public class App : Application
    {
        public App()
        {
            IContainer container = InitIoC();

            MainPage = new NavigationPage(container.Resolve<IViewFactory>().ResolvePage("Home"));
        }

        private static IContainer InitIoC()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<MvvmModule>();
            builder.RegisterModule<XamlFormsGalleryModule>();

            return builder.Build();
        }

    }
}
