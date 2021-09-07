using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Delegados
{
    class Program
    {
        delegate void Escribir(string texto);

        static void Log(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void Main(string[] args)
        {
            Escribir escritor = Console.WriteLine;
            escritor("Hola mundo");

            Saludar(escritor);
            Saludar(Log);

            // Metodos anonimo
            Escribir metodoAnonimo = delegate (string mensaje)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("- !METODO ANONIMO! -");
                Console.WriteLine(mensaje);
                Console.WriteLine("--------------------");
            };

            metodoAnonimo("Esto lo llamo en un metodo anonimo");

            Console.ReadKey();
        }

        static void Saludar(Escribir unEscritor)
        {
            unEscritor("Hola Mundo desde la funcion saludar");
        }
    }
}
