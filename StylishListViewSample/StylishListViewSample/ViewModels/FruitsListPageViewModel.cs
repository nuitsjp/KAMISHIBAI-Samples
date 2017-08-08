using System;
using System.Collections.Generic;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using StylishListViewSample.Models;
using Xamarin.Forms;

namespace StylishListViewSample.ViewModels
{
    public class FruitsListPageViewModel : ViewModelBase
    {
        public IReadOnlyList<Fruit> Fruits { get; } = FruitsRepository.Fruits;

        /// <summary>
        /// When passing a Fruit object directly.
        /// </summary>
        // public NavigationRequestCommand<Fruit> RequestDetail { get; } = new NavigationRequestCommand<Fruit>();

        /// <summary>
        /// When passing a Fruit's id.
        /// </summary>
        public NavigationRequestCommand<int> RequestDetail { get; } = new NavigationRequestCommand<int>();
    }
}
