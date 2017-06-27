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
		public List<Evento> ListaEventos; //lista de objetos do model
		public List<Evento> EditarEventos; //editar de objetos do model
        public List<Evento> InserirEventos; //editar de objetos do model
        public List<Evento> EliminaEventos; //editar de objetos do model

    public EventosController()
		{
			servidor = new WS();
			ListaEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/APP/public/api/eventos").ReadLine());
			EditarEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/APP/public/api/eventos").ReadLine());
			InserirEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/APP/public/api/eventos").ReadLine());
			EliminaEventos = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/APP/public/api/eventos").ReadLine());
		}
    }
}
