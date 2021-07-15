using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola Mundo!!!";
            lblConfidencial.Visible = false;
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludoPersona.Text = "Hola " + txtNombre.Text;
        }
    }
}