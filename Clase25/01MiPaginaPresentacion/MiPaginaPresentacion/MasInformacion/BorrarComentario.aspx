<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="BorrarComentario.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.BorrarComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlError" Visible="false" CssClass="alert alert-danger" role="alert">
        No se ha podido borrar ningun registro con los parametros enviados
    </asp:Panel>
</asp:Content>
