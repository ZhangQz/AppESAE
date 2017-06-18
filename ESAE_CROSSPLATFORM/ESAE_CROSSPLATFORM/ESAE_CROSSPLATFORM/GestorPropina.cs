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

namespace ESAE_CROSSPLATFORM
{
    public class GestorPropinas
    {
        List<Propina> listaPropina;

        //construtor da classe
        public GestorPropinas()
        {
            listaPropina = new List<Propina>();
        }

        public void InserirPropina(Propina _propina)
        {
            listaPropina.Add(_propina); //adiciona a disciplina à lista
            Debug.WriteLine("Propina criado com sucesso...");
        }

        public void listaPropinas()
        {
            foreach (Propina p in listaPropina)
            {
                Debug.WriteLine(p.GetMes()); //imprime o mes da propina atual
                Debug.WriteLine(p.GetAno()); //imprime o ano da propina atual
                Debug.WriteLine(p.GetValor()); //imprime o valor da propina atual
                Debug.WriteLine(p.GetPago()); //imprime o pagou ou nao da propina atual

            }
        }

        public List<Propina> GetAllItens()
        {
            List<Propina> dadosaenviar = new List<Propina>();

            foreach (Propina propina in listaPropina)
            {
                Propina novo = new Propina();
                novo.SetValor(propina.GetValor());
                novo.SetPago(propina.GetPago());
                novo.SetAno(propina.GetAno());
                novo.SetMes(propina.GetMes());

                dadosaenviar.Add(novo);
            }
            return dadosaenviar;
        }
    }
}
