using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ: Language-INtegrated-Query

            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Apellido="Apellido3",Nombre="Nombre3",DNI= 3 },
                new Persona(){ Apellido="Apellido1",Nombre="Nombre1",DNI= 1 },
                new Persona(){ Apellido="Apellido4",Nombre="Nombre4",DNI= 4 },
                new Persona(){ Apellido="Apellido2",Nombre="Nombre2",DNI= 2 },
                new Persona(){ Apellido="Apellido5",Nombre="Nombre5",DNI= 5 },
                new Persona(){ Apellido="Apellido6",Nombre="Nombre6",DNI= 4 },
            };

            //SIN LINQ
            /*Persona persona = null;

            foreach (var item in personas)
            {
                if (item.DNI == 4)
                {
                    persona = item;
                }
            }*/

            //Busco las personas con DNI igual a 4 con sintaxis de metodo de extension
            var resultado = personas.Where(p => p.DNI == 4);

            foreach (var item in resultado)
            {
                Console.WriteLine(item.Apellido);
            }

            Console.WriteLine(resultado.Count());

            //Busco las personas con DNI igual a 4 con sintaxis de consulta
            var resultadoSintaxisConsulta = from p in personas
                                            where p.DNI == 4
                                            select p;

            foreach (var item in resultadoSintaxisConsulta)
            {
                Console.WriteLine(item.Apellido);
            }

            //Ordenar con sintaxis de metodo de extension
            var ordenado = personas.OrderBy(p => p.DNI);

            foreach (var item in ordenado)
            {
                Console.WriteLine(item.DNI + " "+item.Apellido);
            }

            //Ordenar con sintaxis de consulta

            var ordenadoConsulta = from p in personas
                                   orderby p.DNI
                                   select p;

            foreach (var item in ordenadoConsulta)
            {
                Console.WriteLine(item.DNI + " " + item.Apellido);
            }

            Console.ReadKey();
        }
    }
}
