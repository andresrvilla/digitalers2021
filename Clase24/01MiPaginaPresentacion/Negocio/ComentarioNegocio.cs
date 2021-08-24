using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComentarioNegocio
    {
        private ComentariosDatos comentariosDatos = new ComentariosDatos();

        public bool GuardarComentario(Comentario comentario)
        {
            bool resultado = false;

            /*
             * string texto = "Hola";
             * texto != ""
             * string.isNullOrWhiteSpace(texto)
             * valida si es: null, vacio o esta compuesto solo por espacios
             */

            if (string.IsNullOrWhiteSpace(comentario.Nombre) == false && 
                string.IsNullOrWhiteSpace(comentario.Texto) == false)
            {
                comentariosDatos.AgregarComentario(comentario);
                resultado = true;
            }

            return resultado;
        }

        public List<Comentario> ObtenerComentarios()
        {
            return comentariosDatos.ObtenerComentarios();
        }
    }
}
