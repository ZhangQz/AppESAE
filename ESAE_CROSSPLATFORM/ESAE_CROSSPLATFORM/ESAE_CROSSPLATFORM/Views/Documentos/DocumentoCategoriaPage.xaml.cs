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
    public partial class DocumentoCategoriaPage : ContentPage
    {
        DocumentoController documentos;
        CursoController cursos;

        public DocumentoCategoriaPage(DocumentoController documentos)
        {
            InitializeComponent();

            cursos = new CursoController();

            documentos = new DocumentoController();
        }
    }
}