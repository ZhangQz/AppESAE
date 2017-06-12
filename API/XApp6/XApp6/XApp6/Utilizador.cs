using System;

namespace MDP
{
	public class Utilizador
	{
		//propriedades
		string nome;
		int numero;

		//construtor da classe
		public Utilizador()
		{
			this.nome = null;
			this.numero = 0;
		}

		//construtor alternativo
		public Utilizador(string _nome, int _numero)
		{
			this.nome = _nome;
			this.numero = _numero;
		}

		//getters
		public string GetNome() { return this.nome; }
		public int GetNumero() { return this.numero; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }
		public void SetNumero(int _numero) { this.numero = _numero; }

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