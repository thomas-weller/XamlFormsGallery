using Xamarin.Forms;

namespace XamlFormsGallery.Models
{
    public class NamedColor
    {
        public NamedColor(string name, Color color)
        {
            Color = color;
            Name = name;
        }

        public string Name { get; private set; }
        public Color Color { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}