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
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<Page>()
                .Named<Page>(t => t.Name)
                .SingleInstance();

            // ViewModels
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<ViewModelBase>()
                .Named<ViewModelBase>(t => t.Name)
                .SingleInstance();
        }
    }
}