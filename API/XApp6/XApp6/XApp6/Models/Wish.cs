using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XApp6
{
    public class Wish
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public int rank { get; set; }
        public List<Friend> friends { get; set; }
    }
}