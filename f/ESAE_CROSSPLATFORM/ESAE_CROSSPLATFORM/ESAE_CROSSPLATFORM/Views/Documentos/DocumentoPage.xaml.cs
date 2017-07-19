using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Documentos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DocumentoPage : ContentPage
    {

        public DocumentoPage()
        {
            InitializeComponent();
        }

        private void BtnDownload_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ismt.pt/pt-files/pdf/BoletimMatriculaESAESitEsp2016.pdf"));
        }
    }
}