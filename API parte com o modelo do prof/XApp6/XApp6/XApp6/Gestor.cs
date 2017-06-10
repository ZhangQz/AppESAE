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

            foreach(Utilizador utilizador in listaUtilizador)
            {
                string nome = utilizador.GetNome().ToString();
                int numero = utilizador.GetNumero().ToString(); //perguntar ao prof como se converte int e bool
                dadosaenviar.Add(nome, numero);
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
			listaCurso.Add(_curso); //adiciona a curso à lista
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

			foreach (Curso curso in listaCurso)
			{
				string nome = curso.GetNome().ToString();
                string tipodecurso = curso.GetTipodecurso().ToString();
                string responsavel = curso.GetResponsavel().ToString();
                string descricao = curso.GetDescricao().ToString();
				int telefone = curso.GetTelefone().ToString(); //perguntar ao prof como se converte int e bool
                dadosaenviar.Add(nome, tipodecurso, responsavel, descricao, telefone);
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
				
				dadosaenviar.Add(nome, tipo, local);
			}
			return dadosaenviar;
		}

	}

	public class GestorDisciplina
	{
		List<Disciplina> listaDisciplinas;

		//construtor da classe
		public GestorDisciplina()
		{
			listaDisciplinas = new List<Disciplina>();
		}

		public void InserirDisciplina(Disciplina _disciplina)
		{
			listaDisciplinas.Add(_disciplina); //adiciona a disciplina à lista
			Debug.WriteLine("Disciplina criada com sucesso...");
		}

		public void listaDisciplina()
		{
			foreach (Disciplina p in listaDisciplinas)
			{
				Debug.WriteLine(p.GetNome()); //imprime o nome da disciplina atual

			}
		}

		public List<string> GetAllItens()
		{
			List<string> dadosaenviar = new List<string>();

			foreach (Disciplina disciplina in listaDisciplinas)
			{
				string nome = disciplina.GetNome().ToString();
				dadosaenviar.Add(nome);
			}
			return dadosaenviar;
		}

	}

	public class GestorDocumento
	{
		List<Documento> listaDocumentos;

		//construtor da classe
		public GestorDocumento()
		{
			listaDocumentos = new List<Documento>();
		}

		public void InserirDocumento(Documento _documento)
		{
			listaDocumentos.Add(_documento); //adiciona a disciplina à lista
			Debug.WriteLine("Documento criado com sucesso...");
		}

		public void listaDocumento()
		{
			foreach (Documento p in listaDocumentos)
			{
				Debug.WriteLine(p.GetNome()); //imprime o nome da disciplina atual

			}
		}

		public List<string> GetAllItens()
		{
			List<string> dadosaenviar = new List<string>();

			foreach (Documento documento in listaDocumentos)
			{
				string nome = documento.GetNome().ToString();
                string categoria = documento.GetCategoria().ToString();
				dadosaenviar.Add(nome, categoria);
			}
			return dadosaenviar;
		}

	}

	public class GestorPropina
	{
		List<Propina> listaPropina;

		//construtor da classe
		public GestorPropina()
		{
			listaPropina = new List<Propina>();
		}

		public void InserirPropina(Propina _propina)
		{
			listaPropina.Add(_propina); //adiciona a disciplina à lista
			Debug.WriteLine("Propina criado com sucesso...");
		}

		public void listaPropinas()
		{
			foreach (Propina p in listaPropina)
			{
				Debug.WriteLine(p.GetMes()); //imprime o mes da propina atual
                Debug.WriteLine(p.GetAno()); //imprime o ano da propina atual
				Debug.WriteLine(p.GetValor()); //imprime o valor da propina atual
				Debug.WriteLine(p.GetPago()); //imprime o pagou ou nao da propina atual

			}
		}

		public List<string> GetAllItens()
		{
			List<string> dadosaenviar = new List<string>();

            foreach (Propina propina in listaPropina)
			{
				string mes = propina.GetMes().ToString();
				int ano = propina.GetAno().ToString();
                int valor = propina.GetValor().ToString();
                bool pago = propina.GetPago();
				dadosaenviar.Add(mes, ano, valor, pago);
			}
			return dadosaenviar;
		}

	}
}
