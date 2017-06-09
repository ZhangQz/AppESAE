using System;
namespace MDP
{
    public class Evento
    {
		//propriedades
		string nome, tipo, local;


		//construtor da classe
		public Evento()
		{
			this.nome = null;
			this.tipo = null;
            this.local = null;
		}

		//construtor alternativo
		public Evento(string _nome, string _tipo, string _local)
		{
			this.nome = _nome;
			this.tipo = _tipo;
            this.local = _local;

		}

		//getters
		public string GetNome() { return this.nome; }
		public string GetTipo() { return this.tipo; }
        public string GetLocal() { return this.local; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }
		public void SetTipo(string _tipo) { this.tipo = _tipo; }
        public void SetLocal(string _local) { this.local = _local; }

		//métodos úteis
		public int GetNumCaracteres(string _conteudo)
		{
			return _conteudo.Length;
		}

		public string ToUpper(string _conteudo)
		{
			return _conteudo.ToUpper();
		}
    }
}
