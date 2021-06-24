using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan";
            alumno.Apellido ="Suarez";
            alumno.SetAnioNacimiento(1984);

            Instructor elInstructor = new Instructor();
            elInstructor.Apellido = "Villa";
            elInstructor.Nombre = "Andres";

            Console.WriteLine(alumno.ObtenerSaludoFormal("Sr"));
            Console.WriteLine(elInstructor.ObtenerSaludoFormal("Mr"));

            Persona p = new Persona();

            Console.ReadKey();
        }
    }
}
