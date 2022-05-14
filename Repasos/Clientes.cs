using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Clientes : Personas
    {
        private double credito;

        public Clientes(string nombre, string correo, string telefono) : base(nombre, correo, telefono)
        {
            
        }

        public double Credito { get => credito; set => credito = value; }
    }
}
