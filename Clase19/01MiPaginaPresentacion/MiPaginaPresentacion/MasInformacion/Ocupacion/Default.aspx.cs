using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion.Ocupacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContarViewState_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (ViewState["contador"] != null)
            {
                contador = (int)ViewState["contador"];
            }
            contador++;
            ViewState["contador"] = contador;
            lblContadorViewState.Text = contador.ToString();
        }
    }
}