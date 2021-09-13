using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PracticaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese el año para buscar en el catalogo de peliculas: ");
            string ingresoAño = Console.ReadLine();

            int año=0;
            try
            {
                año = Convert.ToInt32(ingresoAño);
            }
            catch
            {
                año = 0;
            }

            CatalogoPeliculas miCatalog = new CatalogoPeliculas();
            var listaPeliculas = miCatalog.ObtenerPorAñoConsulta(año);
            MostrarPeliculas(listaPeliculas);

            var listaPeliculasGenero = miCatalog.ObtenerPorGenero(5);
            MostrarPeliculas(listaPeliculasGenero);

            var listaPeliculasTitulo = miCatalog.BuscarPorTitulo("arma");
            MostrarPeliculas(listaPeliculasTitulo);

            miCatalog.MostrarTodasLasPeliculas();

            Console.ReadKey();
        }

        static void MostrarPeliculas(IEnumerable<Pelicula> peliculas)
        {
            Console.WriteLine("Listado de peliculas encontradas");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula);
            }
        }
    }
}
