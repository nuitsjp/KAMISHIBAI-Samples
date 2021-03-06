﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;

namespace KamishibaiSample
{
    public class MainPageViewModel : ViewModelBase, IPageLifecycleAware, IApplicationLifecycleAware
    {
        public NavigationRequestCommand<string> RequestNavigationPageCommand { get; } = new NavigationRequestCommand<string>();
        
        public NavigationRequestCommand RequestMasterDetailPageCommand { get; } = new NavigationRequestCommand();

        public NavigationRequestCommand RequestTabbedPageCommand { get; } = new NavigationRequestCommand();
        public NavigationRequestCommand RequestCarouselPageCommand { get; } = new NavigationRequestCommand();

        public void OnInitialize()
        {
            WriteLog();
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
