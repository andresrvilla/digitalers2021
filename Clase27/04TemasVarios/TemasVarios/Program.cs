using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * INFERIR TIPO DE DATOS DEL VALOR ASIGNADO
             */
            string unTexto = "Un Texto";
            var otroTexto = "Otro Texto";
            //otroTexto = 10; No puedo cambiar el tipo de dato que acepta
            var unEntero = 10;

            //var noPuedo; Necesito si o si ponerle un valor para que entienda de que tipo es la variable

            /*
             * TIPOS ANONIMOS
             */

            var miObjetoAnonimo = new
            {
                Nombre = "Andres",
                Apellido = "Villa",
                Edad= 10
            };

            var miOtroObjetoAnonimo = new
            {
                Raza = "Caniche",
                Nombre = "Toby"
            };

            MiClaseParcial objeto = new MiClaseParcial();
        }

        partial class MiClaseParcial
        {
            public void MetodoUno()
            {
                Console.WriteLine("MetodoUno");
            }
        }

        partial class MiClaseParcial
        {
            public void MetodoDos()
            {
                Console.WriteLine("MetodoDos");
            }
        }
    }
}
