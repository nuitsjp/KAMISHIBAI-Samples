using Nuits.Xamarin.Forms.Kamishibai.Mvvm;

namespace SimplestSample.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public NavigationRequestCommand RequestPopAsync { get; } = new NavigationRequestCommand();
    }
}
