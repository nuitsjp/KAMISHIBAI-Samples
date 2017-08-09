using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StylishListViewSample.Models
{
    public static class FruitsRepository
    {
        public static IReadOnlyList<Fruit> Fruits { get; }

        static FruitsRepository()
        {
            var fruits = new List<Fruit>();
            fruits.Add(new Fruit { Name = "Apple", Color = Color.Red });
            fruits.Add(new Fruit { Name = "Orange", Color = Color.Orange });
            fruits.Add(new Fruit { Name = "Pineapple", Color = Color.Orange });
            fruits.Add(new Fruit { Name = "Banana", Color = Color.Goldenrod });
            fruits.Add(new Fruit { Name = "Peach", Color = Color.DeepPink });
            fruits.Add(new Fruit { Name = "Mango", Color = Color.Goldenrod });
            fruits.Add(new Fruit { Name = "Melon", Color = Color.Green });
            fruits.Add(new Fruit { Name = "Grape", Color = Color.Purple });
            fruits.Add(new Fruit { Name = "Strawberry", Color = Color.Red });
            Fruits = fruits;
        }

        public static Fruit FindById(int id)
        {
            return Fruits.SingleOrDefault(x => x.Id == id);
        }
    }
}
