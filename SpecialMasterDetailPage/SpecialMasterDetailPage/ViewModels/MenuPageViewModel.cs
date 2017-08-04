using System.Collections.Generic;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace SpecialMasterDetailPage.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public IList<MenuItem> MenuItems { get; } = new List<MenuItem>();
        
        public Command<MenuItem> SelectedMenuItemCommand => new Command<MenuItem>(menuItem =>
        {
            menuItem.NavigationRequest.RaiseAsync();
        });
        
        public INavigationRequest ReqeuestHome { get; } = new NavigationRequest();
        public INavigationRequest ReqeuestFruitsList { get; } = new NavigationRequest();
        public INavigationRequest ReqeuestAbout { get; } = new NavigationRequest();

        public MenuPageViewModel()
        {
            MenuItems.Add(new MenuItem{ Title = "Home", NavigationRequest = ReqeuestHome });
            MenuItems.Add(new MenuItem { Title = "Fruits List", NavigationRequest = ReqeuestFruitsList });
            MenuItems.Add(new MenuItem { Title = "About", NavigationRequest = ReqeuestAbout });
        }
    }
}
