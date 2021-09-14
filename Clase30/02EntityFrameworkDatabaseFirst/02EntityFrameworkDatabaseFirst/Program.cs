using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            RegionConsola regionConsola = new RegionConsola();

            Console.WriteLine("******************************");
            Console.WriteLine("* ADMINISTRACION DE REGIONES *");
            Console.WriteLine("******************************");

            Console.WriteLine("1- Listar las regiones");
            Console.WriteLine("S- Salir de la aplicación");
            Console.WriteLine();
            Console.Write("Ingrese la opción seleccionada: ");

            string opcion = Console.ReadLine();

            switch (opcion.ToUpper().Trim())
            {
                case "1":
                    regionConsola.MostrarRegiones();
                    break;
                case "S":
                    break;
            }
            Console.ReadKey();
        }
    }
}
