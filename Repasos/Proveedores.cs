using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Proveedores : Personas
    {
        private string ruc;

        public string Ruc { get => ruc; set => ruc = value; }
    }
}
