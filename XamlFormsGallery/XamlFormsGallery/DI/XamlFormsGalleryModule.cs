using Autofac;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery
{
    public class XamlFormsGalleryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Views
            RegisterTypesWithBase<Page>(builder);

            // ViewModels
            RegisterTypesWithBase<ViewModelBase>(builder);
        }
        private void RegisterTypesWithBase<TBaseType>(ContainerBuilder builder)
        {
            RegisterSingletons<TBaseType>(builder);
            RegisterTransientTypes<TBaseType>(builder);
        }
        
        private void RegisterSingletons<TBaseType>(ContainerBuilder builder)
        {
            // Views
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<TBaseType>()
                .Where(v => !v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<TBaseType>(t => t.Name)
                .SingleInstance();
        }
        
        private void RegisterTransientTypes<TBaseType>(ContainerBuilder builder)
        {
            // Views
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<TBaseType>()
                .Where(v => v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<TBaseType>(t => t.Name);
        }
    }
}
