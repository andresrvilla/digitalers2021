using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo();
            r.LadoA = 10;
            r.LadoB = 20;

            Console.WriteLine($"Rectangulo LadoA: {r.LadoA},LadoB: {r.LadoB}");
            Console.WriteLine($"Rectangulo Area: {r.Area()}");

            Cuadrado c = new Cuadrado();
            c.LadoA = 10;
            c.LadoB = 20;

            Console.WriteLine($"Cuadrado LadoA: {c.LadoA},LadoB: {c.LadoB}");
            Console.WriteLine($"Cuadrado Area: {c.Area()}");

            Console.ReadKey();
        }
    }
}
