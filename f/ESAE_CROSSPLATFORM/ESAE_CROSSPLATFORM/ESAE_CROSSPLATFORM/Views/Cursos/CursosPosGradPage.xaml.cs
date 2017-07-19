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
    public partial class CursosPosGradPage : ContentPage
    {

        public CursosPosGradPage()
        {
            InitializeComponent();
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