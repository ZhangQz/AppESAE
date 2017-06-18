using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_CROSSPLATFORM.Views.Eventos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventosPage : ContentPage
    {
        GestorEvento gestorEvento;

        public EventosPage(GestorEvento _gestorEvento)
        {
            InitializeComponent();

            gestorEvento = _gestorEvento;
        }
    }
}