using SoundNavigation.ViewModel;
namespace SoundNavigation.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
	public SettingsPage(NavigatorViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}