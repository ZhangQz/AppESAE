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
    public class PropinasController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Propinas> ListaPropina; //lista de objetos do model
		public List<Propinas> EditarPropina; //editar de objetos do model
        public List<Propinas> InserirPropina; //editar de objetos do model
        public List<Propinas> EliminaPropina; //editar de objetos do model

    public PropinasController()
		{
			servidor = new WS();
			ListaPropina = JsonConvert.DeserializeObject<List<Propinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EditarPropina = JsonConvert.DeserializeObject<List<Propinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			InserirPropina = JsonConvert.DeserializeObject<List<Propinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EliminaPropina = JsonConvert.DeserializeObject<List<Propinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		}
    }
}
