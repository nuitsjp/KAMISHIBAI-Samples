using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace LiveWithPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, IPageInitializeAware<string>
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public NavigationRequestCommand RequestSecondPage { get; } = new NavigationRequestCommand();

        public void OnInitialize(string parameter)
        {
            Title = parameter;
        }
    }
}
