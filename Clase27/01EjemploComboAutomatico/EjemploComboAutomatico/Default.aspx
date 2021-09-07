<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemploComboAutomatico.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="lstCursos" OnSelectedIndexChanged="lstCursos_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
            <asp:Label runat="server" ID="lblCursoSeleccionado"></asp:Label>
        </div>
    </form>
</body>
</html>
