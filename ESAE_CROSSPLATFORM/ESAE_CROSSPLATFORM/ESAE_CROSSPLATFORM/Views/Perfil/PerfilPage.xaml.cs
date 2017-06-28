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
    public partial class PerfilPage : ContentPage
    {
        CursoController cursos;
        EventoController eventos;
        PropinaController propinas;
        UtilizadorController utilizadores;


        public PerfilPage(UtilizadorController utilizadores)
        {
            InitializeComponent();

            utilizadores = new UtilizadorController();
            cursos = new CursoController();
            propinas = new PropinaController();
            eventos = new EventoController();

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