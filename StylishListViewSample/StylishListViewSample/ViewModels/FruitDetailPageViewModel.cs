using System;
using Kamishibai.Xamarin.Forms;
using StylishListViewSample.Models;

namespace StylishListViewSample.ViewModels
{

    /// <summary>
    /// When receiving Fruit object directly.
    /// </summary>
    // public class FruitDetailPageViewModel : ViewModelBase, IPageInitializeAware<Fruit>

    /// <summary>
    /// When receiving Fruit's id.
    /// </summary>
    public class FruitDetailPageViewModel : ViewModelBase, IPageInitializeAware<int>
    {
        /// <summary>
        /// When receiving Fruit object directly.
        /// </summary>
        // public void OnInitialize(Fruit fruit) => Fruit = fruit;

        /// <summary>
        /// When receiving Fruit's id.
        /// </summary>
        public void OnInitialize(int id) => Fruit = FruitsRepository.FindById(id);

        private Fruit _fruit;
        public Fruit Fruit
        {
            get => _fruit;
            set => SetProperty(ref _fruit, value);
        }
    }
}
