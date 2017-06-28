using ESAE_CROSSPLATFORM.Controller;
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
    public partial class DocumentosPage : ContentPage
    {
        DocumentoController documentos;

        public DocumentosPage(DocumentoController documentos)
        {
            InitializeComponent();

            documentos = new DocumentoController();
        }

        private void BtnBoletim_Clicked(object sender, EventArgs e)
        {

            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(documentos));
        }

        private void BtnCriterios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(documentos));

        }

        private void BtnCapas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoCategoriaPage(documentos));

        }

        private void BtnEntregas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(documentos));

        }

        private void BtnEstagios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoCategoriaPage(documentos));

        }

        private void BtnOutrosDocs_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(documentos));

        }
    }
}