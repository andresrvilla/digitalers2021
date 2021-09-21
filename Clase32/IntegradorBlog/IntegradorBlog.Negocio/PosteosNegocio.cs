using IntegradorBlog.Datos;
using IntegradorBlog.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorBlog.Negocio
{
    public class PosteosNegocio
    {
        private PosteosDatos posteosDatos = new PosteosDatos();

        public List<Post> ObtenerPosteosDestacados()
        {
            return posteosDatos.ObtenerPostsDestacados();
        }
    }
}
