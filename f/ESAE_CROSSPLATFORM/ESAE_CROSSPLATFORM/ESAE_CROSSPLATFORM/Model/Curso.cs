namespace ESAE_CROSSPLATFORM.Model
{
    public class Curso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipodecurso { get; set; }
        public string responsavel { get; set; }
        public string descricao { get; set; }
        public string email { get; set; }/*
        public List<Disciplina> disciplinas { get; set; }
        public List<Evento> eventos { get; set; }
        public List<Documento> documentos { get; set; }
        public List<Utilizador> utilizadores { get; set; }
        public List<Propina> propinas { get; set; }

        //propriedades
        string nome, tipodecurso, responsavel, descricao;
        int telefone;*/

        //construtor da classe
        public Curso()
        {
            this.nome = null;
            this.tipodecurso = null;
            this.responsavel = null;
            this.descricao = null;
            this.email = null;
        }

        //construtor alternativo
        public Curso(string _nome, string _tipodecurso,
            string _responsavel, string _descricao, string _email, int _telefone)
        {
            this.nome = _nome;
            this.tipodecurso = _tipodecurso;
            this.responsavel = _responsavel;
            this.descricao = _descricao;
            this.email = _email;
        }

        //getters
        public string GetNome() { return this.nome; }
        public string GetTipodecurso() { return this.tipodecurso; }
        public string GetResponsavel() { return this.responsavel; }
        public string GetDescricao() { return this.descricao; }
        public string GetEmail() { return this.email; }

        //setters
        public void SetNome(string _nome) { this.nome = _nome; }
        public void SetTipodecurso(string _tipodecurso) { this.tipodecurso = _tipodecurso; }
        public void SetResponsavel(string _responsavel) { this.responsavel = _responsavel; }
        public void SetDescricao(string _descricao) { this.descricao = _descricao; }
        public void SetEmail(string _email) { this.email = _email; }

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



