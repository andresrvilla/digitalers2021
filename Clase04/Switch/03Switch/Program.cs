using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF anidados pueden ser costosos en tiempo de procesamiento

            int numeroUno = 100;

            if(numeroUno > 50)
            {
                if(numeroUno > 90)
                {
                    Console.WriteLine("Entra a los dos if");
                }
            }

            //Esto no tiene tanto costo, pero puede simplificarse...

            //if(numeroUno == 1)
            //{
            //    Console.WriteLine("NumeroUno es 1");
            //} 
            //else if(numeroUno == 2)
            //{
            //    Console.WriteLine("NumeroUno es 2");
            //}
            //else if (numeroUno == 3)
            //{
            //    Console.WriteLine("NumeroUno es 3");
            //}
            //else
            //{
            //    Console.WriteLine("NumeroUno es otro numero");
            //}
            switch (numeroUno)
            {
                case 1:
                    Console.WriteLine("El numero es 1");
                    break;
                case 2:
                    Console.WriteLine("El numero es 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("El numero es 3 o 4");
                    break;
                default:
                    Console.WriteLine("NumeroUno es otro numero");
                    break;
            }


            Console.ReadKey();
        }
    }
}
