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
    public class DocumentoController
    {
        private WS servidor; //ligação ao servidor
        public List<Documento> ListaDocumento; //lista de objetos do model

        public DocumentoController()
        {
            servidor = new WS();

            //o vosso projeto do laravel chama-se APP? Esta URI está certa? (http://10.0.2.2/APP/public/api/documentos)
            ListaDocumento = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://10.0.2.2/backoffice/public/api/documentos").ReadLine());
        }

        public void InserirDocumento(Documento _documento)
        {
            ListaDocumento.Add(_documento); //adiciona a documento à lista
            Debug.WriteLine("Documento criado com sucesso...");
        }

        public void EditarDocumento(int id, Documento _documento)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarDocumento(int id, Documento _documento)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaDocumentos()
        {
            foreach (Documento p in ListaDocumento)
            {
                Debug.WriteLine(p.GetNome()); //imprime o nome da documento atual
                Debug.WriteLine(p.GetCategoria()); //imprime o tipodedocumento da documento atual
            }
        }

        public List<Documento> GetAllItens()
        {
            List<Documento> dadosaenviar = new List<Documento>();

            foreach (Documento documento in ListaDocumento)
            {
                Documento novo = new Documento();
                novo.SetNome(documento.GetNome());
                novo.SetCategoria(documento.GetCategoria());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
