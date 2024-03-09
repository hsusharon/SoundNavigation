using SoundNavigation.Services;
using SoundNavigation.ViewModel;
using SoundNavigation.Localization;

namespace SoundNavigation.Pages;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;
    private readonly AlertService _alertService;
	public LoadingPage(AuthService authService, LoadingViewModel vm)
	{
		InitializeComponent();
		_authService = authService;
        //_alertService = alertService;
		BindingContext = vm;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		if(await _authService.IsLoadedCorrectlyAsync()) 
		{
            if (await _authService.IsAuthenticatedAsync())
            {
                await Shell.Current.GoToAsync($"//{nameof(InfoPage)}");
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
        }
        else
        {
            //await _alertService.ShowAlertAsync(Lang.Error_Title, Lang.UnableToLoad);
            Environment.Exit(0);
        }
		
    }
}