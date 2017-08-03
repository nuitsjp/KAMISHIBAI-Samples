using Nuits.Xamarin.Forms.Kamishibai;
using SimplestSample.Views;
using Xamarin.Forms;

namespace SimplestSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ApplicationService.SetMainPage(
                new NavigationPage(new FirstPage()), "Hello, KAMISHIBAI!");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
