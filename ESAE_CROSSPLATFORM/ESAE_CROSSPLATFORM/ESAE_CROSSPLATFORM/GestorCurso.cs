using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{
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

        public List<Curso> GetAllItens()
        {
            List<Curso> dadosaenviar = new List<Curso>();

            foreach (Curso curso in listaCurso)
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
