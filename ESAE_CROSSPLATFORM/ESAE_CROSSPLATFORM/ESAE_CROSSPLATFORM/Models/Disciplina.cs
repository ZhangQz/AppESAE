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

namespace ESAE_CROSSPLATFORM.Models
{
    public class Disciplinas
    {
			public int id { get; set; }
			public string nome { get; set; }
	        public List<Curso> cursos { get; set; }
	        public List<Evento> eventos { get; set; }

    }
}
