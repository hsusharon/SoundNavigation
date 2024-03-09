using SoundNavigation.ViewModel;
namespace SoundNavigation.Pages;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
	
	public InfoPage(InfoViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}