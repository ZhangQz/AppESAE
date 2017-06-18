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
        GestorCurso gestorCurso;

        public CursosPage(GestorCurso _gestorCurso)
        {
            InitializeComponent();

            gestorCurso = _gestorCurso;

            ListaCursos.ItemsSource = gestorCurso.GetAllItens();
        }

        private void BtnAudioMult_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursoPage());
        }

        private void ListaCursos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}