using System;
using System.ComponentModel;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;

namespace SimplestSample.ViewModels
{
    public class SecondPageViewModel : ViewModelBase, IPageInitializeAware<DateTime>, INotifyPropertyChanged
    {
        private DateTime _selectedDate;

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }
        
        public NavigationRequestCommand RequestPopAsync { get; } = new NavigationRequestCommand();
        public void OnInitialize(DateTime selectedDate)
        {
            SelectedDate = selectedDate;
        }
    }
}
