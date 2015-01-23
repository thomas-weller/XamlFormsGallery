using Xamarin.Forms;
using XamlFormsGallery.ViewModels;

namespace XamlFormsGallery.Views
{
    public partial class PickerDemoView : ContentPage
    {
        public PickerDemoView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var viewModel = (PickerDemoViewModel)BindingContext;

            foreach (string colorName in viewModel.ColorNames)
            {
                Picker.Items.Add(colorName);
            }
        }
    }
}
