using System;
using Kamishibai.Xamarin.Forms;

namespace StylishListViewSample.ViewModels
{
    public class FruitDetailPageViewModel : ViewModelBase, IPageInitializeAware<Fruit>
    {
        public void OnInitialize(Fruit fruit) => Fruit = fruit;

        private Fruit _fruit;
        public Fruit Fruit
        {
            get => _fruit;
            set => SetProperty(ref _fruit, value);
        }
    }
}
