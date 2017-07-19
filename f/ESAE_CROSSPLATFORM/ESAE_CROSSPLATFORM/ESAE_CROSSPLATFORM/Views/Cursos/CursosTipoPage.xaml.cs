using ESAE_CROSSPLATFORM.Controller;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Cursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosTipoPage : ContentPage
    {

        CursoController cursos;

        public CursosTipoPage(CursoController _cursos)
        {
            InitializeComponent();

            cursos = _cursos;

            CursoList.ItemsSource = cursos.ListaCursos;

        }

        private void BtnMestrados_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursoMestradoPage());
        }

        private void BtnPosGrad_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursosPosGradPage());
        }

        private void BtnLivre_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new CursoLivrePage());
        }

        private void CursoList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}