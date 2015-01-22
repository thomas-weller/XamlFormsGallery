using Autofac;
using Xamarin.Forms;

namespace XamlFormsGallery.Mvvm
{
    public class ViewFactory : IViewFactory
    {
        private readonly IComponentContext _componentContext;

        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public Page ResolvePage(string pageName)
        {
            string viewName = GetViewName(pageName);

            if (!_componentContext.IsRegisteredWithName<Page>(viewName))
            {
                return null;
            }

            var page = _componentContext.ResolveNamed<Page>(viewName);
           
            string viewModelName = GetViewModelName(pageName);
            if (_componentContext.IsRegisteredWithName<ViewModelBase>(viewModelName))
            {
                var viewModel = _componentContext.ResolveNamed<ViewModelBase>(viewModelName);
                viewModel.Navigator = _componentContext.Resolve<INavigator>();

                page.BindingContext = viewModel;
            }

            return page;
        }

        private static string GetViewName(string pageName)
        {
            return pageName + "View";
        }

        private static string GetViewModelName(string pageName)
        {
            return pageName + "ViewModel";
        }
    }
}