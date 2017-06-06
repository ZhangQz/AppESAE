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
    public partial class DocumentosPage : ContentPage
    {
        public DocumentosPage()
        {
            InitializeComponent();
        }

        private void BtnBoletins_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.BoletinsPage());

        }

        private void BtnCriterios_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.CriterioPage());

        }

        private void BtnCapas_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.CapasPage());

        }

        private void BtnEntregas_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.EntregasPage());

        }

        private void BtnEstagios_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.EstagiosPage());

        }

        private void BtnSumario_Clicked(object sender, EventArgs e)
        {
            App.mdp.IsPresented = false;
            App.mdp.Detail.Navigation.PushAsync(new Documentos.SumariosPage());

        }
    }
}