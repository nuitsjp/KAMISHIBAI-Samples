using System.Windows.Input;
using Nuits.Xamarin.Forms.Kamishibai;
using Nuits.Xamarin.Forms.Kamishibai.Mvvm;
using Xamarin.Forms;

namespace SimplestSample.ViewModels
{
    public class FirstPageViewModel : ViewModelBase, IPageInilializeAware<string>
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        
        public NavigationRequest RequestSecondPage { get; } = new NavigationRequest();
        
        public ICommand NavigateCommand => new Command(() => RequestSecondPage.RaiseAsync());

        public void OnInitialize(string parameter)
        {
            Message = parameter;
        }
    }
}
