using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace SpecialMasterDetailPage.Views.Navigation
{
    public class PushOuterAsync<TPage> : NavigationBehavior<TPage> where TPage : Page, new ()
    {
        public override Task Navigate<T>(T parameter = default(T))
        {
            var mainPage = AssociatedObject.GetParentPage<MainPage>(true);
            return mainPage.OuterNavigator.PushAsync(new TPage(), parameter);
        }
    }
}
