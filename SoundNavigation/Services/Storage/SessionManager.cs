using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundNavigation.Services.Storage
{
    public class SessionManager
    {
        private static SessionManager _store;
        public InMemoryStore InMemory { get; set; }

        private SessionManager() { }

        public static SessionManager Store
        {
            get
            {
                if (_store == null)
                    _store = new SessionManager();
                return _store;
            }
        }

        public SessionManager(InMemoryStore inMemory)
        {
            InMemory = inMemory;
        }
    }
}
