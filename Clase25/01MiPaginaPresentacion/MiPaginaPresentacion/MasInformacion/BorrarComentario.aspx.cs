using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class BorrarComentario : System.Web.UI.Page
    {
        ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (string.IsNullOrWhiteSpace(id))
            {
                pnlError.Visible = true;
            }
            else
            {
                //borrar
                int idEntero = Convert.ToInt32(id);
                bool resultado = comentarioNegocio.BorrarComentario(idEntero);
                if (resultado == true)
                {
                    Response.Redirect("~/MasInformacion/QuienSoy.aspx");
                }
                else
                {
                    pnlError.Visible = true;
                }
            }
        }
    }
}