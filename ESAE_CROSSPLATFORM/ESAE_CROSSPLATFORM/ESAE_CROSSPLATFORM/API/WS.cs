using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM.API
{
    public class WS
    {
        public StreamReader PedidoServidor(string uri)
        {
            //é necessário instalar o package 'Microsoft.Net.Http' e 'JSON.net' do NuGet Installer
            //é necessário importar a biblioteca System.Net, System.IO e Newtonsoft.Json
            HttpWebRequest ws = (HttpWebRequest)WebRequest.Create(new Uri(uri));
            ws.ContentType = "application/json";

            var pedido = ws.BeginGetResponse(new AsyncCallback(WebRequestCallback), ws);
            HttpWebResponse resposta = (pedido.AsyncState as HttpWebRequest).EndGetResponse(pedido) as HttpWebResponse;
            StreamReader stream = new StreamReader(resposta.GetResponseStream(), Encoding.UTF8);

            return stream;
        }

        private void WebRequestCallback(IAsyncResult result)
        {
            //é obrigatório estar aqui
        }
    }
}
