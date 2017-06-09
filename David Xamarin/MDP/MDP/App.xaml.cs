using Xamarin.Forms;

namespace MDP
{
    public partial class App : Application
    {
        public static MasterDetailPage mdp { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Views.MDPPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
