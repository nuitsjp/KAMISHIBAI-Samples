using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;

namespace ListViewSample.ViewModels
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
