using ESAE_CROSSPLATFORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        UtilizadorController utilizadores;

        public Detail()
        {
            InitializeComponent();

            utilizadores = new UtilizadorController();
        }

        private void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            //a referência deve ser do controlador e não da classe gestor que não deveria existir!
            //App.esae_crossplatform.Detail.Navigation.PushAsync(new Perfil.LogInPage(gestorUtilizador));
        }
    }
}