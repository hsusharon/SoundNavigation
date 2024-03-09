using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundNavigation.Services.Storage
{
    public class InMemoryStore
    {
        public string CurrentUser { get; set; }

        public InMemoryStore()
        {
            CurrentUser = string.Empty;
        }
    }
}
