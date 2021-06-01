using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EjercicioLaboratorioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Asignación básica");

            //int x = 10;
            //int y = 20;

            // Lo anterior es equivalente a ...

            int papa = 10, batata = 20;

            papa = papa + 5;
            batata = papa + batata;

            Console.WriteLine("Papa vale " + papa);
            Console.WriteLine("Batata vale " + batata);

            Console.ReadKey();
        }
    }
}
