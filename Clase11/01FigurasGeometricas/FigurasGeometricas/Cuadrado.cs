using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    sealed class Cuadrado: Rectangulo //sealed en la clase indica que no se puede heredar de Cuadrado
    {

        // No tiene mucho sentido sealed a la clase y properties, es solo a modo educativo
        public sealed override int LadoA { get; set; }

        public sealed override int LadoB //sealed marca como que no se puede sobreescribir mas
        {
            get
            {
                return LadoA;
            }
            set
            {
                LadoA = value;
            }
        }
    }
}
