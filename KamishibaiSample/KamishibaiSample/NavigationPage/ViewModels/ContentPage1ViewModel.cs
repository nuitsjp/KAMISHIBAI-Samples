using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample.NavigationPage.ViewModels
{
    public class ContentPage1ViewModel : ViewModelBase, IPageLifecycleAware<string>, IApplicationLifecycleAware
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        
        public NavigationRequest<DateTime> RequestPage2 { get; } = new NavigationRequest<DateTime>();
        
        public ICommand NavigatePage2Command => new Command(() => RequestPage2.RaiseAsync(DateTime.Now));
        
        public NavigationRequestCommand RequestPopModalCommand { get; } = new NavigationRequestCommand();

        public void OnInitialize(string parameter)
        {
            WriteLog(parameter);
            Message = parameter;
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

        public void OnResume()
        {
            WriteLog();
        }

        public void OnSleep()
        {
            WriteLog();
        }

        private void WriteLog(object param = null, [CallerMemberName] string name = null)
        {
            Debug.WriteLine($"{GetType().Name}${name}({param})");
        }
    }
}
