﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XApp6
{
    public partial class MainPage : ContentPage
    {
        Gestor gestor;

        public MainPage()
        {
            InitializeComponent();

            gestor = new Gestor(); //inicia o gestor de dados
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicaram no botão!");

            //PUSH (adiciona à pilha) e o POP (remove da pilha)
            SecondPage sp = new SecondPage(); //cria a página adicionar
            Navigation.PushModalAsync(sp); //adiciona a página à pilha
        }

        private void btnCriarPessoa_Clicked(object sender, EventArgs e)
        {
            InserirPessoaPage ipp = new InserirPessoaPage(gestor);
            Navigation.PushModalAsync(ipp);
        }

        private void btnListarPessoas_Clicked(object sender, EventArgs e)
        {
            //gestor.ListaPessoas();
            ListaPessoasPage lpp = new ListaPessoasPage(gestor);
            Navigation.PushModalAsync(lpp);
        }

        private void btnPedidoServidor_Clicked(object sender, EventArgs e)
        {
            //é necessário instalar o package 'Microsoft.Net.Http' e 'JSON.net' do NuGet Installer
            string uri = "http://10.0.2.2/wishlist/public/api/friends"; //só para o emulador

            //é necessário importar a biblioteca System.Net, System.IO e Newtonsoft.Json
            HttpWebRequest ws = (HttpWebRequest)WebRequest.Create(new Uri(uri));
            ws.ContentType = "application/json";

            var pedido = ws.BeginGetResponse(new AsyncCallback(WebRequestCallback), ws);

            HttpWebResponse resposta = (pedido.AsyncState as HttpWebRequest).EndGetResponse(pedido) as HttpWebResponse;
            Debug.WriteLine("Pedido executado com sucesso? " + resposta.StatusCode);

            StreamReader stream = new StreamReader(resposta.GetResponseStream(), Encoding.UTF8);
            List<Friend> lf = JsonConvert.DeserializeObject<List<Friend>>(stream.ReadLine());

            foreach (Friend friend in lf)
            {
                Debug.WriteLine("Friends {ID: " + friend.id + ", NAME: " + friend.name + ", AGE: " + friend.age + ", WISHES: " + friend.wishes + "}");

                List<Wish> listapedidos = friend.wishes;
                foreach (Wish wish in listapedidos)
                {
                    Debug.WriteLine("Wishes {ID: " + wish.id + ", NAME: " + wish.name + ", PRICE: "+ wish.price +", CATEGORY: " + wish.category + ", RANK: " + wish.rank + "}");
                }
            }

            //vou aqui https://developer.xamarin.com/recipes/android/web_services/consuming_services/call_a_rest_web_service/
        }

        private void WebRequestCallback(IAsyncResult result)
        {
            //é obrigatório estar aqui
        }

        private void btnFecharApp_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IGeral>().CloseApplication();
        }
    }
}
