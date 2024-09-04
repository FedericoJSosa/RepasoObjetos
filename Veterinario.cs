using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoObjetos
{
    public class Veterinario
    {
        public Veterinario(int matricula, string nombre)
        {
            Matricula = matricula;
            Nombre = nombre;
        }
        public string Nombre { get; set; }
        public int Matricula { get; set; }

        public override string? ToString()
        {
            return Nombre+" espacio vacio "+Matricula;
        }
    }
}

