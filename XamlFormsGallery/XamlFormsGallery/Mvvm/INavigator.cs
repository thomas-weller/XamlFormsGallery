using System.Threading.Tasks;

namespace XamlFormsGallery.Mvvm
{
    public interface INavigator
    {
        Task PushAsync(string pageName);
    }
}