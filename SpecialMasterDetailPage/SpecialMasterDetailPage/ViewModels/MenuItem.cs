using Kamishibai.Xamarin.Forms.Mvvm;

namespace SpecialMasterDetailPage.ViewModels
{
    public class MenuItem
    {
        public string Title { get; set; }
        public INavigationRequest NavigationRequest { get; set; }
    }
}
