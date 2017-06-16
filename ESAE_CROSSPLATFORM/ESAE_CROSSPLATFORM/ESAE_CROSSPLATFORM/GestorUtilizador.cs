using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{
    public class GestorUtilizador
    {
        List<Utilizador> listaUtilizadores;

        //construtor da classe
        public GestorUtilizador()
        {
            listaUtilizadores = new List<Utilizador>();
        }

        public void InserirPessoa(Utilizador _pessoa)
        {
            listaUtilizadores.Add(_pessoa); //adiciona a pessoa à lista
            Debug.WriteLine("Pessoa criada com sucesso...");
        }

        public void listaUtilizador()
        {
            foreach (Utilizador p in listaUtilizadores)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da pessoa atual
                Debug.WriteLine(p.GetNumero()); //imprime o numero da pessoa atual
            }
        }

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach (Utilizador utilizador in listaUtilizadores)
            {
                string nome = utilizador.GetNome().ToString();
                int numero = utilizador.GetNumero().ToString(); //perguntar ao prof como se converte int e bool
                dadosaenviar.Add(nome, numero);
            }
            return dadosaenviar;
        }
    }
}
