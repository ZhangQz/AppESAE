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
    public partial class PerfilPage : ContentPage
    {
        GestorUtilizador gestorUtilizador;

        public PerfilPage(GestorUtilizador _gestorUtilizador)
        {
            InitializeComponent();

            gestorUtilizador = _gestorUtilizador;


        }

        private void BtnLogOut_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSobreEsae_Clicked(object sender, EventArgs e)
        {

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void PropSet_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void PropOut_Toggled(object sender, ToggledEventArgs e)
        {
        }
    }
}