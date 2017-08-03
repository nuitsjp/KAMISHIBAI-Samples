using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nuits.Xamarin.Forms.Kamishibai;
using Nuits.Xamarin.Forms.Kamishibai.Mvvm;

namespace KamishibaiSample.NavigationPage.ViewModels
{
    public class ContentPage15ViewModel : ViewModelBase, IPageLifecycleAware<string>, IApplicationLifecycleAware
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        
        public NavigationRequestCommand RequestPopAsync { get; } = new NavigationRequestCommand();
        
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
