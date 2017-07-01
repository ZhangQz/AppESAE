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
    public partial class Master : ContentPage
    {
        CursoController cursos;
        DisciplinaController disciplinas;
        DocumentoController documentos;
        EventoController eventos;
        PropinaController propinas;
        UtilizadorController utilizadores;

        public Master()
        {
            InitializeComponent();

            cursos = new CursoController();
            disciplinas = new DisciplinaController();
            documentos = new DocumentoController();
            eventos = new EventoController();
            propinas = new PropinaController();
            utilizadores = new UtilizadorController();
        }


        private void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Perfil.PerfilPage(utilizadores));
        }

        private void BtnDocumentos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Documentos.DocumentosPage(documentos));
        }

        private void BtnHorarios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new MinhasAulas.MinhasAulasPage());

        }

        private void BtnEventos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Eventos.EventosPage(eventos));

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