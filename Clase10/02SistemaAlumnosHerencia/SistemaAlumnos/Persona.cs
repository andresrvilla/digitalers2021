using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    abstract class Persona
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }

        public virtual string ObtenerSaludoFormal(string prefijo)
        {
            return $"{prefijo} {Apellido}, {Nombre}";
        }

        public abstract string ObtenerNombreObjeto();
    }
}
