using IntegradorBlog.Entidades;
using IntegradorBlog.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntegradorBlog
{
    public partial class _Default : Page
    {
        private PosteosNegocio posteosNegocio = new PosteosNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Post> destacados = posteosNegocio.ObtenerPosteosDestacados();
                Post primero = destacados[0];
                lblTituloDestacadoUno.Text = primero.Titulo;
                Post segundo = destacados[1];
                lblTituloDestacadoDos.Text = segundo.Titulo;

                
            }
            
        }
    }
}