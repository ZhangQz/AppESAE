using System;
namespace ESAE_CROSSPLATFORM
{
    public class Curso
    {
        
		//propriedades
		string nome, tipodecurso, responsavel, descricao;
        int telefone;

		//construtor da classe
		public Curso()
		{
			this.nome = null;
			this.tipodecurso = null;
			this.responsavel = null;
			this.descricao = null;
			this.telefone = 0;
		}

		//construtor alternativo
		public Curso(string _nome, string _tipodecurso,
			string _responsavel, string _descricao, int _telefone)
		{
			this.nome = _nome;
			this.tipodecurso = _tipodecurso;
			this.responsavel = _responsavel;
			this.descricao = _descricao;
			this.telefone = _telefone;
		}

		//getters
		public string GetNome() { return this.nome; }
		public string GetTipodecurso() { return this.tipodecurso; }
		public string GetResponsavel() { return this.responsavel; }
		public string GetDescricao() { return this.descricao; }
		public int GetTelefone() { return this.telefone; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }
		public void SetTipodecurso(string _tipodecurso) { this.tipodecurso = _tipodecurso; }
		public void SetResponsavel(string _responsavel) { this.responsavel = _responsavel; }
		public void SetDescricao(string _descricao) { this.descricao = _descricao; }
		public void SetTelefone(int _telefone) { this.telefone = _telefone; }

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

