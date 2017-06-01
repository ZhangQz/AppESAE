using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAE_WIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PosGradsPage : ContentPage
    {
        public PosGradsPage()
        {
            InitializeComponent();
        }

        private void btnAudiovisuaisMultimédia_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Pós-Graduação de Audiovisuais e Multimédia");

            AudiovisuaisMultimediaPage amp = new AudiovisuaisMultimediaPage();
            Navigation.PushModalAsync(amp);
        }
    }
}
