using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresá un numero para la suma sucesiva: ");
            string ingresoUsuario = Console.ReadLine();
            int numeroSuma = Convert.ToInt32(ingresoUsuario);

            int numeroControl = 0;
            int total = 0;

            while (numeroControl <= numeroSuma)
            {
                total = total + numeroControl;
                numeroControl++;
            }

            Console.WriteLine("La suma entre 1 y " + numeroSuma + " es " + total);

            Console.ReadKey();
        }
    }
}
