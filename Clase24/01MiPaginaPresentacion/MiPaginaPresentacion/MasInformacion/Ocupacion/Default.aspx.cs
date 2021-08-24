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
            if (IsPostBack == false) // (!IsPostBack)
            {
                if (Session["contador"] != null)
                {
                    lblContadorSession.Text = Session["contador"].ToString();
                }
                if (Request.Cookies["contador"] != null)
                {
                    lblContadorCookies.Text = Request.Cookies["contador"].Value;
                }
            }
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

        protected void btnContarSession_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (Session["contador"] != null)
            {
                contador = (int)Session["contador"];
            }
            contador++;
            Session["contador"] = contador;
            lblContadorSession.Text = contador.ToString();
        }

        protected void btnContadorCookies_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (Request.Cookies["contador"] != null)
            {
                contador = Convert.ToInt32(Request.Cookies["contador"].Value);
            }
            contador++;
            Response.Cookies["contador"].Value = contador.ToString();
            Response.Cookies["contador"].Expires = DateTime.Now.AddMinutes(1);
            lblContadorCookies.Text = contador.ToString();
        }
    }
}