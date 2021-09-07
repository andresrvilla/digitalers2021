using Entidades;
using Entidades.Excepciones;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ComentariosDatos
    {
        private string cadena = ConfigurationManager.ConnectionStrings["PaginaPresentacionDB"].ConnectionString;

        public ComentariosDatos()
        {
        }

        public bool AgregarComentario(Comentario comentario)
        {
            string consulta = $@"INSERT INTO Comentarios(Nombre,Texto)
                    VALUES ('{comentario.Nombre}','{comentario.Texto}')
                    ";
            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    resultado = comando.ExecuteNonQuery();
                }
            }

            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Comentario> ObtenerComentarios()
        {
            List<Comentario> resultado = new List<Comentario>();

            string consulta = @"SELECT Id,Nombre,Texto 
                                FROM ComenTarios";


            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Comentario comentario = new Comentario()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Texto = reader["Texto"].ToString()
                        };

                        resultado.Add(comentario);
                    }
                }
                catch(SqlException ex)
                {
                    //Puedo hacer algo con la excepcion, por ejemplo guardar el mensaje en un archivo de log
                    throw new CapaDeDatosException();
                }

            }



            return resultado;
        }

        public bool BorrarComentario(int id)
        {
            string consulta = $@"DELETE FROM Comentarios
                                WHERE Id={id}";

            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }

            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarComentario(Comentario comentario)
        {
            string consulta = $@"UPDATE Comentarios
                                SET Nombre='{comentario.Nombre}', Texto='{comentario.Texto}'
                                WHERE Id={comentario.Id}";

            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }

            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Comentario ObtenerComentario(int id)
        {
            Comentario resultado = null;

            string consulta = $@"SELECT Id,Nombre,Texto 
                                FROM ComenTarios WHERE Id={id}";

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    resultado = new Comentario()
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Texto = reader["Texto"].ToString()
                    };
                }
            }


            return resultado;
        }
    }
}
