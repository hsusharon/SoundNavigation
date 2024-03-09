using SoundNavigation.Localization;
using SoundNavigation.Pages;
using SoundNavigation.Services;

namespace SoundNavigation
{
    public partial class AppShell : Shell
    {
        private AlertService _alertService;
        public AppShell()
        {
            InitializeComponent();

            
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(NavigatorPage), typeof(NavigatorPage));
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            //Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            _alertService = new AlertService();

        }

        private async void LogOutClicked(object sender, EventArgs e)
        {
            if(await _alertService.ShowConfirmationAsync(Lang.LogOut, Lang.LogOutMessage, "Yes", "No"))
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            return;
            
        }

    }
}
