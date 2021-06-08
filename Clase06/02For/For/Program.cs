using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            for(A;B;C){
                //Este es el codigo que se repite
            }

            A: definicion de la variable de control
            B: condicion de continuidad
            C: cambio de la variable de control
            */

            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Empiece a contar en 10
            //Cuente de 2 en dos
            //Llegue al 50
            for (int i=10;i<=50;i+=2)
            {
                Console.WriteLine("De dos en dos hasta 50 numero "+i);
            }

            // i = i+2;
            // i += 2;
            // i+2

            //cuente de 10 a 0
            for(int i = 10; i >= 10; i--)
            {
                Console.WriteLine("De 10 a cero: " + i)
;            }

            Console.ReadKey();
        }
    }
}
