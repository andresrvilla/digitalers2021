using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Alumno: Persona //Con dos puntos declaro la herencia de clases (En esta caso)
    {
        
        private int anioNacimiento;

        public void SetAnioNacimiento(int anioNacimiento)
        {
            this.anioNacimiento = anioNacimiento;
        }

        public int ObtenerEdad()
        {
            DateTime ahora = DateTime.Now;
            return ahora.Year - anioNacimiento;
        }

        public int ObtenerEdad(int mesNacimiento)
        {
            int edadActual = ObtenerEdad();
            DateTime ahora = DateTime.Now;
            if (mesNacimiento > ahora.Month)
            {
                edadActual--;
            }

            return edadActual;
        }

        public override string ObtenerNombreObjeto()
        {
            return "Alumno";
        }
    }
}
