using Xamarin.Forms;

namespace XamlFormsGallery.Mvvm
{
    public interface IViewFactory
    {
        Page ResolvePage(string pageName);
    }
}