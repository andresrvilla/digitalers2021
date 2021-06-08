using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[10];
            numeros[0] = 1;
            numeros[1] = 1123;
            numeros[2] = 4123;
            numeros[3] = 51234;
            numeros[4] = 5123;
            numeros[5] = 6123;
            numeros[6] = 6567;
            numeros[7] = 967;
            numeros[8] = 09678;
            numeros[9] = 654;*/

            // Es equivalente a:
            int[] numeros = new int[] { 1, 1123, 4123, 51234, 5123, 6123, 6567, 967, 09678, 654 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine((i+1)+ " " + numeros[i]);
            }

            int valor = numeros[0];

            for(int i = 1; i < numeros.Length; i++)
            {
                if(numeros[i] > valor)
                {
                    valor = numeros[i];
                }
            }

            Console.WriteLine("El valor maximo es " + valor);

            Console.ReadKey();
        }
    }
}
