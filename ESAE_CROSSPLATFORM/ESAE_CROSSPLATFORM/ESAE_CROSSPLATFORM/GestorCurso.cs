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

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach (Curso curso in listaCurso)
            {
                string nome = curso.GetNome().ToString();
                string tipodecurso = curso.GetTipodecurso().ToString();
                string responsavel = curso.GetResponsavel().ToString();
                string descricao = curso.GetDescricao().ToString();
                int telefone = curso.GetTelefone().ToString(); //perguntar ao prof como se converte int e bool
                dadosaenviar.Add(nome, tipodecurso, responsavel, descricao, telefone);
            }
            return dadosaenviar;
        }

    }

}
