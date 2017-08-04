using System;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Xamarin.Forms;

namespace KamishibaiSample.MasterDetailPage.Views
{
    public abstract class MasterDetailAction<T> : NavigationBehavior<T> where T : Page, new()
    {
        public static readonly BindableProperty IsClosingProperty =
            BindableProperty.Create(nameof(IsClosing), typeof(bool), typeof(MasterDetailAction<T>), true);

        public bool IsClosing
        {
            get => (bool)GetValue(IsClosingProperty);
            set => SetValue(IsClosingProperty, value);
        }

        protected Xamarin.Forms.MasterDetailPage MasterDetailPage => CurrentPage.GetParentPage<Xamarin.Forms.MasterDetailPage>(true);

        protected void CloseDrawer()
        {
            if (IsClosing)
            {
                MasterDetailPage.IsPresented = false;
            }
        }
    }
}
