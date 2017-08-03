using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nuits.Xamarin.Forms.Kamishibai;

namespace KamishibaiSample.MasterDetailPage.ViewModels
{
    public class DetailPage1ViewModel : ViewModelBase, IPageLifecycleAware
    {
        private static int _count = 1;
        public string Message => $"Create count:{_count}";
        public void OnInitialize(object parameter)
        {
            WriteLog(parameter);
            _count++;
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
