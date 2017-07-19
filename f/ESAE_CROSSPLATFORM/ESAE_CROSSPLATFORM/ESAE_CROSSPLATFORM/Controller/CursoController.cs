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
using ESAE_CROSSPLATFORM;
using ESAE_CROSSPLATFORM.Model;

namespace ESAE_CROSSPLATFORM.Controller
{
    public class CursoController
    {
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCursos; //lista de objetos do model

        public CursoController()
        {
            servidor = new WS();

            ListaCursos = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("https://dparst.000webhostapp.com/public/api/cursos").ReadLine());
        }

        public void InserirCurso(Curso _curso)
        {
            ListaCursos.Add(_curso); //adiciona a curso à lista
            Debug.WriteLine("Curso criado com sucesso...");
        }

        public void EditarCurso(int id, Curso _curso)
        {
            //ListaCurso.(_curso);
        }

        public void ApagarCurso(int id, Curso _curso)
        {
            ListaCursos.Remove(_curso);
            Debug.WriteLine("O curso foi eliminado com sucesso");
        }

        public void ListaCurso()
        {
            foreach (Curso p in ListaCursos)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da curso atual
                Debug.WriteLine(p.GetTipodecurso()); //imprime o tipodecurso da curso atual
                Debug.WriteLine(p.GetResponsavel()); //imprime o responsavel da curso atual
                Debug.WriteLine(p.GetDescricao()); //imprime o descrisao da curso atual
            }
        }

        public List<Curso> GetAllItens()
        {
            List<Curso> dadosaenviar = new List<Curso>();

            foreach (Curso curso in ListaCursos)
            {
                Curso novo = new Curso();
                novo.SetNome(curso.GetNome());
                novo.SetTipodecurso(curso.GetTipodecurso());
                novo.SetResponsavel(curso.GetResponsavel());
                novo.SetDescricao(curso.GetDescricao());
                novo.SetEmail(curso.GetEmail());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }

        public List<Curso> GetItemByTipodecurso()
        {
            List<Curso> dadosaenviar = new List<Curso>();

            foreach (Curso curso in ListaCursos)
            {
                Curso novo = new Curso();
                novo.SetNome(curso.GetNome());
                novo.SetTipodecurso(curso.GetTipodecurso());
                novo.SetResponsavel(curso.GetResponsavel());
                novo.SetDescricao(curso.GetDescricao());
                novo.SetEmail(curso.GetEmail());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
