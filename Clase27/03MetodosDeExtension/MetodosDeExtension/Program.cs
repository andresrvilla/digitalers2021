using MetodosDeExtension.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string miTexto = "Tengo ganas de un break";
            Console.WriteLine(miTexto);
            miTexto = miTexto.Invertir();
            Console.WriteLine(miTexto);
            Console.ReadKey();
        }
    }
}
