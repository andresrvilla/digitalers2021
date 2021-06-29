using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    static class Matematica
    {
        public static int CantidadOperaciones { get; set; }

        public static int Suma(int a, int b)
        {
            Matematica.CantidadOperaciones++;
            return a + b;
        }

        public static void HacerAlgo()
        {

        }
    }
}
