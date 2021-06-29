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
            /*Cuadrado cuadrado = new Cuadrado();
            cuadrado.LadoA = 100;*/

            // es equivalente a
            Cuadrado cuadrado = new Cuadrado()
            {
                LadoA = 100,
                LadoB = 100
            };

            Console.WriteLine($"El area del cuadrado es {cuadrado.Area()}");

            // Asigno a una variable que es de tipo "padre" un objeto que es de tipo "hijo"
            FiguraGeometrica unaFiguraGeometrica = cuadrado;

            Console.WriteLine($"El area de la figura es {unaFiguraGeometrica.Area()}");

            FiguraGeometrica[] figuras = new FiguraGeometrica[4];
            figuras[0] = new Circunferencia() { Radio = 15 };
            figuras[1] = new Cuadrado() { LadoA = 10};
            figuras[2] = new Cuadrado() { LadoA = 12 };
            figuras[3] = new Rectangulo() { LadoA = 30, LadoB = 3 };


            for(int i = 0; i < figuras.Length; i++)
            {
                FiguraGeometrica unaFigura = figuras[i];
                Console.WriteLine($"La figura {unaFigura.Tipo} tiene un area de {unaFigura.Area()}");
            }

            IGuardable miGuardable = new Cuadrado();

            Console.WriteLine(Matematica.Suma(1, 2));

            Console.ReadKey();
        }
    }
}
