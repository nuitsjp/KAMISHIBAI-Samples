using Kamishibai.Xamarin.Forms;
using StylishListViewSample.Views;
using Xamarin.Forms;

namespace StylishListViewSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ApplicationService.Initialize(this);
            ApplicationService.SetMainPage(new NavigationPage(new FruitsListPage()));
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
