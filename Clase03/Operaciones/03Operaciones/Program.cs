using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 unEntero;
            int unEntero;
            long unValorLargo = 101023010240123;
            Console.WriteLine(unValorLargo);

            char unaLetra = 'x';

            double valorDouble = 10.5;
            
            float valorSingle = 10.5F;
            
            double otroDouble = 10.5F;

            /*
             * F - float 
             * L - long
             * l - ulong
             * D - double
             * M - decimal
             */

            Console.WriteLine(unaLetra);

            Console.WriteLine("Operadores Aritmeticos");
            /*
             * Operadores Aritmeticos
             */

            // <VALOR UNO> <OPERADOR> <VALOR DOS>
            /*
             * + SUMA
             * - RESTA
             * * MULTIPLICACION
             * / DIVISION
             * % MODULO
             */


            var resultadoSuma = 1 + 5;

            var resultadoResta = 100 - resultadoSuma;

            Console.WriteLine(resultadoResta);


            int resultadoModulo = 100 % 3;

            Console.WriteLine(resultadoModulo);


            /*
             * OPERACIONES DE ASIGNACION
             */
            Console.WriteLine("OPERACIONES DE ASIGNACION");

            int numeroUno = 100;

            Console.WriteLine(numeroUno);

            numeroUno = 1;

            Console.WriteLine(numeroUno);
            
            numeroUno = numeroUno + 1;
            //es equivalente a
            numeroUno++;

            Console.WriteLine(numeroUno);

            numeroUno = numeroUno + 5;
            //es equivalente a 
            numeroUno += 5;

            Console.WriteLine(numeroUno);
            numeroUno--; // Este resta uno y lo asigna a la misma variable
            numeroUno -= 5; // este resta 5 y lo asigna a la misma variable
            Console.WriteLine(numeroUno);

            // tenemos *=
            // tenemos el /=
            // tenemos el %=

            Console.WriteLine(numeroUno);

            string textoUno = "Hola ";
            string textoDos = "mundo";

            Console.WriteLine(textoUno + textoDos+ " "+ 367);

            string textoIngresado = "35";

            int textoConvertido = Convert.ToInt32(textoIngresado);

            Console.WriteLine(textoConvertido + 10);

            Console.ReadKey();
        }
    }
}
