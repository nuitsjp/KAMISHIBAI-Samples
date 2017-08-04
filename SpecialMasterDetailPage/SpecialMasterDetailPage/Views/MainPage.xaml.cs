using Kamishibai.Xamarin.Forms;
using Xamarin.Forms;

namespace SpecialMasterDetailPage.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public INavigator OuterNavigator { get; }

        public INavigator InnerNavigator { get; }
        
        public MainPage()
        {
            InitializeComponent();
            OuterNavigator = new Navigator(Outer);
            InnerNavigator = new Navigator(Inner);
        }
    }
}