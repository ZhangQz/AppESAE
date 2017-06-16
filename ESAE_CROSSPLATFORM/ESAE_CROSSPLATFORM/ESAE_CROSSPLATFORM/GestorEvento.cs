using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{ 
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

}
