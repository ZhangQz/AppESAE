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

namespace ESAE_CROSSPLATFORM.Controllers
{
    public class DisciplinasController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Disciplinas> ListaDisciplinas; //lista de objetos do model
		public List<Disciplinas> EditarDisciplinas; //editar de objetos do model
        public List<Disciplinas> InserirDisciplinas; //editar de objetos do model
        public List<Disciplinas> EliminaDisciplinas; //editar de objetos do model

    public DisciplinasController()
		{
			servidor = new WS();
			ListaDisciplinas = JsonConvert.DeserializeObject<List<Disciplinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EditarDisciplinas = JsonConvert.DeserializeObject<List<Disciplinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			InserirDisciplinas = JsonConvert.DeserializeObject<List<Disciplinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
			EliminaDisciplinas = JsonConvert.DeserializeObject<List<Disciplinas>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		}
    }
}
