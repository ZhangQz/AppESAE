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
    public class CursoController
    {
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCurso; //lista de objetos do model

        public CursoController()
        {
            servidor = new WS();
            
            ListaCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/backoffice/public/api/cursos").ReadLine());
        }

        public void InserirCurso(Curso _curso)
        {
            ListaCurso.Add(_curso); //adiciona a curso à lista
            Debug.WriteLine("Curso criado com sucesso...");
        }

        public void EditarCurso(int id, Curso _curso)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarCurso(int id, Curso _curso)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaCursos()
        {
            foreach (Curso p in ListaCurso)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da curso atual
                Debug.WriteLine(p.GetTipodecurso()); //imprime o tipodecurso da curso atual
                Debug.WriteLine(p.GetResponsavel()); //imprime o responsavel da curso atual
                Debug.WriteLine(p.GetDescricao()); //imprime o descrisao da curso atual
                Debug.WriteLine(p.GetTelefone()); //imprime o telefone da curso atual
            }
        }

        public List<Curso> GetAllItens()
        {
            List<Curso> dadosaenviar = new List<Curso>();

            foreach (Curso curso in ListaCurso)
            {
                Curso novo = new Curso();
                novo.SetNome(curso.GetNome());
                novo.SetTipodecurso(curso.GetTipodecurso());
                novo.SetResponsavel(curso.GetResponsavel());
                novo.SetDescricao(curso.GetDescricao());
                novo.SetTelefone(curso.GetTelefone());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
