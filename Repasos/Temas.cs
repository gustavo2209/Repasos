using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Temas
    {
        private string titulo;
        private int tiempo;

        public Temas(string titulo, int tiempo)
        {
            this.Titulo = titulo;
            this.Tiempo = tiempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }
    }
}
