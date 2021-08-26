using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasterPages
{
    public partial class Sitio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                lblNombrePersona.Text = ConfigurationManager.AppSettings["NombrePersona"] ?? "(DEFINIR NombrePersona en Web.Config)";
            }
        }
    }
}