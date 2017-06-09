using System;
using Xamarin.Forms;

namespace MDP.Views
{
    public partial class MDPPage : MasterDetailPage
    {
        public MDPPage()
        {
            InitializeComponent();

            Master = new Master();
            Detail = new NavigationPage(new Detail());

            App.mdp = this;
        }
    }
}
