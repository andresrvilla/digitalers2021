using System;

namespace EstructuraDeRepeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            /*
             ESTRUCTURA WHILE

            while(CONDICION)
            {
                //Este bloque de codigo se va a repetir
                //mientras se de la condicion
            }
             */

            int contador = 1;

            //
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            int contadorBucleDos = 1;

            while(contadorBucleDos< 10)
            {
                Console.WriteLine(contadorBucleDos);
                break; //Termina el bucle
            }

            while (contadorBucleDos <= 10)
            {
                if (contadorBucleDos == 5)
                {
                    contadorBucleDos++;
                    continue; // Se saltea la ejecucion actual y vuelve a la evaluacion
                }

                Console.WriteLine(contadorBucleDos);
                contadorBucleDos++;
            }

            // alternativa a lo mismo pero sin usar el continue:

            /*while (contadorBucleDos <= 10)
            {
                if (contadorBucleDos != 5)
                {
                    Console.WriteLine(contadorBucleDos);
                }
                contadorBucleDos++;
            }*/

            Console.ReadKey();
        }
    }
}
