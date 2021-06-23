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

            Console.ReadKey();
        }
    }
}
