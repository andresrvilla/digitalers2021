using MiPaginaPresentacion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class QuienSoy : System.Web.UI.Page
    {
        private List<Comentario> comentarios;

        public QuienSoy()
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["comentarios"] == null)
            {
                comentarios = new List<Comentario>();
                ViewState["comentarios"] = comentarios;
            }
            else
            {
                comentarios = (List<Comentario>)ViewState["comentarios"];
            }

            lstComentarios.DataSource = comentarios;
            lstComentarios.DataBind();
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

            comentarios.Add(nuevoComentario);
            ViewState["comentarios"] = comentarios;

            txtComentario.Text = "";
            txtNombre.Text = "";

            lstComentarios.DataBind();
        }
    }
}