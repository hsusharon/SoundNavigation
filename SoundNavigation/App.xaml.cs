using SoundNavigation.Services.Storage;

namespace SoundNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();
            SessionManager.Store.InMemory = new InMemoryStore();
        }

        public void ShutDown()
        {
            Environment.Exit(0);
        }
    }
}
