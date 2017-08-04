using System;
using System.Windows.Input;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace SimplestSample.ViewModels
{
    public class FirstPageViewModel : ViewModelBase, IPageInitializeAware<string>
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        
        private DateTime _selectedDate = DateTime.Today;

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }
        
        public INavigationRequest<DateTime> RequestSecondPage { get; } = new NavigationRequest<DateTime>();
        
        public ICommand NavigateCommand => new Command(() => RequestSecondPage.RaiseAsync(SelectedDate));

        public void OnInitialize(string parameter)
        {
            Message = parameter;
        }
    }
}
