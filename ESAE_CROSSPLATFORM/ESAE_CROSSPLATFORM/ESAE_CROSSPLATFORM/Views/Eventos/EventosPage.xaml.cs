using ESAE_CROSSPLATFORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Eventos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventosPage : ContentPage
    {
        EventoController eventos;
        CursoController cursos;
        DisciplinaController disciplinas;

        public EventosPage(EventoController eventos)
        {
            InitializeComponent();

            eventos = new EventoController();
            cursos = new CursoController();
            disciplinas = new DisciplinaController();
        }
    }
}