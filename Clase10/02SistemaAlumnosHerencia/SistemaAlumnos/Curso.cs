using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Curso
    {
        public string Nombre { get; set; }

        public Instructor ElInstructor { get; set; }

        public List<Alumno> Alumnos { get; set; }

        public Curso()
        {
            Nombre = "Curso Sin Nombre";
        }

        public Curso(string nombre)
        {
            Nombre = nombre;
        }
    }
}
