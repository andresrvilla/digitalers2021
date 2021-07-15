<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HolaMundo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>Prueba de trabajo en el servidor</span><br />
            <% 
                int i = 100;
                Response.Write("<b>"+i+"</b>");
            %>
            <br />
            <asp:Label runat="server" ID="lblSaludo"></asp:Label><br />
            <asp:Label runat="server" ID="lblConfidencial">Mi TC es 1231241231</asp:Label><br />
            <hr />
            <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click" /><br />
            <asp:Label runat="server" ID="lblSaludoPersona" CssClass="cualquierclase"></asp:Label>
        </div>
    </form>
</body>
</html>
