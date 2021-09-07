using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelegados
{
    class Program
    {
        delegate int Operacion(int A, int B);

        static int Suma(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }

        static int Resta(int numeroUno, int numeroDos)
        {
            return numeroUno - numeroDos;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un primer numero:");
            string valorUno = Console.ReadLine();
            Console.Write("Ingrese un segundo numero:");
            string valorDos = Console.ReadLine();

            int numeroUno = Convert.ToInt32(valorUno);
            int numeroDos = Convert.ToInt32(valorDos);

            Console.Write("Ingrese la operación que quiere realizar: (S)uma o (R)esta:");
            string opcion = Console.ReadLine().ToUpper();

            Operacion operacion = delegate(int a, int b)
            {
                Console.WriteLine(" [No se ha seleccionado una operación válida] ");
                return 0;
            };

            switch (opcion)
            {
                case "S":
                    operacion= Suma;
                    break;
                case "R":
                    operacion = Resta;
                    break;
            }

            int resultado = operacion(numeroUno, numeroDos);
            Console.WriteLine($"El resultado de la operacion es {resultado}");
            Console.ReadKey();
        }
    }
}
