using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XApp6.API;

namespace XApp6.Controllers
{
    public class DocumentosController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Documentos> ListaDocumentos; //lista de objetos do model
		public List<Documentos> EditarDocumentos; //editar de objetos do model
        public List<Documentos> InserirDocumentos; //editar de objetos do model
        public List<Documentos> EliminaDocumentos; //editar de objetos do model

    public UtilizadorController()
		{
			servidor = new WS();
			ListaDocumentos = JsonConvert.DeserializeObject<List<Documentos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EditarDocumentos = JsonConvert.DeserializeObject<List<Documentos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			InserirDocumentos = JsonConvert.DeserializeObject<List<Documentos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EliminaDocumentos = JsonConvert.DeserializeObject<List<Documentos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		}
    }
}
