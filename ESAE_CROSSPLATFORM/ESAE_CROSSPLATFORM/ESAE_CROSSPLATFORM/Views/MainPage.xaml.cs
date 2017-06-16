using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESAE_CROSSPLATFORM.Views
{
    public partial class MainPage : MasterDetailPage
    {
        GestorCurso gestorcurso;

        Controller.CursoController cursos;

        GestorDisciplina gestordisciplina;

        Controller.DisciplinasController disciplinas;

        GestorDocumento gestordocumento;

        Controller.DocumentosController documentos;

        GestorEvento gestorevento;

        Controller.EventosController eventos;

        GestorPropinas gestorpropina;

        Controller.PropinasController propinas;

        GestorUtilizador gestorutlizador;

        Controller.UtilizadorController utilizadores;

        public MainPage()
        {
            InitializeComponent();

            Master = new Master();
            Detail = new NavigationPage(new Detail());

            App.esae_crossplatform = this;
        }

    }
}
