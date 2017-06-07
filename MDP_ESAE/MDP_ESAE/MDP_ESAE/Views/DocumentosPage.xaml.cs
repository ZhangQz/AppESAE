using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP_ESAE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DocumentosPage : ContentPage
    {
        public DocumentosPage()
        {
            InitializeComponent();
        }

        async void BtnBoletins_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }

        async void BtnCriterios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }

        async void BtnCapas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }

        async void BtnEntregas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }

        async void BtnEstagios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }

        async void BtnSumarios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Documentos.DocumentoPage());
        }
    }
}