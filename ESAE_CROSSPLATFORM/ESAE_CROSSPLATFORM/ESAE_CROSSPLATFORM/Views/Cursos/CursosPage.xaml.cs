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
    public partial class CursosPage : ContentPage
    {
        CursoController cursos;

        public CursosPage(CursoController cursos)
        {
            InitializeComponent();

            cursos = new CursoController();
        }

        private void BtnAudioMult_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursoPage(cursos));
        }

        private void ListaCursos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}