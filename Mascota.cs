using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoObjetos
{
    public class Mascota
    {
        public Mascota(string nombre, string dueño)
        {
            Nombre = nombre;
            Dueño = dueño;
        }
        public string Nombre { get; set; }
        public string Dueño { get; set; }

        public override string ToString()
        {
            return Nombre + "[" + Dueño + "]";
        }
    }
}