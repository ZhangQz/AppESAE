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
            
            ListaCurso = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("https://dparst.000webhostapp.com/public/api/cursos").ReadLine());
        }

        public void InserirCurso(Curso _curso)
        {
            ListaCurso.Add(_curso); //adiciona a curso à lista
            Debug.WriteLine("Curso criado com sucesso...");
        }

        public void EditarCurso(int id, Curso _curso)
        {
            //ListaCurso.(_curso);
        }

        public void ApagarCurso(int id, Curso _curso)
        {
            ListaCurso.Remove(_curso);
            Debug.WriteLine("O curso foi eliminado com sucesso");
        }

        public void ListaCursos()
        {
            foreach (Curso p in ListaCurso)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da curso atual
                Debug.WriteLine(p.GetTipodecurso()); //imprime o tipodecurso da curso atual
                Debug.WriteLine(p.GetResponsavel()); //imprime o responsavel da curso atual
                Debug.WriteLine(p.GetDescricao()); //imprime o descrisao da curso atual
                Debug.WriteLine(p.GetEtcs());
                Debug.WriteLine(p.GetEtcs()); //imprime o telefone da curso atual
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
                novo.SetEmail(curso.GetEmail());
                novo.SetEtcs(curso.GetEtcs());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
