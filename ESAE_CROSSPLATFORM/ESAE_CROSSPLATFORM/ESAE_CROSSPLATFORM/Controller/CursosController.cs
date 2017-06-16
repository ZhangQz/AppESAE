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
    public class CursoController
	{
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCurso; //lista de objetos do model
        public List<Curso> EditarCurso; //editar de objetos do model
        public List<Curso> InserirCurso; //editar de objetos do model
        public List<Curso> EliminaCurso; //editar de objetos do model


		    public CursoController()
		    {
		        servidor = new WS();
		        ListaCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		        EditarCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		        InserirCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		        EliminaCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
		    }
    }
}
