using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nuits.Xamarin.Forms.Kamishibai;
using Nuits.Xamarin.Forms.Kamishibai.Mvvm;

namespace KamishibaiSample.CarouselPage.ViewModels
{
    public class ChildPageNViewModel : ViewModelBase, IPageLifecycleAware
    {
        private static int _count;

        public string PageName => $"ChildPageN-{_count}";
        public NavigationRequestCommand RequestRemoveThisCommand { get; } = new NavigationRequestCommand();


        private ChildPageNViewModel()
        {
            _count++;
        }
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
