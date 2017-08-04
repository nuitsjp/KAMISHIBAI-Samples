using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample
{
    public abstract class AddChildPage<T, TChild> : NavigationBehavior<T> where T : TChild, new() where TChild : Page
    {
        public override Task Navigate<TParam>(TParam parameter = default(TParam))
        {
            var multiPage = CurrentPage.GetParentPage<MultiPage<TChild>>();
            if (multiPage != null)
            {
                var child = new T();
                child.OnInitialize(parameter);
                multiPage.Children.Add(child);
            }
            return Task.FromResult(true);
        }
    }
}
