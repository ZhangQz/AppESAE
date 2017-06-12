using System;
namespace XApp6.Models
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
