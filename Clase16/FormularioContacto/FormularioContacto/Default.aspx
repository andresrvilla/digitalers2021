<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormularioContacto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Nombre</label><br />
            <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox><br />
            <label>Apellido</label><br />
            <asp:TextBox runat="server" id="txtApellido"></asp:TextBox><br />
            <label>Mail</label><br />
            <asp:TextBox runat="server" ID="txtMail"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnGuardar" Text="Enviar Datos" OnClick="btnGuardar_Click" /><br />
            <asp:Label runat="server" ID="lblMensaje"></asp:Label>
        </div>
    </form>
</body>
</html>
