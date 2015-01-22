using Xamarin.Forms;
using XamlFormsGallery.Views;

namespace XamlFormsGallery
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new HomeView());
        }
    }
}
