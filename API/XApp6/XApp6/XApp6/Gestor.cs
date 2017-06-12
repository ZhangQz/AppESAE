using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XApp6
{
    public class Gestor
    {
        List<Pessoa> listaPessoas;

        //construtor da classe
        public Gestor()
        {
            listaPessoas = new List<Pessoa>();
            listaUtilizador = new List<Utilizador>();
        }

        /******** EXEMPLO DAS AULAS COM PESSOAS *********/
        public void InserirPessoa(Pessoa _pessoa)
        {
            listaPessoas.Add(_pessoa); //adiciona a pessoa à lista
            Debug.WriteLine("Pessoa criada com sucesso...");
        }

        public void ListaPessoas()
        {
            foreach (Pessoa p in listaPessoas)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da pessoa atual
            }
        }

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach(Pessoa pessoa in listaPessoas)
            {
                string x = pessoa.GetNome().ToString();
                dadosaenviar.Add(x);
            }
            return dadosaenviar;
        }
    }
}
