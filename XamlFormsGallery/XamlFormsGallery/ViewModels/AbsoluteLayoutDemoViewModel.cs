using System;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class AbsoluteLayoutDemoViewModel : ViewModelBase, IInstancePerLifetimeScope, IDisposable
    {
        private bool _isActive;
        private Rectangle _label1Bounds;
        private Rectangle _label2Bounds;
        private readonly DateTime _beginTime;

        public AbsoluteLayoutDemoViewModel()
        {
            _beginTime = DateTime.Now;
            _isActive = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallback);
        }

        public Rectangle Label1Bounds
        {
            get { return _label1Bounds; }
            private set { SetProperty(ref _label1Bounds, value); }
        }

        public Rectangle Label2Bounds
        {
            get { return _label2Bounds; }
            private set { SetProperty(ref _label2Bounds, value); }
        }

        private bool TimerCallback()
        {
            double seconds = (DateTime.Now - _beginTime).TotalSeconds;
            double offset = 1 - Math.Abs((seconds % 2) - 1);

            Label1Bounds = new Rectangle(
                offset, 
                offset, 
                AbsoluteLayout.AutoSize, 
                AbsoluteLayout.AutoSize);

            Label2Bounds = new Rectangle(
                1 - offset, 
                offset, 
                AbsoluteLayout.AutoSize, 
                AbsoluteLayout.AutoSize);

            return _isActive;
        }

        public void Dispose()
        {
            _isActive = false;
        }
    }
}