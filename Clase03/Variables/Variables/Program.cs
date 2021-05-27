using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentario de una linea

            /*
             Comentario
             de varias
             lineas
             */

//            <TIPO DE DATO> <NOMBRE VARIABLE> = <VALOR VARIABLE>;

            int miVariable; // Creo la variable "miVariable"

            miVariable = 1000;

            int miOtroNumero = 2000;

            string miTexto = "Hola\n \" como estas?";

            Console.WriteLine(miTexto);

            string otroTexto = "Hola" +
                "Soy otro" +
                "TExto";

            string unTercerTexto = @"Hola
Esto tiene
Varias
Lienas";

            Console.WriteLine(miVariable);Console.ReadKey();
        }
    }
}
