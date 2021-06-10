using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedimientosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            encabezado();
            int pepe = sumar(15,3);
            Console.WriteLine(pepe);
            Console.ReadKey();
        }

        static int sumar(int numeroUno, int numeroDos)
        {
            int resultado = numeroUno + numeroDos;
            return resultado;
        }

        static void encabezado()
        {
            Console.WriteLine("Bienvenidos al programa");
        }
        /*
         static TIPODEDATORETORNO nombre(parametros, parametros, ... )
        {

        }
         */
    }
}
