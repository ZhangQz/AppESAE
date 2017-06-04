using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Win_ESAE
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

            Pos_Grads.AudiovisuaisMultimediaPage amp = new Pos_Grads.AudiovisuaisMultimediaPage();
            Navigation.PushModalAsync(amp);
        }

        private void btnAnaliseRedes_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.AnaliseRedesPage arp = new Pos_Grads.AnaliseRedesPage();
            Navigation.PushModalAsync(arp);
        }

        private void btnLiteraciaMediatica_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.LiteraciaMediaticaPage lmp = new Pos_Grads.LiteraciaMediaticaPage();
            Navigation.PushModalAsync(lmp);
        }

        private void btnDesenvolvimentoConteudos_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.DesenvolvimentoConteudosPage dcp = new Pos_Grads.DesenvolvimentoConteudosPage();
            Navigation.PushModalAsync(dcp);
        }

        private void btnSocialMedia_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.SocialMediaPage smp = new Pos_Grads.SocialMediaPage();
            Navigation.PushModalAsync(smp);
        }

        private void btnEmpreendorismoCriativo_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.EmpreendorismoCriativoPage ecp = new Pos_Grads.EmpreendorismoCriativoPage();
            Navigation.PushModalAsync(ecp);
        }

        private void btnGestaoOrganizacoes_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.GestaoOrganizacoesPage gop = new Pos_Grads.GestaoOrganizacoesPage();
            Navigation.PushModalAsync(gop);
        }

        private void btnAcunpunturaEstetica_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.AcunpunturaEsteticaPage aep = new Pos_Grads.AcunpunturaEsteticaPage();
            Navigation.PushModalAsync(aep);
        }

        private void btnGestaoGLobal_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.GestaoGLobalPage ggp = new Pos_Grads.GestaoGLobalPage();
            Navigation.PushModalAsync(ggp);
        }

        private void btnAvaliacaoIntervencao_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.AvaliacaoIntervencaoPage aip = new Pos_Grads.AvaliacaoIntervencaoPage();
            Navigation.PushModalAsync(aip);
        }

        private void btnPsicoterapiaBreve_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.PsicoterapiaBrevePage pbp = new Pos_Grads.PsicoterapiaBrevePage();
            Navigation.PushModalAsync(pbp);
        }

        private void btnPsicoterapiaPsicanalitica_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.PsicoterapiaPsicanaliticaPage ppp = new Pos_Grads.PsicoterapiaPsicanaliticaPage();
            Navigation.PushModalAsync(ppp);
        }

        private void btnPsicoterapiaCrianca_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.PsicoterapiaCriancaPage pcp = new Pos_Grads.PsicoterapiaCriancaPage();
            Navigation.PushModalAsync(pcp);
        }

        private void btnTerapiasCognitivo_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.TerapiasCognitivoPage tcp = new Pos_Grads.TerapiasCognitivoPage();
            Navigation.PushModalAsync(tcp);
        }

        private void btnNeuropsicologiaCLinica_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.NeuropsicologiaCLinicaPage ncp = new Pos_Grads.NeuropsicologiaCLinicaPage();
            Navigation.PushModalAsync(ncp);
        }

        private void btnIntervençãoDoentes_Clicked(object sender, EventArgs e)
        {
            Pos_Grads.IntervençãoDoentesPage idp = new Pos_Grads.IntervençãoDoentesPage();
            Navigation.PushModalAsync(idp);
        }
    }
}
