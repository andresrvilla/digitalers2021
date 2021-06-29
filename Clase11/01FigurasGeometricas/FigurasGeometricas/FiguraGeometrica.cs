using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    abstract class FiguraGeometrica
    {
        public static double PI => Math.PI;

        public virtual string Tipo => "Figura Geometrica";

        public abstract int Area();

        public abstract int Perimetro();
    }
}
