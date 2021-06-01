using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EstructuraDeControl
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             OPERADORES DE COMPARACION

            == "Igualdad"
            != "Distinto"
            >  "Mayor"
            <  "Menor"
            >= "Mayor o igual"
            <= "Menor o igual"

            VALOR_A OPERADOR VALOR_B

            Siempre devuelve "true" en el caso de que la comparacion resulte verdadera
            Siempre devuelve "false" en el caso de que la comparacion resulte falsa
            */

            /*
             CONDICIONAL IF

            if(CONDICION) {
                //Aca va el codigo si la condicion es verdadera
            }else{
                //Aca va a ir el codigo que se ejecuta si la condicion es falsa
            }

             */

            int edad = 16;

            if(edad >= 18)
            {
                Console.WriteLine("Es mayor de 18 años");
            }
            else
            {
                Console.WriteLine("Es menor de 18 años");
            }


            /*
             BLOQUE IF - ELSE IF - ELSE

            if(CONDICION)
            {
            }
            else if (CONDICION2)
            {
            }
            else if (CONDICION3)
            {
            }
            else if (CONDICION4)
            {
            }
            else
            {
            }
            */

            string color = "Verde";

            if(color == "azul")
            {
                Console.WriteLine("El color es azul!!!");
            }
            else if(color == "rojo")
            {
                Console.WriteLine("El color es rojo!!!");
            }
            else if (color == "verde")
            {
                Console.WriteLine("El color es verde!!!");
            }
            else
            {
                Console.WriteLine("No es un color conocido");
            }

            /*
            
            OPERADORES LOGICOS

            && "y" logico

            || "o" logico

            !  "no" logico

            CONDICION OPERADOR CONDICION
             */

            int edadConcurso = 20;
            string pais = "argentina";

            if(edadConcurso >= 18 && pais == "argentina")
            {
                Console.WriteLine("Usted esta habilitado a participar");
            }

            Console.ReadKey();
        }
    }
}
