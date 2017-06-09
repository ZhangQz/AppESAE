using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XApp6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XApp6.MainPage();

            //é possível iniciar uma outra page qualquer do projeto
            //MainPage = new XApp6.SecondPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("A app foi executada...");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("A app foi congelada!");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("A app foi descongelada!");
        }
    }
}
