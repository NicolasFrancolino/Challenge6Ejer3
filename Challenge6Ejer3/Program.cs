using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato:");
            Console.WriteLine("Dia/Mes/Año");
            string fechaAux = Console.ReadLine();
            DateTime fecha = DateTime.ParseExact(fechaAux, "dd/MM/yyyy", null);
            Persona p = new Persona(nombre, fecha);
            p.Edad(); 
            Console.ReadKey();  
        }
    }
}
