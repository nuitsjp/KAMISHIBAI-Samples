using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace ListViewSample.ViewModels
{
    public class FruitsListPageViewModel : ViewModelBase, IPageUnloadedAware
    {
        public void OnUnloaded() => SelectedFruit = null;
        public IList<Fruit> Fruits { get; } = new List<Fruit>();

        public INavigationRequest<Fruit> RequestDetail { get; } = 
            new NavigationRequest<Fruit>();

        private Fruit _selectedFruit;
        public Fruit SelectedFruit
        {
            get => _selectedFruit;
            set
            {
                if (SetProperty(ref _selectedFruit, value) && value != null)
                {
                    RequestDetail.RaiseAsync(value);
                }
            }
        }

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
    }
}
