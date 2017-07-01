using System;
namespace ESAE_CROSSPLATFORM
{
    public class Curso
    {
        
		//propriedades
		string nome, tipodecurso, responsavel, descricao, email;
        int etcs;

		//construtor da classe
		public Curso()
		{
			this.nome = null;
			this.tipodecurso = null;
			this.responsavel = null;
			this.descricao = null;
			this.email = null;
            this.etcs = 0;
		}

		//construtor alternativo
		public Curso(string _nome, string _tipodecurso,
			string _responsavel, string _descricao, string _email, int _etcs)
		{
			this.nome = _nome;
			this.tipodecurso = _tipodecurso;
			this.responsavel = _responsavel;
			this.descricao = _descricao;
			this.email = _email;
            this.etcs = _etcs;
		}

		//getters
		public string GetNome() { return this.nome; }
		public string GetTipodecurso() { return this.tipodecurso; }
		public string GetResponsavel() { return this.responsavel; }
		public string GetDescricao() { return this.descricao; }
        public string GetEmail() { return this.email; }
		public int GetEtcs() { return this.etcs; }

		//setters
		public void SetNome(string _nome) { this.nome = _nome; }
		public void SetTipodecurso(string _tipodecurso) { this.tipodecurso = _tipodecurso; }
		public void SetResponsavel(string _responsavel) { this.responsavel = _responsavel; }
		public void SetDescricao(string _descricao) { this.descricao = _descricao; }
        public void SetEmail(string _email) { this.email = _email; }
		public void SetEtcs(int _etcs) { this.etcs = _etcs; }

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

