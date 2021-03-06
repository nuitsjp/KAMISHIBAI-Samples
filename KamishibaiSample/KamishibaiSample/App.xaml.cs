﻿using Kamishibai.Xamarin.Forms;
using Xamarin.Forms;

namespace KamishibaiSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ApplicationService.Initialize(this);
            ApplicationService.SetMainPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
	        LifecycleNoticeService.OnSleep(this);
        }

        protected override void OnResume()
        {
	        LifecycleNoticeService.OnResume(this);
        }
    }
}
