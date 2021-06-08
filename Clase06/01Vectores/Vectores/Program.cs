using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array");
            string ingreso = Console.ReadLine();
            int tamano = Convert.ToInt32(ingreso);


            // TIPO NOMBREVARIABLE;
            int[] misNumeros = new int[tamano];
            string[] misTextos = new string[3];

            misNumeros[0] = 10; // Esto indica que le pone el numero diez a la primer posicion del vector (indice cero)
            misNumeros[1] = 100;

            Console.WriteLine("Array de " + misNumeros.Length);

            int contador = 0;

            while(contador < misNumeros.Length)
            {
                Console.WriteLine("Vuelta nro" + contador);
                Console.WriteLine("El elemento tiene el valor " + misNumeros[contador]);
                contador++;
            }

            Console.ReadKey();
        }
    }
}
