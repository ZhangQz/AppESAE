using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ESAE_CROSSPLATFORM
{
    public partial class App : Application
    {
        public static MasterDetailPage esae_crossplatform { get; set; }
        
        public App()
        {
            InitializeComponent();

            MainPage = new ESAE_CROSSPLATFORM.Views.MainPage();
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
