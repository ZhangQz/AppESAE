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
    public class PropinaController
    {
        private WS servidor; //ligação ao servidor
        public List<Propina> ListaPropina; //lista de objetos do model

        public PropinaController()
        {
            servidor = new WS();

            //o vosso projeto do laravel chama-se APP? Esta URI está certa? (http://10.0.2.2/APP/public/api/propinas)
            ListaPropina = JsonConvert.DeserializeObject<List<Propina>>(servidor.PedidoServidor("http://10.0.2.2/backoffice/public/api/propinas").ReadLine());
        }

        public void InserirPropina(Propina _propina)
        {
            ListaPropina.Add(_propina); //adiciona a propina à lista
            Debug.WriteLine("Propina criado com sucesso...");
        }

        public void EditarPropina(int id, Propina _propina)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) e que recebe um objeto e salva (edita) na base de dados
        }

        public void ApagarPropina(int id, Propina _propina)
        {
            //escrevam o código aqui em falta...
            //este método têm o desafio de tentarem saber como podem chamar um método da API (que não está ainda criado no controlador do laravel) que recebe um ID e apaga da base de dados
        }

        public void ListaPropinas()
        {
            foreach (Propina p in ListaPropina)
            {
                Debug.WriteLine(p.GetAno()); //imprime o nome da propina atual
                Debug.WriteLine(p.GetMes()); //imprime o tipodepropina da propina atual
                Debug.WriteLine(p.GetValor()); //imprime o responsavel da propina atual
                Debug.WriteLine(p.GetPago()); //imprime o descrisao da propina atual
            }
        }

        public List<Propina> GetAllItens()
        {
            List<Propina> dadosaenviar = new List<Propina>();

            foreach (Propina propina in ListaPropina)
            {
                Propina novo = new Propina();
                novo.SetAno(propina.GetAno());
                novo.SetMes(propina.GetMes());
                novo.SetValor(propina.GetValor());
                novo.SetPago(propina.GetPago());
                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
