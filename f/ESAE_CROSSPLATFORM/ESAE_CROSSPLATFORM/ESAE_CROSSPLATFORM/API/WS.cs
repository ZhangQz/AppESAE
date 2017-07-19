using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM.API
{
    public class WS
    {
        public StreamReader PedidoServidor(string uri)
        {
            HttpWebRequest ws = (HttpWebRequest)WebRequest.Create(new Uri(uri));
            ws.ContentType = "application/json";

            var pedido = ws.BeginGetResponse(new AsyncCallback(WebRequestCallback), ws);
            HttpWebResponse resposta = (pedido.AsyncState as HttpWebRequest).EndGetResponse(pedido) as HttpWebResponse;
            StreamReader stream = new StreamReader(resposta.GetResponseStream(), Encoding.UTF8);

            return stream;
        }

        private void WebRequestCallback(IAsyncResult result)
        {
        }
    }
}
