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
        DisciplinasController disciplinas;
        DocumentosController documentos;
        EventosController eventos;
        PropinasController propinas;
        UtilizadorController utilizadores;

        public Master()
        {
            InitializeComponent();

            cursos = new CursoController();
            disciplinas = new DisciplinasController();
            documentos = new DocumentosController();
            eventos = new EventosController();
            propinas = new PropinasController();
            utilizadores = new UtilizadorController();
        }


        private void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Perfil.PerfilPage(gestorUtilizador));
        }

        private void BtnDocumentos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Documentos.DocumentosPage(gestorDocumento));
        }

        private void BtnHorarios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new MinhasAulas.MinhasAulasPage());

        }

        private void BtnEventos_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Eventos.EventosPage(gestorEvento));

        }

        private void BtnOfertas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new Cursos.CursosTipoPage(gestorCurso));

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