﻿using Newtonsoft.Json;
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
    public class DocumentosController
    {
		
        private WS servidor; //ligação ao servidor
		public List<Documento> listaDocumentos; //lista de objetos do model
		public List<Documento> EditarDocumentos; //editar de objetos do model
        public List<Documento> InserirDocumentos; //editar de objetos do model
        public List<Documento> EliminaDocumentos; //editar de objetos do model

    public DocumentosController()
		{
			servidor = new WS();
			listaDocumentos = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/documentos").ReadLine());
			EditarDocumentos = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/documentos").ReadLine());
			InserirDocumentos = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/documentos").ReadLine());
			EliminaDocumentos = JsonConvert.DeserializeObject<List<Documento>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/documentos").ReadLine());
		}
    }
}
