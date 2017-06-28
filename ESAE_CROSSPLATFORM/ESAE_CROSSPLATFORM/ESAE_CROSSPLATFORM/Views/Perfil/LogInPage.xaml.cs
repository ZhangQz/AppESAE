using ESAE_CROSSPLATFORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Perfil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        UtilizadorController utilizadores;

        public LogInPage(UtilizadorController utilizadores)
        {
            InitializeComponent();

            utilizadores = new UtilizadorController();
        }

        private void BtnLog_Clicked(object sender, EventArgs e)
        {

        }
    }
}