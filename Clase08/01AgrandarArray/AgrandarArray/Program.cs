using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgrandarArray
{
    class Program
    {
        static int[] agregar(int[] arreglo, int valorNuevo)
        {
            // Creo un array que tiene 1 mas de capacidad que el que me pasan por parametro
            int[] resultado = new int[arreglo.Length + 1];

            //agregar todos los elementos del arreglo anterior
            for (int i = 0; i < arreglo.Length; i++)
            {
                resultado[i] = arreglo[i];
            }
            //agrego el nuevo elemento
            resultado[resultado.Length - 1] = valorNuevo;
            //retorno el nuevo array con el elemento agregado
            return resultado;
        }

        static void Main(string[] args)
        {
            int[] miArray = new[] { 3, 7, 8, 4, 1 };
            Console.WriteLine(miArray.Length);
            miArray = agregar(miArray, 17);
            // creo el algoritmo
            Console.WriteLine(miArray.Length);

            int miNumero = 100;
            //string texto = "Mi numero es " + miNumero;
            // Puedo ponerlo como "string interpolation"
            string texto = $"Mi numero es {miNumero}";
            Console.WriteLine(texto);
            porReferencia(ref miNumero);
            texto = $"Mi numero es {miNumero}";
            Console.WriteLine(texto);

            Console.ReadKey();
        }

        static void porReferencia(ref int valor)
        {
            valor = 77;
        }

    }
}
