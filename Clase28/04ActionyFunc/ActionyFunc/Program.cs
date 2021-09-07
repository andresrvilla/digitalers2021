using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionyFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action son los delegados tipo "procedimiento", es decir no devuelve un valor
            Action<string> accion = (m) => Console.WriteLine(m);

            accion("Hola Mundo");

            Action<string> accionDos = delegate (string m)
            {
                Console.WriteLine(m);
            };

            //Func son los delegados tipo "funcion", es decir devuelven un valor
            Func<string> miFuncion = () => "0";

            Console.ReadKey();
        }
    }
}
