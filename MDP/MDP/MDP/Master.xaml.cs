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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void btnPage1_Clicked(object sender, EventArgs e)
        {
        }

        private void btnPage2_Clicked(object sender, EventArgs e)
        {
        }

        private void BtnCursos_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new CursosPage());

        }

        private void BtnCalendario_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new CalendarioPage());
        }
        
        private void BtnDocumentos_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new DocumentosPage());

        }

        private void BtnSobreNos_Clicked(object sender, EventArgs e)
        {

        }
    }
}