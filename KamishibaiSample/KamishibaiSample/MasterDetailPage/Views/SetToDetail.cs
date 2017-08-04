using System.Threading.Tasks;
using Kamishibai.Xamarin.Forms;
using Xamarin.Forms;

namespace KamishibaiSample.MasterDetailPage.Views
{
    public class SetToDetail<T> : MasterDetailAction<T> where T : Page, new()
    {
        public static readonly BindableProperty WithNavigationPageProperty =
            BindableProperty.Create(nameof(WithNavigationPage), typeof(bool), typeof(SetToDetail<T>), true);

        public bool WithNavigationPage
        {
            get => (bool)GetValue(WithNavigationPageProperty);
            set => SetValue(WithNavigationPageProperty, value);
        }
        
        public override Task Navigate<TParam>(TParam parameter = default(TParam))
        {
            CloseDrawer();
            Page newDetail;
            if (WithNavigationPage)
            {
                newDetail = new Xamarin.Forms.NavigationPage(new T());
            }
            else
            {
                newDetail = new T();
            }
            newDetail.OnInitialize(parameter);

            var currentDetail = MasterDetailPage.Detail;
            MasterDetailPage.Detail = newDetail;

            newDetail.OnLoaded();
            currentDetail.OnClosed();
            return Task.FromResult(true);
        }
    }
}
