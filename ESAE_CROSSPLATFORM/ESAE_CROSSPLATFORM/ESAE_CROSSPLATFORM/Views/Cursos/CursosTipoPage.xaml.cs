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
    public partial class CursosTipoPage : ContentPage
    {
        CursoController cursos;

        public CursosTipoPage(CursoController cursos)
        {
            InitializeComponent();

            cursos = new CursoController();
        }

        private void BtnMestrados_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursosPage(cursos));
        }

        private void BtnPosGrad_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLivre_Clicked(object sender, EventArgs e)
        {

        }

        private void ListaTipoCurso_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}