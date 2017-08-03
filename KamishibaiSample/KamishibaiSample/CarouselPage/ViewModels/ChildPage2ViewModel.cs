using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nuits.Xamarin.Forms.Kamishibai;

namespace KamishibaiSample.CarouselPage.ViewModels
{
    public class ChildPage2ViewModel : ViewModelBase, IPageLifecycleAware
    {
        public void OnInitialize(object parameter)
        {
            WriteLog(parameter);
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
