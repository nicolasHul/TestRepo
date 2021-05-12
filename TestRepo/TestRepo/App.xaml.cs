using Prism;
using Prism.Ioc;
using TestRepo.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace TestRepo
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MyTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MyTabbedPage, MyTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<TabOnePage, TabOnePageViewModel>();
            containerRegistry.RegisterForNavigation<TabTwoPage, TabTwoPageViewModel>();
            containerRegistry.RegisterForNavigation<TabThreePage, TabThreePageViewModel>();
        }
    }
}
