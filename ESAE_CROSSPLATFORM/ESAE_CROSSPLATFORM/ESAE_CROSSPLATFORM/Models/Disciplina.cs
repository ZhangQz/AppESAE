using System;
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
