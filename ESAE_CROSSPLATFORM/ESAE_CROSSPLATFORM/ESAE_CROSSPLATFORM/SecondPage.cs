using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ESAE_CROSSPLATFORM
{
    public class SecondPage : ContentPage
    {
        Button btnVoltar; //declarei o botão (GLOBAL)

        public SecondPage()
        {
            //criamos o botão e estilizamos
            btnVoltar = new Button();
            btnVoltar.Text = "Voltar";
            btnVoltar.BackgroundColor = Color.Azure;
            btnVoltar.Clicked += BtnVoltar_Clicked;

            //layout da página
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Página C# Exemplo" },
                    btnVoltar //adicionamos o botão
                }
            };
        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(); //removemos a página atual
        }
    }
}