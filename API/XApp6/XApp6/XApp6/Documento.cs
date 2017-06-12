using System;
namespace MDP
{
    public class Documento
    {
		//propriedades
		string nome, categoria;


		//construtor da classe
		public Documento()
		{
			this.nome = null;
            this.categoria = null;
		}

		//construtor alternativo
		public Documento(string _nome, string _categoria)
		{
			this.nome = _nome;
            this.categoria = _categoria;

		}

		//getters
		public string GetNome() { return this.nome; }
        public string GetCategoria() { return this.categoria; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }
        public void SetCategoria(string _categoria) { this.categoria = _categoria; }

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

