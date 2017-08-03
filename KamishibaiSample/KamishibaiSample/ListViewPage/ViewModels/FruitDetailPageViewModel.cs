using Nuits.Xamarin.Forms.Kamishibai;

namespace KamishibaiSample.ListViewPage.ViewModels
{
    public class FruitDetailPageViewModel : ViewModelBase, IPageInilializeAware<Fruit>
    {
        /// <summary>
        /// Selected Fruit.
        /// </summary>
        private Fruit _fruit;
        
        /// <summary>
        /// Get or Set Fruit.
        /// </summary>
        public Fruit Fruit
        {
            get => _fruit;
            set => SetProperty(ref _fruit, value);
        }

        /// <summary>
        /// Initialize on navigation.
        /// </summary>
        /// <param name="fruit"></param>
        public void OnInitialize(Fruit fruit)
        {
            Fruit = fruit;
        }
    }
}
