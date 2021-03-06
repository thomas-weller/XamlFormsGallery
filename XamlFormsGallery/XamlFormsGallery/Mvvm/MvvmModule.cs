﻿using Autofac;
using Xamarin.Forms;

namespace XamlFormsGallery.Mvvm
{
    public class MvvmModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // standard Xamarin.Forms INavigation
            // remember to always use this as a deferred parameter in c'tor injection (Lazy<INavigation>)
            // ******************************************************************************************
            builder.Register(x => Application.Current.MainPage.Navigation)
                .SingleInstance();

            builder.RegisterType<ViewFactory>()
                .As<IViewFactory>()
                .SingleInstance();

            builder.RegisterType<Navigator>()
                .As<INavigator>()
                .SingleInstance();
        }
    }
}