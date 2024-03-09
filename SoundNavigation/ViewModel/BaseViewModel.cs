using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SoundNavigation.Services;

namespace SoundNavigation.ViewModel
{
    public class BaseViewModel
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public IAlertService AlertSvc;

        public BaseViewModel()
        {
            AlertSvc = new AlertService();
        }
    }
}
