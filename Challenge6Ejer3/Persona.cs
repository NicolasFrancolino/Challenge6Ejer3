using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer3
{
    partial class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }

        public Persona(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaNac = fecha;
        }
    }
}
