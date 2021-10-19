<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntegracionJavascriptNetFramework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Error al validar formulario</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Los datos son incorrectos, por favor revise y vuelva a intentarlo:<br />
                    Campos incorrectos: <br />
                    <span id="spnCamposIncorrectos"></span>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>

    <script>

        function validarFormulario() {
            var nombre = $("#<%=txtNombre.ClientID %>").val();
            var apellido = $("#<%=txtApellido.ClientID %>").val();
            var documento = $("#<%=txtDocumento.ClientID %>").val();

            if (nombre == "" || apellido == "" || documento == "") {
                var camposIncorrectos = "";

                if (nombre == "") {
                    camposIncorrectos += "Nombre,"
                }
                if (apellido == "") {
                    camposIncorrectos +="Apellido,"
                }
                if (documento == "") {
                    camposIncorrectos +="Documento"
                }

                $("#spnCamposIncorrectos").text(camposIncorrectos);

                $("#exampleModal").modal("show");
                return false;
            } else {
                return true;
            }
        }
    </script>

    Nombre:
    <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre"></asp:TextBox><br />
    Apellido:
    <asp:TextBox runat="server" CssClass="form-control" ID="txtApellido"></asp:TextBox><br />
    Documento:
    <asp:TextBox runat="server" ID="txtDocumento" CssClass="form-control"></asp:TextBox>

    <asp:Button runat="server" ID="btnEnviar" CssClass="btn btn-primary" Text="Registrarse"
        OnClick="btnEnviar_Click" OnClientClick="return validarFormulario()" />
</asp:Content>
