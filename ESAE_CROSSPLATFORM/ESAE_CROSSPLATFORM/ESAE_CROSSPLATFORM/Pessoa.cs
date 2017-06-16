namespace ESAE_CROSSPLATFORM
{
    public class Pessoa
    {
        //propriedades
        string nome, morada, email, genero;
        int idade;

        //construtor da classe
        public Pessoa()
        {
            this.nome = null;
            this.morada = null;
            this.email = null;
            this.genero = null;
            this.idade = 0;
        }

        //construtor alternativo
        public Pessoa(string _nome, string _morada,
            string _email, string _genero, int _idade)
        {
            this.nome = _nome;
            this.morada = _morada;
            this.email = _email;
            this.genero = _genero;
            this.idade = _idade;
        }

        //getters
        public string GetNome() { return this.nome; }
        public string GetMorada() { return this.morada; }
        public string GetEmail() { return this.email; }
        public string GetGenero() { return this.genero; }
        public int GetIdade() { return this.idade; }

        //setters
        public void SetNome(string _nome) { this.nome = _nome; }
        public void SetMorada(string _morada) { this.morada = _morada; }
        public void SetEmail(string _email) { this.email = _email; }
        public void SetGenero(string _genero) { this.genero = _genero; }
        public void SetIdade(int _idade) { this.idade = _idade; }

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