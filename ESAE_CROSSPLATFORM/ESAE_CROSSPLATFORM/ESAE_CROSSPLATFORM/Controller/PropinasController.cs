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
		public List<Propina> ListaPropina; //lista de objetos do model
		public List<Propina> EditarPropina; //editar de objetos do model
        public List<Propina> InserirPropina; //editar de objetos do model
        public List<Propina> EliminaPropina; //editar de objetos do model

    public PropinasController()
		{
			servidor = new WS();
			ListaPropina = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EditarPropina = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			InserirPropina = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EliminaPropina = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		}
    }
}
