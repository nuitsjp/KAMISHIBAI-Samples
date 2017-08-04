using System;
using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample.MasterDetailPage.Views
{
    public class PushToDetailAsync<T> : MasterDetailAction<T> where T : Page, new()
    {
        public static readonly BindableProperty AnimatedProperty =
            BindableProperty.Create(nameof(Animated), typeof(bool), typeof(AnimatableNavigation<T>), true);

        public bool Animated
        {
            get => (bool)GetValue(AnimatedProperty);
            set => SetValue(AnimatedProperty, value);
        }

        public override Task Navigate<TParam>(TParam parameter = default(TParam))
        {
            CloseDrawer();
            var detailPage = (MasterDetailPage?.Detail as Xamarin.Forms.NavigationPage)?.CurrentPage;
            if (detailPage != null)
            {
                return new Navigator(detailPage).PushAsync(new T(), parameter, Animated);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
