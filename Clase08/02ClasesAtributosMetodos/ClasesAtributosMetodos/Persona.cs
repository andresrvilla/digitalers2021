using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAtributosMetodos
{
    class Persona
    {
        /*
         * MODIFICADORES DE VISIBILIDAD
         * 
         * protected (o no ponerle nada): Tiene que ver con el mecanismo de herencia.
         *           Hasta no ver herencia lo podemos considerar como "privado"
         * private: Solo se puede ver el valor desde la misma clase
         * public: se peude acceder desde cualquier lado
         */

        /*
         * VISIBILIDAD TIPO_DATO NOMBRE = VALOR;
         */
        public string apellido = "Sin definir";

        public string nombre;

        public int edad;
    }
}
