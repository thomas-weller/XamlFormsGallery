using System;
using Xamarin.Forms;

namespace XamlFormsGallery.Views
{
    public partial class MasterDetailPageDemoView : MasterDetailPage
    {
        public MasterDetailPageDemoView()
        {
            InitializeComponent();
            IsPresented = true;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            IsPresented = false;
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (Device.OS != TargetPlatform.iOS)
            {
                IsPresented = !IsPresented;
            }
        }
    }
}
