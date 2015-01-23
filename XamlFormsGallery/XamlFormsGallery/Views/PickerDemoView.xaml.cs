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
            viewModel.InitPicker(Picker);
        }
    }
}
