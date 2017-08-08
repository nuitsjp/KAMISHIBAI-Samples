using System;
using System.Collections.Generic;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace StylishListViewSample.ViewModels
{
    public class FruitsListPageViewModel : ViewModelBase
    {
        public IList<Fruit> Fruits { get; } = new List<Fruit>();

        public NavigationRequestCommand<Fruit> RequestDetail { get; } = new NavigationRequestCommand<Fruit>();

        public FruitsListPageViewModel()
        {
            Fruits.Add(new Fruit { Name = "Apple", Color = Color.Red });
            Fruits.Add(new Fruit { Name = "Orange", Color = Color.Orange });
            Fruits.Add(new Fruit { Name = "Pineapple", Color = Color.Orange });
            Fruits.Add(new Fruit { Name = "Banana", Color = Color.Goldenrod });
            Fruits.Add(new Fruit { Name = "Peach", Color = Color.DeepPink });
            Fruits.Add(new Fruit { Name = "Mango", Color = Color.Goldenrod });
            Fruits.Add(new Fruit { Name = "Melon", Color = Color.Green });
            Fruits.Add(new Fruit { Name = "Grape", Color = Color.Purple });
            Fruits.Add(new Fruit { Name = "Strawberry", Color = Color.Red });
        }
    }}
