using System;
namespace XApp6.Models
{
		public class Curso
		{
			public int id { get; set; }
			public string nome { get; set; }
            public string tipodecurso { get; set; }
            public string responsavel { get; set; }
            public string descricao { get; set; }
	        public int telefone { get; set; }
	        public List<Disciplinas> disciplinas { get; set; }
	        public List<Evento> eventos { get; set; }
	        public List<Documento> documentos { get; set; }
            public List<Utilizador> utilizadores { get; set; }
            public List<Propina> propinas { get; set; }
		}
    }



