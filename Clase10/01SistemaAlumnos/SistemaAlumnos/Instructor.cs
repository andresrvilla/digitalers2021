using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Instructor
    {

        // Esta es la forma "tradicional" de encapsular
        //private string apellido;

        //public void SetApellido(string apellido)
        //{
        //    this.apellido = apellido;
        //}

        //public string GetApellido()
        //{
        //    return apellido;
        //}

        //Las lineas anteriores son equivalentes a:
        //Este miembro se llama "Property"
        public string Apellido { get; set; }

        // Esta es la forma "tradicional" de encapsular
        //private string nombre;

        //public void SetNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}

        //public string GetNombre()
        //{
        //    return nombre;
        //}

        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == "")
                {
                    nombre = "SIN_DEFINIR";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }

        private string ejemplo;

        public string Ejemplo
        {
            get
            {
                return ejemplo;
            }
            private set
            {
                ejemplo = value;
            }
        }

        private string OtroEjemplo { get; }

    }
}
