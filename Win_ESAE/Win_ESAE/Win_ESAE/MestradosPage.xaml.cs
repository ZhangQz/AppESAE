using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Win_ESAE
{
    public partial class MestradosPage : ContentPage
    {
        public MestradosPage()
        {
            InitializeComponent();
        }

        private void btnGestaoRecursos_Clicked(object sender, EventArgs e)
        {
            Mestrados.GestaoRecursosPage grp = new Mestrados.GestaoRecursosPage();
            Navigation.PushModalAsync(grp);
        }

        private void btnPsicologiaClinica_Clicked(object sender, EventArgs e)
        {
            Mestrados.PsicologiaClinicaPage pcp = new Mestrados.PsicologiaClinicaPage();
            Navigation.PushModalAsync(pcp);
        }

        private void btnServicoSocial_Clicked(object sender, EventArgs e)
        {
            Mestrados.ServicoSocialPage ssp = new Mestrados.ServicoSocialPage();
            Navigation.PushModalAsync(ssp);
        }
    }
}
