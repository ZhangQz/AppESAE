using System;
namespace MDP
{
    public class Disciplina
    {
		//propriedades
		string nome;
		

		//construtor da classe
		public Disciplina()
		{
			this.nome = null;
		}

		//construtor alternativo
		public Disciplina(string _nome)
		{
			this.nome = _nome;
			
		}

		//getters
		public string GetNome() { return this.nome; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }

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
