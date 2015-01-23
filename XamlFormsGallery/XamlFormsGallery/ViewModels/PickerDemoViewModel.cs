using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class PickerDemoViewModel : ViewModelBase
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

        private int _pickerIndex;
        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { SetProperty(ref _color, value); }
        }

        public int PickerIndex
        {
            private get { return _pickerIndex; }
            set { SetProperty(ref _pickerIndex, value); }
        }

        public string[] ColorNames
        {
            get { return _nameToColor.Keys.ToArray(); }
        }

        public PickerDemoViewModel()
        {
            PropertyChanged += (sender, args) =>
            {
                Color = PickerIndex == -1 ? 
                    Color.Default : 
                    _nameToColor[_nameToColor.ElementAt(PickerIndex).Key];
            };

            PickerIndex = -1;
        }

        internal void InitPicker(Picker picker)
        {
            foreach (string colorName in _nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }
        }
    }
}