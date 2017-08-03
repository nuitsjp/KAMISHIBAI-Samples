using System;
using System.ComponentModel;
using Nuits.Xamarin.Forms.Kamishibai;
using Nuits.Xamarin.Forms.Kamishibai.Mvvm;

namespace SimplestSample.ViewModels
{
    public class SecondPageViewModel : ViewModelBase, IPageInilializeAware<DateTime>, INotifyPropertyChanged
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
