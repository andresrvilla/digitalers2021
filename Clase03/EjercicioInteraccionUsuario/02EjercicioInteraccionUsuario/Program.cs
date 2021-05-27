using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EjercicioInteraccionUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Su nombre es {0} y tiene {1} años",nombre,edad);
            Console.WriteLine("Edad: {0}", edad);

            const string marca = "EducacionIT";

            Console.WriteLine("Su nombre es {0}{0} y tiene {1} años. Bienvenidos al curso dictado por {2}", nombre, edad, marca);

            Console.ReadKey();
        }
    }
}
