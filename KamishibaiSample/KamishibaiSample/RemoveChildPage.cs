using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample
{
    public abstract class RemoveChildPage<T> : NavigationBehavior<T> where T : Page
    {
        public override Task Navigate<TParam>(TParam parameter = default(TParam))
        {
            var parent = CurrentPage.GetParentPage<MultiPage<T>>();
            if (parent != null)
            {
                var target = parent.CurrentPage;
                parent.Children.Remove(parent.CurrentPage);
                target.OnClosed();
            }
            return Task.FromResult(true);
        }

    }
}
