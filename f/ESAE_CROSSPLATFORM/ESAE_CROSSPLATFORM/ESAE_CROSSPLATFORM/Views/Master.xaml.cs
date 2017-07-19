
using ESAE_CROSSPLATFORM.Controller;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {


        CursoController cursos;

        public Master()
        {
            InitializeComponent();

            cursos = new CursoController();
        }
        

        private void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Perfil.PerfilPage());
        }

        private void BtnDocumentos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Documentos.DocumentosPage());
        }

        private void BtnHorarios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new MinhasAulas.MinhasAulasPage());

        }

        private void BtnEventos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Eventos.EventosPage());

        }

        private void BtnOfertas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Cursos.CursosTipoPage(cursos));

        }

        private void BtnSobre_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Sobre.SobrePage());

        }

        private void BtnDocentes_Clicked(object sender, EventArgs e)
        {

        }
    }
}