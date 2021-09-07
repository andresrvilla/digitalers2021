using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    class Program
    {

        delegate void Escribir(string mensaje);

        static void Main(string[] args)
        {
            Escribir e = (mensaje) => Console.WriteLine(mensaje);
            e("Hola expresión lambda!!!!");

            Escribir e2 = delegate (string mensaje)
            {
                Console.WriteLine(mensaje);
            };
            e2("Hola sin expresion lambda");
            Console.ReadKey();
        }
    }
}
