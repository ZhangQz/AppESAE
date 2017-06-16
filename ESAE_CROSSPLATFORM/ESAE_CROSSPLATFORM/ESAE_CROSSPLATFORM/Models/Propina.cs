using System;
namespace ESAE_CROSSPLATFORM.Models
{
    public class Propina
    {
		public int id { get; set; }
		public string mes { get; set; }
		public int ano { get; set; }
        public int valor { get; set; }
        public bool pago { get; set; }
        public List<Curso> cursos { get; set; }
    }
}
