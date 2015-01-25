using Xamarin.Forms;
using XamlFormsGallery.Models;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class TabbedPageDemoViewModel : ViewModelBase
    {
        private readonly NamedColor[] _namedColors = new[]
        {
            new NamedColor("Red", Color.Red),
            new NamedColor("Yellow", Color.Yellow), 
            new NamedColor("Green", Color.Green),
            new NamedColor("Aqua", Color.Aqua),
            new NamedColor("Blue", Color.Blue),
            new NamedColor("Purple", Color.Purple)  
        };

        public NamedColor[] NamedColors
        {
            get { return _namedColors; }
        }
    }
}