using System;
namespace XApp6.Models
{
    public class Documento
    {
		public int id { get; set; }
		public string nome { get; set; }
        public string categoria { get; set; }
		public int age { get; set; }
        public List<Curso> cursos { get; set; }
    }
}
