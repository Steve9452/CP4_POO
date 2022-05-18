using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP4_Test
{
    public class Repository
    {
        public string Alias { get; set; }
        public string Rol { get; set; }

        public Repository(string Alias, string Rol)
        {
            this.Alias = Alias;
            this.Rol = Rol;
        }
    }
}
