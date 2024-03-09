using SoundNavigation.ViewModel;
namespace SoundNavigation.Pages;

public partial class NavigatorPage : ContentPage
{
	public NavigatorPage(NavigatorViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}

    public NavigatorPage()
    {
        InitializeComponent();
    }
}