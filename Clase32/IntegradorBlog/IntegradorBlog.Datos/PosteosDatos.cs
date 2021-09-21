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
            List<Post> resultado;

            var query = entities.Posteos
                                .Where(p => p.Destacada == true)
                                .OrderByDescending(p => p.FechaDePublicacion)
                                .Take(2)
                                .Select(pdb => new Post()
                                {
                                    Id = pdb.Id,
                                    Titulo = pdb.Titulo,
                                    Resumen = pdb.Resumen,
                                    Contenido = pdb.Contenido,
                                    Autor = pdb.Autor,
                                    Destacada = pdb.Destacada,
                                    FechaDePublicacion = pdb.FechaDePublicacion
                                });

            return query.ToList();
        }
    }
}
