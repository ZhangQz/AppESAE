﻿using ESAE_CROSSPLATFORM.Controller;
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
        DocumentoController documentos;

        public DocumentoPage(DocumentoController documentos)
        {
            InitializeComponent();

            documentos = new DocumentoController();


            documentoslistview.ItemsSource = documentos.GetAllItens();
        }

        private void BtnDownload_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.ismt.pt/pt-files/pdf/BoletimMatriculaESAESitEsp2016.pdf"));
        }
        

        private void documentoslistview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}