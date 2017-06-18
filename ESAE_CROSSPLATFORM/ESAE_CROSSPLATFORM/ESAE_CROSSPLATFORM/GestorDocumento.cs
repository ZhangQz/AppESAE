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

        public List<Documento> GetAllItens()
        {
            List<Documento> dadosaenviar = new List<Documento>();

            foreach (Documento documento in listaDocumentos)
            {
                Documento novo = new Documento();
                string categoria = documento.GetCategoria().ToString();
                novo.SetNome(documento.GetNome());

                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }

    }
}
