using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class MasterDetailPageDemoViewModel : ViewModelBase
    {
        // Dictionary to get Color from color name.
        private readonly Dictionary<string, Color> _nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua },         { "Black", Color.Black },
            { "Blue", Color.Blue },         { "Fuchsia", Color.Fuchsia },
            { "Gray", Color.Gray },         { "Green", Color.Green },
            { "Lime", Color.Lime },         { "Maroon", Color.Maroon },
            { "Navy", Color.Navy },         { "Olive", Color.Olive },
            { "Purple", Color.Purple },     { "Red", Color.Red },
            { "Silver", Color.Silver },     { "Teal", Color.Teal },
            { "White", Color.White },       { "Yellow", Color.Yellow }
        };

        private string _colorName;
        private Color _color;

        public string[] ColorNames
        {
            get { return _nameToColor.Keys.ToArray(); }
        }

        public string ColorName
        {
            get { return _colorName; }
            set { SetProperty(ref _colorName, value); }
        }

        public Color Color
        {
            get { return _color; }
            private set { SetProperty(ref _color, value); }
        }

        public MasterDetailPageDemoViewModel()
        {
            ColorName = _nameToColor.Keys.First();
            Color = _nameToColor[_colorName];

            PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                if (args.PropertyName == "ColorName")
                {
                    OnColorNameSelected();
                }
            };
        }

        private void OnColorNameSelected()
        {
            Color = string.IsNullOrEmpty(ColorName)
                ? Color.Default
                : _nameToColor[ColorName];
        }
    }
}