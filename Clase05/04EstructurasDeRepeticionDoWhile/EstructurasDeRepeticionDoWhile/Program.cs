using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeRepeticionDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra="s";

            do
            {
                Console.WriteLine("Ingrese una letra:");
                letra = Console.ReadLine();
            }
            while (letra != "s");

            Console.ReadKey();
        }
    }
}
