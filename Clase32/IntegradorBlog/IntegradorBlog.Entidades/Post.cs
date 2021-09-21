using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorBlog.Entidades
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Resumen { get; set; }

        public string Contenido { get; set; }

        public string Autor { get; set; }

        public DateTime FechaDePublicacion { get; set; }

        public bool Destacada { get; set; }
    }
}
