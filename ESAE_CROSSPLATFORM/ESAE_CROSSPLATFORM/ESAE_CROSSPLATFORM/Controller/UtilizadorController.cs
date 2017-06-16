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
    public class UtilizadorController
    {
        private WS servidor; //ligação ao servidor
	    public List<Utilizador> ListaUtilizador; //lista de objetos do model
        public List<Utilizador> EditarUtilizador; //editar de objetos do model
        public List<Utilizador> InserirUtilizador; //editar de objetos do model
        public List<Utilizador> EliminaUtilizador; //editar de objetos do model

	public UtilizadorController()
	{
		servidor = new WS();
		ListaUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
        InserirUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
        EditarUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
        EliminaUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
	}

	}
}
