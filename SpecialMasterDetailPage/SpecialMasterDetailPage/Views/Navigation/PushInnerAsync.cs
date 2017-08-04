using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;
using Kamishibai.Xamarin.Forms;

namespace SpecialMasterDetailPage.Views.Navigation
{
    public class PushInnerAsync<TPage> : NavigationBehavior<TPage> where TPage : Page, new ()
    {
        public override async Task Navigate<T>(T parameter = default(T))
        {
            var mainPage = AssociatedObject.GetParentPage<MainPage>(true);

            mainPage.IsPresented = false;
            if (typeof(TPage) == typeof(HomePage))
            {
                await mainPage.InnerNavigator.PopToRootAsync();
            }
            else
            {
                var page = new TPage();
                NavigationPage.SetHasNavigationBar(page, false);
                await mainPage.InnerNavigator.PushAsync(page);
                if (2 < mainPage.InnerNavigator.NavigationStack.Count)
                {
                    mainPage.InnerNavigator.RemovePage(mainPage.InnerNavigator.NavigationStack[1]);
                }
            }

        }
    }
}
