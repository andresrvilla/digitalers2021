using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioContacto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                txtNombre.Text = "Ingrese su nombre";
                txtApellido.Text = "Ingrese su apellido";
                txtMail.Text = "Ingrese su mail";
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string misDatos = $"Nombre: {txtNombre.Text}, Apellido: {txtApellido.Text}, Mail: {txtMail.Text}{Environment.NewLine}";

            //Sobreescribe el archivo
            //File.WriteAllText("d:\\registros.txt", misDatos);
            File.AppendAllText("d:\\registros.txt", misDatos);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMail.Text = "";

            lblMensaje.Text = "Los datos han sido guardados exitosamente";
        }
    }
}