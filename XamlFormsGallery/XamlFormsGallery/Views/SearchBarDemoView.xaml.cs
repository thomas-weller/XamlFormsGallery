using System;
using Xamarin.Forms;

namespace XamlFormsGallery.Views
{
    public partial class SearchBarDemoView : ContentPage
    {
        public SearchBarDemoView()
        {
            InitializeComponent();
        }

        private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
        {
            var searchBar = (SearchBar)sender;
            string searchText = searchBar.Text;
        }
    }
}
