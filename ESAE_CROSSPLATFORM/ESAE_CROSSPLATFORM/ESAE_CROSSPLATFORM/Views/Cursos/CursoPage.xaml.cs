using ESAE_CROSSPLATFORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Cursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoPage : ContentPage
    {
        CursoController curso;
        PropinaController propinas;
        EventoController eventos;
        DisciplinaController disciplinas;

        public CursoPage(CursoController curso)
        {
            InitializeComponent();

            curso = new CursoController();
            propinas = new PropinaController();
            eventos = new EventoController();
            disciplinas = new DisciplinaController();
        }

        private void BtnPG_AM_Clicked(object sender, EventArgs e)
        {

        }
    }
}