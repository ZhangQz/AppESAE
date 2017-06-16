using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{
    public class GestorDisciplina
    {
        List<Disciplina> listaDisciplinas;

        //construtor da classe
        public GestorDisciplina()
        {
            listaDisciplinas = new List<Disciplina>();
        }

        public void InserirDisciplina(Disciplina _disciplina)
        {
            listaDisciplinas.Add(_disciplina); //adiciona a disciplina à lista
            Debug.WriteLine("Disciplina criada com sucesso...");
        }

        public void listaDisciplina()
        {
            foreach (Disciplina p in listaDisciplinas)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da disciplina atual

            }
        }

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach (Disciplina disciplina in listaDisciplinas)
            {
                string nome = disciplina.GetNome().ToString();
                dadosaenviar.Add(nome);
            }
            return dadosaenviar;
        }
    }
}
