using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Rectangulo : FiguraGeometrica
    {
        public override string Tipo => "Rectangulo";

        public virtual int LadoA { get; set; }

        public virtual int LadoB { get; set; }

        public override int Area()
        {
            return LadoA * LadoB;
        }

        public override int Perimetro()
        {
            return 2 * LadoA + 2 * LadoB;
        }
    }
}
