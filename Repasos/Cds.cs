using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasos
{
    class Cds
    {
        private string titulo;
        private List<Temas> temas = new List<Temas>();

        public Cds()
        {
        }

        public Cds(string titulo)
        {
            this.Titulo = titulo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        internal List<Temas> Temas { get => temas; set => temas = value; }

        public string duracion()
        {
            int d = 0;

            foreach(Temas t in temas)
            {
                d += t.Tiempo;
            }

            string result = (d / 60) + "\' " + (d % 60) + "\"";
            return result;
        }
    }
}
