﻿using Autofac;
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
                .Where(v => !v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<Page>(t => t.Name)
                .SingleInstance();
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<Page>()
                .Where(v => v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<Page>(t => t.Name);

            // ViewModels
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<ViewModelBase>()
                .Where(v => !v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<ViewModelBase>(t => t.Name)
                .SingleInstance();
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AssignableTo<ViewModelBase>()
                .Where(v => v.IsAssignableTo<IInstancePerLifetimeScope>())
                .Named<ViewModelBase>(t => t.Name);
        }
    }
}