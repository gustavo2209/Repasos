using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Personas
    {
        private string nombre;
        private string correo;
        private string telefono;

        public Personas()
        {
        }

        public Personas(string nombre, string correo, string telefono)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
