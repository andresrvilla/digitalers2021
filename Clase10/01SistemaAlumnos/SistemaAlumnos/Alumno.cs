using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Alumno
    {
        private string apellido;

        public void SetApellido(string elApellido)
        {
            apellido = elApellido;
        }

        public string GetApellido()
        {
            return apellido;
        }

        private string nombre;

        public void SetNombre(string elNombre)
        {
            nombre = elNombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        private int anioNacimiento;

        public void SetAnioNacimiento(int anioNacimiento)
        {
            this.anioNacimiento = anioNacimiento;
        }

        /*
         * public
         * protected
         * private
         */
        public string ObtenerNombreCompleto()
        {
            return $"{nombre} {apellido}";
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

        public string ObtenerSaludoFormal(string prefijo)
        {
            return $"{prefijo} {apellido}, {nombre}";
        }
    }
}
