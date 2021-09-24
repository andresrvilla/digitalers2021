using IntegradorBlog.Datos.EntityFramework;
using IntegradorBlog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorBlog.Datos
{
    public class PosteosDatos
    {
        private DigitalersBlogEntities entities = new DigitalersBlogEntities();

        public List<Post> ObtenerPostsDestacados()
        {
            /*
             * Esto no lo puedo hacer, porque no existen "Convertir" como algo
             * que pueda traducir EF cuando ejecute la consulta.
             * Entonces, tengo que buscar otra forma de usar "Convertir"
             */
            //var query = entities.Posteos
            //                    .Where(p => p.Destacada == true)
            //                    .OrderByDescending(p => p.FechaDePublicacion)
            //                    .Take(2)
            //                    .Select(pdb => Convertir(pdb));

            // La solucion es en un primer paso obtener los "posteos" (que es el obj
            // que representa el registro de la bbbdd
            // y en un segundo paso convierto esos "posteos" a "posts" (que es el obj
            // de negocio

            // PASO 1: Selecciono los "Posteos" desde la base de datos
            var query = entities.Posteos
                    .Where(p => p.Destacada == true)
                    .OrderByDescending(p => p.FechaDePublicacion)
                    .Take(2);
            
            List<Posteos> lista = query.ToList();

            //Paso 2: Convierto los "Posteos" a "Posts"

            return lista.Select(pdb => Convertir(pdb)).ToList();
        }

        public List<Post> ObtenerPostPaginados(int numeroPagina, int tamañoPagina)
        {
            var query = entities.Posteos
                            .OrderByDescending(p => p.FechaDePublicacion)
                            .Skip((numeroPagina - 1) * tamañoPagina)
                            .Take(tamañoPagina);
            
            List<Posteos> lista = query.ToList();

            return lista.Select(pdb => Convertir(pdb)).ToList();
        }

        private Post Convertir(Posteos pdb)
        {
            return new Post()
            {
                Id = pdb.Id,
                Titulo = pdb.Titulo,
                Resumen = pdb.Resumen,
                Contenido = pdb.Contenido,
                Autor = pdb.Autor,
                Destacada = pdb.Destacada,
                FechaDePublicacion = pdb.FechaDePublicacion
            };
        }


    }
}
