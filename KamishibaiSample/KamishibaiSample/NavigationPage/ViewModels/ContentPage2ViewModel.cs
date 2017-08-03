using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nuits.Xamarin.Forms.Kamishibai;
using Nuits.Xamarin.Forms.Kamishibai.Mvvm;

namespace KamishibaiSample.NavigationPage.ViewModels
{
    public class ContentPage2ViewModel : ViewModelBase, IPageLifecycleAware<DateTime>
    {
        private DateTime _dateTime;

        public DateTime DateTime
        {
            get => _dateTime;
            set => SetProperty(ref _dateTime, value);
        }
        
        public NavigationRequestCommand RequestPage3 { get; } = new NavigationRequestCommand();
        public NavigationRequestCommand<string> RequestInsert { get; } = new NavigationRequestCommand<string>();

        public void OnInitialize(DateTime parameter)
        {
            WriteLog(parameter);
            DateTime = parameter;
        }

        public void OnLoaded()
        {
            WriteLog();
        }

        public void OnUnloaded()
        {
            WriteLog();
        }

        public void OnClosed()
        {
            WriteLog();
        }

        private void WriteLog(object param = null, [CallerMemberName] string name = null)
        {
            Debug.WriteLine($"{GetType().Name}${name}({param})");
        }
    }
}
