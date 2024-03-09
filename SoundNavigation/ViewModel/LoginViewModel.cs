using SoundNavigation.Localization;
using SoundNavigation.Pages;
using SoundNavigation.Services.Storage;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SoundNavigation.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginBtn { get; }

        public string UserName
        {
            get { return SessionManager.Store.InMemory.CurrentUser; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    SessionManager.Store.InMemory.CurrentUser = value;
                    OnPropertyChanged();
                }
            }
        } 

        
        public LoginViewModel() 
        {
            LoginBtn = new Command(LoginClick);
        }

        public async void LoginClick()
        {
            if (string.IsNullOrEmpty(SessionManager.Store.InMemory.CurrentUser))
            {
                await AlertSvc.ShowAlertAsync(Lang.Error_Title, Lang.UserNameEmpty);
                return;
            }
            await Shell.Current.GoToAsync($"//{nameof(InfoPage)}");
        }


    }
}
