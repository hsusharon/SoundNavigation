using SoundNavigation.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundNavigation.ViewModel
{
    public class InfoViewModel : BaseViewModel
    {
        public string UserName
        {
            get { return SessionManager.Store.InMemory.CurrentUser; }
        }
        public InfoViewModel() { }

    }
}
