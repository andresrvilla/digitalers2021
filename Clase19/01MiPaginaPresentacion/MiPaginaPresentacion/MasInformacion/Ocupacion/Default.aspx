<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.Ocupacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Programo muy duro, como un esclavo...<br />
    <asp:label runat="server" ID="lblContadorViewState">0</asp:label><br />
    <asp:Button runat="server" ID="btnContarViewState" CssClass="btn btn-primary" Text="Incrementar (ViewState)" OnClick="btnContarViewState_Click" />
    <hr />
</asp:Content>
