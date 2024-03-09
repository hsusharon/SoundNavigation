using Microsoft.Extensions.Logging;
using SoundNavigation.ViewModel;
using SoundNavigation.Pages;
using SoundNavigation.Services;

namespace SoundNavigation
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<AlertService>();
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<LoadingViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<InfoPage>();
            builder.Services.AddTransient<InfoViewModel>();
            builder.Services.AddTransient<NavigatorPage>();
            builder.Services.AddTransient<NavigatorViewModel>();
            builder.Services.AddTransient<ProfilePage>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<SettingsPage>();
            builder.Services.AddTransient<SettingsViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
