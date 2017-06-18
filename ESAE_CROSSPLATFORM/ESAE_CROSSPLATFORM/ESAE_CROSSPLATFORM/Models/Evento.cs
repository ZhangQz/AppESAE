using System;
using System.Collections.Generic;

namespace ESAE_CROSSPLATFORM.Models
{
    public class Evento
    {
		public int id { get; set; }
		public string nome { get; set; }
        public string tipo { get; set; }
        public string local { get; set; }
        public List<Curso> cursos { get; set; }
        public List<Disciplinas> disciplina { get; set; }
    }
}
