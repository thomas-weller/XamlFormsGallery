using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamlFormsGallery.Annotations;

namespace XamlFormsGallery.Mvvm
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private string _title;

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigator Navigator { get; internal set; }

        public string Title
        {
            get { return _title; }
            internal set { SetProperty(ref _title, value); }
        }


        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}