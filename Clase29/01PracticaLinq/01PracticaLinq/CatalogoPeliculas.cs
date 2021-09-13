using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PracticaLinq
{
    class CatalogoPeliculas
    {
        public List<Pelicula> Peliculas { get; private set; }

        public CatalogoPeliculas()
        {
            Peliculas = new List<Pelicula>();
            InicializarListaPeliculas();
        }

        private void InicializarListaPeliculas()
        {
            Genero terror = new Genero()
            {
                Id = 1,
                Nombre = "Terror"
            };
            Genero comico = new Genero()
            {
                Id = 2,
                Nombre = "Comico"
            };
            Genero policial = new Genero()
            {
                Id = 3,
                Nombre = "Policial"
            };
            Genero cienciaFiccion = new Genero()
            {
                Id = 4,
                Nombre = "Ciencia Ficción"
            };
            Genero otros = new Genero()
            {
                Id = 5,
                Nombre = "Otros"
            };

            Peliculas.Add(new Pelicula()
            {
                Id=1,
                Titulo="Anabelle",
                Año=2012,
                Director="Tomas Perez",
                Clasico=false,
                Genero=terror
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 2,
                Titulo = "Viernes 13",
                Año = 1985,
                Director = "Tomas Perez",
                Clasico = true,
                Genero = terror
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 3,
                Titulo = "El exorcista",
                Año = 1988,
                Director = "Juan Lopez",
                Clasico = true,
                Genero = terror
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 4,
                Titulo = "Freddy",
                Año = 1975,
                Director = "Juan Lopez",
                Clasico = true,
                Genero = terror
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 5,
                Titulo = "Rapido y Furioso",
                Año = 2008,
                Director = "Guillermo del Toro",
                Clasico = false,
                Genero = otros
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 6,
                Titulo = "Duro de matar 4",
                Año = 1996,
                Director = "Guillermo del Toro",
                Clasico = true,
                Genero = otros
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 7,
                Titulo = "Arma mortal",
                Año = 1996,
                Director = "Guillermo del Toro",
                Clasico = true,
                Genero = policial
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 8,
                Titulo = "Bad Boys",
                Año = 1996,
                Director = "Juan Lopez",
                Clasico = true,
                Genero = policial
            });
            Peliculas.Add(new Pelicula()
            {
                Id = 9,
                Titulo = "Avatar",
                Año = 2012,
                Director = "Batman",
                Clasico = false,
                Genero = null
            });
        }

        public IEnumerable<Pelicula> ObtenerPorAño(int año)
        {
            return Peliculas
                .Where(peli => peli.Año == año)
                .OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula> ObtenerPorAñoConsulta(int año)
        {
            return from p in Peliculas
                   where p.Año == año
                   orderby p.Titulo
                   select p;
        }

        public IEnumerable<Pelicula> ObtenerPorGenero(int genero)
        {
            return Peliculas
                //.Where(peli => peli.Genero!=null && peli.Genero.Id == genero)
                .Where(peli =>  peli.Genero?.Id == genero)
                .OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula> BuscarPorTitulo(string busqueda)
        {
            return Peliculas
                .Where(peli => peli.Titulo.ToUpper().Contains(busqueda.ToUpper()))
                .OrderBy(peli => peli.Titulo);
        }

        public void MostrarTodasLasPeliculas()
        {
            var resultado = from p in Peliculas
                   orderby p.Titulo
                   select new { p.Titulo, p.Año };

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titulo: {item.Titulo}, Año: {item.Año}");
            }
        }

        public void MostrarTodasLasPeliculasConClasePeliculaResumen()
        {
            var resultado = from p in Peliculas
                            orderby p.Titulo
                            select new PeliculaResumen() { Titulo= p.Titulo, Año = p.Año };

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titulo: {item.Titulo}, Año: {item.Año}");
            }
        }
    }
}
