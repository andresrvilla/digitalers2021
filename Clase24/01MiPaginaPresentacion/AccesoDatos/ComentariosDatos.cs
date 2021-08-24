using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ComentariosDatos
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-95LI9O3;Database=MiSitioPersonal;Trusted_Connection=True;");
        public ComentariosDatos()
        {
            //comentarios = new List<Comentario>();
        }

        public void AgregarComentario(Comentario comentario)
        {
            //comentarios.Add(comentario);
        }

       public List<Comentario> ObtenerComentarios()
        {
            string consulta = @"SELECT Id,Nombre,Texto 
                                FROM ComenTarios";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            conexion.Close();
        }

    }
}
