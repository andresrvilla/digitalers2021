<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="QuienSoy.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.QuienSoy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <h5>¿Quien soy?</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Aenean et tortor at risus viverra adipiscing at. Tincidunt eget nullam non nisi est sit. Elementum integer enim neque volutpat ac. Arcu cursus vitae congue mauris rhoncus aenean. Tincidunt tortor aliquam nulla facilisi. Suspendisse in est ante in nibh mauris. Accumsan sit amet nulla facilisi. Et tortor at risus viverra adipiscing at in tellus. At augue eget arcu dictum. Mi ipsum faucibus vitae aliquet. Non curabitur gravida arcu ac tortor dignissim convallis aenean.</p>

            <p>Integer enim neque volutpat ac tincidunt vitae semper. Quam viverra orci sagittis eu volutpat. Curabitur vitae nunc sed velit dignissim. Faucibus purus in massa tempor nec feugiat. Justo nec ultrices dui sapien. Tristique senectus et netus et malesuada fames ac turpis. Sed faucibus turpis in eu mi bibendum neque. Cras semper auctor neque vitae tempus quam pellentesque nec nam. Viverra orci sagittis eu volutpat odio facilisis mauris. Duis ultricies lacus sed turpis tincidunt id aliquet. Nec feugiat in fermentum posuere urna nec. Justo nec ultrices dui sapien eget mi proin. Eget est lorem ipsum dolor sit amet consectetur adipiscing. Vitae congue mauris rhoncus aenean. Nunc sed id semper risus in hendrerit gravida rutrum. Dolor sit amet consectetur adipiscing.</p>

            <p>Cursus in hac habitasse platea dictumst quisque sagittis purus. At imperdiet dui accumsan sit amet nulla facilisi morbi. Fringilla ut morbi tincidunt augue. Bibendum neque egestas congue quisque egestas diam in arcu cursus. Mauris pellentesque pulvinar pellentesque habitant. Purus gravida quis blandit turpis cursus in hac habitasse platea. Enim sed faucibus turpis in eu mi. Mollis nunc sed id semper risus in hendrerit gravida rutrum. Non blandit massa enim nec. Hendrerit gravida rutrum quisque non tellus orci ac auctor augue. In metus vulputate eu scelerisque felis imperdiet. Pellentesque pulvinar pellentesque habitant morbi tristique senectus et netus. Dolor magna eget est lorem.</p>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col">
            <asp:ListView runat="server" ID="lstComentarios">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="card" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Texto") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col">
            <%-- Tarea: Ver como hacer para que los elementos del formulario no abarquen
                todo el ancho. Pista: Usar las capacidades de la grilla (rows, cols) --%>
            <div class="form-group">
                <label>Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Comentario</label>
                <asp:TextBox runat="server" ID="txtComentario" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-success" Text="Agregar comentario" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
