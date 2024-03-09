using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundNavigation.Services
{
    public class AuthService
    {

        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(500);
            return false;
        }

        public async Task<bool> IsLoadedCorrectlyAsync()
        {
            await Task.Delay(2000);
            return true;
        }
    }
}
