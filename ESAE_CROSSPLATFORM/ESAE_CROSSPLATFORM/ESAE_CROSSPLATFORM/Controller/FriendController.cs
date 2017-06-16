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
    public class FriendController
    {
        private WS servidor; //ligação ao servidor
        public List<Friend> ListaFriends; //lista de objetos do model

        public FriendController()
        {
            servidor = new WS();
            ListaFriends = JsonConvert.DeserializeObject<List<Friend>>(servidor.PedidoServidor("http://10.0.2.2/wishlist/public/api/friends").ReadLine());
        }
    }
}
