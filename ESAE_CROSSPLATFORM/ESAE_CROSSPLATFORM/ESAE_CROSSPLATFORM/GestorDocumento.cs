using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{
    public class GestorDocumento
    {
        List<Documento> listaDocumentos;

        //construtor da classe
        public GestorDocumento()
        {
            listaDocumentos = new List<Documento>();
        }

        public void InserirDocumento(Documento _documento)
        {
            listaDocumentos.Add(_documento); //adiciona a disciplina à lista
            Debug.WriteLine("Documento criado com sucesso...");
        }

        public void listaDocumento()
        {
            foreach (Documento p in listaDocumentos)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da disciplina atual

            }
        }

        public List<string> GetAllItens()
        {
            List<string> dadosaenviar = new List<string>();

            foreach (Documento documento in listaDocumentos)
            {
                string nome = documento.GetNome().ToString();
                string categoria = documento.GetCategoria().ToString();
                dadosaenviar.Add(nome, categoria);
            }
            return dadosaenviar;
        }
    }
}
