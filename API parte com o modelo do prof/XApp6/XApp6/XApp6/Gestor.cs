using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP
{
    public class GestorUtilizador
    {
        List<Utilizador> listaPessoas;

        //construtor da classe
        public GestorUtilizador()
        {
            listaPessoas = new List<Utilizador>();
        }

        public void InserirPessoa(Utilizador _pessoa)
        {
            listaPessoas.Add(_pessoa); //adiciona a pessoa à lista
            Debug.WriteLine("Pessoa criada com sucesso...");
        }

        public void ListaPessoas()
        {
            foreach (Utilizador p in listaPessoas)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da pessoa atual
                Debug.WriteLine(p.GetNumero()); //imprime o numero da pessoa atual
			}
        }

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach(Utilizador pessoa in listaPessoas)
            {
                string nome = pessoa.GetNome().ToString();
                int numero = pessoa.GetNumero().ToString(); //perguntar ao prof como se converte int e bool
                dadosaenviar.Add(x);
            }
            return dadosaenviar;
        }

    }

	public class GestorCurso
	{
		List<Curso> listaCurso;

		//construtor da classe
		public GestorCurso()
		{
			listaCurso = new List<Curso>();
		}

		public void InserirCurso(Curso _curso)
		{
			listaCurso.Add(_curso); //adiciona a pessoa à lista
			Debug.WriteLine("Curso criado com sucesso...");
		}

		public void ListaCurso()
		{
			foreach (Curso p in listaCurso)
			{
				Debug.WriteLine(p.GetNome()); //imprime o nome da curso atual
                Debug.WriteLine(p.GetTipodecurso()); //imprime o tipodecurso da curso atual
				Debug.WriteLine(p.GetResponsavel()); //imprime o responsavel da curso atual
				Debug.WriteLine(p.GetDescricao()); //imprime o descrisao da curso atual
				Debug.WriteLine(p.GetTelefone()); //imprime o telefone da curso atual
			}
		}

		public List<string> GetAllItens()
		{
			List<string> dadosaenviar = new List<string>();

			foreach (Curso pessoa in listaCurso)
			{
				string nome = pessoa.GetNome().ToString();
                string tipodecurso = tipodecurso.GetTipodecurso().ToString();
                string responsavel = responsavel.GetResponsavel().ToString();
                string descricao = descricao.GetDescricao().ToString();
				int numero = telefone.GetTelefone().ToString(); //perguntar ao prof como se converte int e bool
				dadosaenviar.Add(x);
			}
			return dadosaenviar;
		}

	}

	public class GestorEvento
	{
		List<Evento> listaEvento;

		//construtor da classe
		public GestorEvento()
		{
			listaEvento = new List<Evento>();
		}

		public void InserirEvento(Evento _evento)
		{
            listaEvento.Add(_evento); //adiciona a pessoa à lista
			Debug.WriteLine("Evento criado com sucesso...");
		}

		public void ListaEvento()
		{
			foreach (Evento p in listaEvento)
			{
				Debug.WriteLine(p.GetNome()); //imprime o nome da evento atual
				Debug.WriteLine(p.GetTipo()); //imprime o tipo da evento atual
				Debug.WriteLine(p.GetLocal()); //imprime o tipo da evento atual
				
			}
		}

		public List<string> GetAllItens()
		{
			List<string> dadosaenviar = new List<string>();

			foreach (Evento evento in listaEvento)
			{
				string nome = evento.GetNome().ToString();
                string tipo = evento.GetTipo().ToString();
                string local = evento.GetLocal().ToString();
				
				dadosaenviar.Add(x);
			}
			return dadosaenviar;
		}

	}
}
