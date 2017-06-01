using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace ESAE
{
    public partial class PosGradsPage : ContentPage
    {
        public PosGradsPage()
        {
            InitializeComponent();
        }

        private void btnAudiovisuaisMultimédia_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Pós graduação de Audiovisuais e Multimédia");

            AudiovisuaisMultimediaPage amp = new AudiovisuaisMultimediaPage();
            Navigation.PushModalAsync(amp);
        }
    }
}
