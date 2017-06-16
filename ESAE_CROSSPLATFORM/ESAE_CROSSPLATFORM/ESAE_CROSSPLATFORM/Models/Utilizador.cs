using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAE_CROSSPLATFORM
{
    public class Utilizador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int numero { get; set; }
        public List<Curso> curso { get; set; }

    }
}
