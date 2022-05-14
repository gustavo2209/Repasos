using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Empleados : Personas
    {
        private string cargo;

        public Empleados(string cargo, string nombre, string correo, string telefono) : base(nombre, correo, telefono)
        {
            this.cargo = cargo;
        }

        public string Cargo { get => cargo; set => cargo = value; }
    }
}
