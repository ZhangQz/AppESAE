using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESAE_WIN
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMestrados_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Lista de Mestrados!");

            MestradosPage mp = new MestradosPage();
            Navigation.PushModalAsync(mp);
        }

        private void btnPosGrads_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Lista de Pós Graduações");

            PosGradsPage pgp = new PosGradsPage();
            Navigation.PushModalAsync(pgp);
        }
    }
}
