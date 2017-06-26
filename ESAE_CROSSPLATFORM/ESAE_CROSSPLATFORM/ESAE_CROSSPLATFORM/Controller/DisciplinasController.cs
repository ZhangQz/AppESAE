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
    public class DisciplinasController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Disciplina> listaDisciplinas; //lista de objetos do model
		public List<Disciplina> EditarDisciplinas; //editar de objetos do model
        public List<Disciplina> InserirDisciplinas; //editar de objetos do model
        public List<Disciplina> EliminaDisciplinas; //editar de objetos do model

    public DisciplinasController()
		{
			servidor = new WS();
			listaDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/disciplinas").ReadLine());
			EditarDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/disciplinas").ReadLine());
			InserirDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/disciplinas").ReadLine());
			EliminaDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/disciplinas").ReadLine());
		}
    }
}
