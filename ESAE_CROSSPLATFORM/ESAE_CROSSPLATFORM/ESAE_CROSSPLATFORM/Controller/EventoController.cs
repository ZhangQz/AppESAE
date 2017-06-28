using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ESAE_CROSSPLATFORM.API;

namespace ESAE_CROSSPLATFORM.Controller
{
    public class EventoController
    {
        private WS servidor; //ligação ao servidor
        public List<Evento> ListaEvento; //lista de objetos do model

        public EventoController()
        {
            servidor = new WS();

            ListaEvento = JsonConvert.DeserializeObject<List<Evento>>(servidor.PedidoServidor("http://10.0.2.2/backoffice/public/api/eventos").ReadLine());
        }

        public void InserirEvento(Evento _evento)
        {
            ListaEvento.Add(_evento); //adiciona a evento à lista
            Debug.WriteLine("Evento criado com sucesso...");
        }

        public void EditarEvento(int id, Evento _evento)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarEvento(int id, Evento _evento)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaEventos()
        {
            foreach (Evento p in ListaEvento)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da evento atual
                Debug.WriteLine(p.GetTipo()); //imprime o Tipo da evento atual
                Debug.WriteLine(p.GetLocal()); //imprime o Local da evento atual
            }
        }

        public List<Evento> GetAllItens()
        {
            List<Evento> dadosaenviar = new List<Evento>();

            foreach (Evento evento in ListaEvento)
            {
                Evento novo = new Evento();
                novo.SetNome(evento.GetNome());
                novo.SetTipo(evento.GetTipo());
                novo.SetLocal(evento.GetLocal());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
