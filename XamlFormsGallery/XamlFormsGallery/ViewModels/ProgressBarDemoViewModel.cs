using System;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace XamlFormsGallery.ViewModels
{
    public class ProgressBarDemoViewModel : ViewModelBase, IInstancePerLifetimeScope, IDisposable
    {
        private bool _isActive;
        private double _progressValue;

        public double ProgressValue
        {
            get { return _progressValue; }
            private set { SetProperty(ref _progressValue, value); }
        }

        public ProgressBarDemoViewModel()
        {
            _isActive = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallback);
        }

        private bool TimerCallback()
        {
            ProgressValue += 0.01;
            return _isActive || ProgressValue == 1;
        }

        public void Dispose()
        {
            _isActive = false;
        }
    }
}