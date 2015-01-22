using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamlFormsGallery.Annotations;

namespace XamlFormsGallery.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ICommand NavigateCommand =
            new Command<string>(async (s) =>
            {
                int x = 9;
            });

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}