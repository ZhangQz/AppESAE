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
    public class UtilizadorController
    {
        private WS servidor; //ligação ao servidor
        public List<Utilizador> ListaUtilizador; //lista de objetos do model

        public UtilizadorController()
        {
            servidor = new WS();

            //o vosso projeto do laravel chama-se APP? Esta URI está certa? (http://10.0.2.2/APP/public/api/utilizadors)
            ListaUtilizador = JsonConvert.DeserializeObject<List<Utilizador>>(servidor.PedidoServidor("http://10.0.2.2/backoffice/public/api/utilizadors").ReadLine());
        }

        public void InserirUtilizador(Utilizador _utilizador)
        {
            ListaUtilizador.Add(_utilizador); //adiciona a utilizador à lista
            Debug.WriteLine("Utilizador criado com sucesso...");
        }

        public void EditarUtilizador(int id, Utilizador _utilizador)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarUtilizador(int id, Utilizador _utilizador)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaUtilizadors()
        {
            foreach (Utilizador p in ListaUtilizador)
            {
                Debug.WriteLine(p.GetNumero()); //imprime o nome da utilizador atual
                Debug.WriteLine(p.GetNome()); //imprime o nome da utilizador atual
            }
        }

        public List<Utilizador> GetAllItens()
        {
            List<Utilizador> dadosaenviar = new List<Utilizador>();

            foreach (Utilizador utilizador in ListaUtilizador)
            {
                Utilizador novo = new Utilizador();
                novo.SetNumero(utilizador.GetNumero());
                novo.SetNome(utilizador.GetNome());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
