using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona miPersona = new Persona();
            miPersona.apellido = "Villa";
            miPersona.nombre = "Andres";
            miPersona.edad = 25;

            Console.ReadKey();
        }
    }
}
