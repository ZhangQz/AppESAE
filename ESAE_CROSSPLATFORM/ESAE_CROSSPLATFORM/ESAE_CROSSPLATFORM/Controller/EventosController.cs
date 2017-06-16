using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ESAE_CROSSPLATFORM.API;

namespace ESAE_CROSSPLATFORM.Controller
{
    public class EventosController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Eventos> ListaEventos; //lista de objetos do model
		public List<Eventos> EditarEventos; //editar de objetos do model
        public List<Eventos> InserirEventos; //editar de objetos do model
        public List<Eventos> EliminaEventos; //editar de objetos do model

    public EventosController()
		{
			servidor = new WS();
			ListaEventos = JsonConvert.DeserializeObject<List<Eventos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EditarEventos = JsonConvert.DeserializeObject<List<Eventos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			InserirEventos = JsonConvert.DeserializeObject<List<Eventos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EliminaEventos = JsonConvert.DeserializeObject<List<Eventos>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		}
    }
}
