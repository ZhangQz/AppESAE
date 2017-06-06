using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosPage : ContentPage
    {
        public CursosPage()
        {
            InitializeComponent();
        }

        private void BtnMestrados_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Cursos.MestradosPage());
        }

        private void BtnPosGrads_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Cursos.PosGradsPage());

        }

        private void BtnOutrosCursos_Clicked(object sender, EventArgs e)
        {

            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Cursos.OutrosCursosPage());
        }
    }
}