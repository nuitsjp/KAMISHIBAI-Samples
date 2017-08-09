using Autofac;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;
using Prism.Autofac;
using Prism.Autofac.Forms;
using LiveWithPrism.Views;
using Xamarin.Forms;

namespace LiveWithPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            ServiceLocator.SetLocator(type => Container.Resolve(type));
            ApplicationService.Initialize(this);
            ApplicationService.SetMainPage(new NavigationPage(new MainPage()), "Hello from Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainPage>();
            builder.RegisterType<SecondPage>();

            builder.Update(Container);
        }
    }
}
