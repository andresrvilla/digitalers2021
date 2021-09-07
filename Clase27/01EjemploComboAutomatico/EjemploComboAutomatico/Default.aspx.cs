using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploComboAutomatico
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(IsPostBack == false)
            if(!IsPostBack)
            {
                ListItem curso0 = new ListItem("Seleccione", "0");
                lstCursos.Items.Add(curso0);
                ListItem curso1 = new ListItem("CSharp", "1");
                lstCursos.Items.Add(curso1);
                ListItem curso2 = new ListItem("Javascript", "2");
                lstCursos.Items.Add(curso2);
                ListItem curso3 = new ListItem("SQL", "3");
                lstCursos.Items.Add(curso3);
            }
        }

        protected void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCursoSeleccionado.Text = lstCursos.SelectedValue;
        }
    }
}