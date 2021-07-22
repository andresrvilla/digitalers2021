using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion
{
    public partial class Default : System.Web.UI.Page
    {
        private List<string> proyectos;

        public Default()
        {
            //proyectos = new List<string>();
            //proyectos.Add("Pagina de presentación");
            //proyectos.Add("Blog");
            //proyectos.Add("Sitio de noticias");

            proyectos = new List<string>()
            {
                "Pagina de presentación",
                "Blog",
                "Sitio de noticias"
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lstProyectos.DataSource = proyectos;
            lstProyectos.DataBind();
        }
    }
}