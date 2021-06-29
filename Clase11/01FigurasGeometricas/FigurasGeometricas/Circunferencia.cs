using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circunferencia : FiguraGeometrica, IGuardable
    {
        public override string Tipo => "Circunferencia";

        public int Radio { get; set; }

        /*
        public int Diametro
        {
            get
            {
                return 2 * Radio;
            }
        }
        */

        //Es equivalente a

        public int Diametro => 2 * Radio;

        public string NombreArchivo { get; set; }


        //En estos dos calculos pongo el convert para hacerlo rapido,
        //En realidad debería corregir los metodos devuelval double (numero decimal)
        public override int Area()
        {
            return Convert.ToInt32(Math.PI * Radio * Radio);
        }

        public void Guardar()
        {
            Console.WriteLine("Guardar");
        }

        public override int Perimetro()
        {
            return Convert.ToInt32(2 * Math.PI * Radio);
        }
    }
}
