using System.Diagnostics;
using Xamarin.Forms;

namespace ESAE
{
    public partial class ESAEPage : MasterDetailPage
    {
        public ESAEPage()
        {
            InitializeComponent();
        }

        private void btnMestrados_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Lista de Mestrados");

            MestradosPage mp = new MestradosPage();
            Navigation.PushModalAsync(mp);
        }

        private void btnAvisos_Clicked(object sender, System.EventArgs e)
        {

        }

        private void btnPerfil_Clicked(object sender, System.EventArgs e)
        {

        }

        private void btnPosGrads_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Lista de Pos Graduações");

            PosGradsPage pgp = new PosGradsPage();
            Navigation.PushModalAsync(pgp);
        }
    }
}
