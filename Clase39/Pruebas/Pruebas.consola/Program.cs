using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero = 3000;
            long numeroEnteroLargo = numeroEntero;
            int otroEntero = (int)numeroEnteroLargo;

            long unLongGrande = long.MaxValue;
            int unLongEnUnInt = (int)unLongGrande;

            Console.WriteLine($"{numeroEntero} {numeroEnteroLargo} {otroEntero} {unLongEnUnInt}");

            DateTime ahora = DateTime.Now;
            object algo = ahora;

            DateTime unbox = (DateTime)algo;

            List<int> enteros = new List<int> { 15, 134, 123, 12, 512, 31, 25, 12, 34123 };


            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
