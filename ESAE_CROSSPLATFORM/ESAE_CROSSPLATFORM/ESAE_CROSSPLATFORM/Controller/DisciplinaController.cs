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
    public class DisciplinaController
    {
        private WS servidor; //ligação ao servidor
        public List<Disciplina> ListaDisciplina; //lista de objetos do model

        public DisciplinaController()
        {
            servidor = new WS();

            //o vosso projeto do laravel chama-se APP? Esta URI está certa? (http://10.0.2.2/backoffice/public/api/disciplinas)
            ListaDisciplina = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("https://dparst.000webhostapp.com/public/api/disciplinas").ReadLine());
        }

        public void InserirDisciplina(Disciplina _disciplina)
        {
            ListaDisciplina.Add(_disciplina); //adiciona a disciplina à lista
            Debug.WriteLine("Disciplina criado com sucesso...");
        }

        public void EditarDisciplina(int id, Disciplina _disciplina)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarDisciplina(int id, Disciplina _disciplina)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaDisciplinas()
        {
            foreach (Disciplina p in ListaDisciplina)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da disciplina atual
            }
        }

        public List<Disciplina> GetAllItens()
        {
            List<Disciplina> dadosaenviar = new List<Disciplina>();

            foreach (Disciplina disciplina in ListaDisciplina)
            {
                Disciplina novo = new Disciplina();
                novo.SetNome(disciplina.GetNome());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
