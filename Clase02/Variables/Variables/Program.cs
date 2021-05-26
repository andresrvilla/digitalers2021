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
            //Esto es un comentario

            /*
HOLA
            esto es un comentario
            de varias
            lineas



            Chau.             
             */


            // TIPODEDATO NOMBRE;
            int miNumero;
            miNumero = 55;

            // TIPODEDATO NOMBRE = VALOR;
            int miOtroNumero = 100;

            Console.WriteLine(miNumero);
            Console.WriteLine(miOtroNumero);

            miNumero = 150;
            miOtroNumero = 55;

            Console.WriteLine(miNumero);
            Console.WriteLine(miOtroNumero);

            Console.ReadKey();
        }
    }
}
