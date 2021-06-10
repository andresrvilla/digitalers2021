using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidimensionalesYMatrices
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array de Arrays
            int[][] multi = new int[3][];

            int[] filaUno = new int[] { 4, 8, 41, 7, 6 };
            multi[0] = filaUno;

            int[] filaDos = new int[] { 2, 3, 5 };
            multi[1] = filaDos;

            int[] filaTres = new int[] { 4, 5, 6, 8 };
            multi[2] = filaTres;

            // Estructura multidimensional (matrices)
            int[,] matriz = new int[3,3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 3;
            matriz[0, 2] = 7;
            matriz[1, 0] = 1;
            matriz[1, 1] = 3;
            matriz[1, 2] = 7;
            matriz[2, 0] = 1;
            matriz[2, 1] = 3;
            matriz[2, 2] = 7;

            string[,] personas = new string[3, 2];
            personas[0, 0] = "Suarez";
            personas[0, 1] = "Anibal";
            personas[1, 0] = "Diaz";
            personas[1, 1] = "Felipe";
            personas[2, 0] = "Gonzalez";
            personas[2, 1] = "Laura";

            for(int i = 0; i < personas.GetLongLength(0); i++)
            {
                for(int j = 0; j < personas.GetLongLength(1); j++)
                {
                    Console.WriteLine(personas[i, j]);
                }
                
            }

            Console.ReadKey();
        }
    }
}
