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
            alumno.SetNombre("Andres");
            //alumno.apellido = "Villa";
            alumno.SetApellido("Villa");
            alumno.SetAnioNacimiento(1984);

            Console.WriteLine(alumno.ObtenerNombreCompleto());
            Console.WriteLine(alumno.ObtenerSaludoFormal("Sr"));
            Console.WriteLine(alumno.ObtenerSaludoFormal("Ing"));
            Console.WriteLine(alumno.ObtenerEdad(12));

            Alumno otroAlumno = new Alumno();
            otroAlumno.SetNombre("Pedro");
            otroAlumno.SetApellido("Suarez");
            otroAlumno.SetAnioNacimiento(2003);

            Console.WriteLine(otroAlumno.ObtenerNombreCompleto());
            Console.WriteLine(otroAlumno.ObtenerSaludoFormal("Sr"));
            Console.WriteLine(otroAlumno.ObtenerSaludoFormal("Ing"));
            Console.WriteLine(otroAlumno.ObtenerEdad());

            Instructor elInstructor = new Instructor();
            elInstructor.Apellido = "Villa";
            elInstructor.Nombre = "";

            Console.WriteLine(elInstructor.NombreCompleto);

            Curso elCurso = new Curso("C#!");

            elCurso.ElInstructor = elInstructor;
            elCurso.Nombre = "C#";
            elCurso.Alumnos = new List<Alumno>();
            elCurso.Alumnos.Add(alumno);
            elCurso.Alumnos.Add(otroAlumno);

            Curso otroCurso = new Curso();

            Console.ReadKey();
        }
    }
}
