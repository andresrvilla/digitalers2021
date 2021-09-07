using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Entidades.Excepciones;
using Negocio;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class QuienSoy : System.Web.UI.Page
    {
        private static ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        public QuienSoy()
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Esto no es necesario porque lo reemplazo por las clases de
            // la arquitectura en capas
            //if (ViewState["comentarios"] == null)
            //{
            //    comentarios = new List<Comentario>();
            //    ViewState["comentarios"] = comentarios;
            //}
            //else
            //{
            //    comentarios = (List<Comentario>)ViewState["comentarios"];
            //}
            try
            {
                lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();
                lstComentarios.DataBind();
            }
            catch(CapaDeDatosException ex)
            {
                lblError.Text = "Ocurrio un error al pedir los comentarios:";
                pnlError.Visible = true;
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            //El "tipo de dato var"
            //En realidad es un tipo de dato especifico pero lo toma de la asignacion
            var comentario = txtComentario.Text;

            Comentario nuevoComentario = new Comentario()
            {
                Nombre = nombre,
                Texto = comentario
            };

            bool resultado = comentarioNegocio.GuardarComentario(nuevoComentario);
            //podria validar si se guardo o no. Si no se guardo, muestro un error
            //si se guardo, vacio los campos

            txtComentario.Text = "";
            txtNombre.Text = "";

            lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();
            lstComentarios.DataBind();
        }
    }
}