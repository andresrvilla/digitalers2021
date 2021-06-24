using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Instructor: Persona
    {
        public override string ObtenerSaludoFormal(string prefijo)
        {
            return $"Instructor {Apellido},{Nombre}";
        }

        public override string ObtenerNombreObjeto()
        {
            return "Instructor";
        }
    }
}
