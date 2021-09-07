using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClaseGenerica<string> miObjetoGenerico = new MiClaseGenerica<string>();
            string valor = "Hola que tal";
            miObjetoGenerico.Mostrar(valor);
            miObjetoGenerico.OtroMostrar<string>(valor);

            MiClaseGenerica<DateTime> miOtroObjetoGenerico = new MiClaseGenerica<DateTime>();
            DateTime ahora = DateTime.Now;
            miOtroObjetoGenerico.Mostrar(ahora);
            miOtroObjetoGenerico.OtroMostrar<string>("Hola");

            Console.ReadKey();
        }
    }
}
