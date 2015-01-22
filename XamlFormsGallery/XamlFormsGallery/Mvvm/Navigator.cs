using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlFormsGallery.Mvvm
{
    class Navigator : INavigator
    {
        private readonly Lazy<INavigation> _lazyNavigation;
        private readonly IViewFactory _viewFactory;

        public Navigator(Lazy<INavigation> lazyNavigation, IViewFactory viewFactory)
        {
            _lazyNavigation = lazyNavigation;
            _viewFactory = viewFactory;
        }

        public async Task PushAsync(string pageName)
        {
            Page page = _viewFactory.ResolvePage(pageName);

            if (page == null)
            {
                return;
            }

            await _lazyNavigation.Value.PushAsync(page);
        }
    }
}