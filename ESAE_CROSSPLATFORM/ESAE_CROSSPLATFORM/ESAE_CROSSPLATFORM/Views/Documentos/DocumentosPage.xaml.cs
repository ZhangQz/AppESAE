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
        GestorDocumento gestorDocumento;

        public DocumentosPage(GestorDocumento _gestorDocumento)
        {
            InitializeComponent();

            gestorDocumento = _gestorDocumento;
        }

        private void BtnBoletim_Clicked(object sender, EventArgs e)
        {

            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(gestorDocumento));
        }

        private void BtnCriterios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(gestorDocumento));

        }

        private void BtnCapas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoCategoriaPage(gestorDocumento));

        }

        private void BtnEntregas_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(gestorDocumento));

        }

        private void BtnEstagios_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoCategoriaPage(gestorDocumento));

        }

        private void BtnOutrosDocs_Clicked(object sender, EventArgs e)
        {
            App.esae_crossplatform.IsPresented = false;
            App.esae_crossplatform.Detail.Navigation.PushAsync(new DocumentoPage(gestorDocumento));

        }
    }
}