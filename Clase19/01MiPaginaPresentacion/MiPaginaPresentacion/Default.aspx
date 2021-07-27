<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiPaginaPresentacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-8">
            <h5>¿Quien soy?</h5>
            <div class="row">
                <div class="col-md-6">
                    <img class="img-fluid" src="imgs/myAvatar.png"  />
                </div>
                <div class="col-md-6">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Laoreet id donec ultrices tincidunt arcu non sodales neque. Semper viverra nam libero justo laoreet sit amet cursus sit. Massa massa ultricies mi quis hendrerit dolor. Arcu vitae elementum curabitur vitae nunc. Ac turpis egestas integer eget aliquet. Purus ut faucibus pulvinar elementum integer enim. Viverra maecenas accumsan lacus vel facilisis. Aliquet nibh praesent tristique magna. Tincidunt augue interdum velit euismod in pellentesque.</p>
                    <%--<a href="MasInformacion/QuienSoy.aspx" class="btn btn-info">Leer Más</a>--%>
                    <asp:button runat="server" ID="btnRedirigirQuienSoy" Text="Leer Más" CssClass="btn btn-info" OnClick="btnRedirigirQuienSoy_Click" />
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <h5>¿A que me dedico?</h5>
            <p>Eleifend donec pretium vulputate sapien nec sagittis. Tempor commodo ullamcorper a lacus vestibulum. Dictum sit amet justo donec enim diam vulputate ut. Ullamcorper sit amet risus nullam eget. Rutrum quisque non tellus orci ac auctor. Nunc id cursus metus aliquam eleifend mi in. Sit amet nulla facilisi morbi tempus. Suspendisse potenti nullam ac tortor vitae purus faucibus ornare. Nibh mauris cursus mattis molestie. Mauris cursus mattis molestie a iaculis at erat. Quisque sagittis purus sit amet volutpat consequat. Faucibus interdum posuere lorem ipsum dolor. Justo eget magna fermentum iaculis. Tincidunt eget nullam non nisi est sit amet facilisis. Vel fringilla est ullamcorper eget nulla facilisi etiam dignissim.</p>
            <a href="MasInformacion/Ocupacion/Default.aspx" class="btn btn-info">Leer Más</a>
        </div>
    </div>
    <div class ="row">
        <div class="col">
            <h5>¿Que experiencia tengo?</h5>
            <p>Ut pharetra sit amet aliquam. Dictum sit amet justo donec enim diam vulputate ut. Rhoncus urna neque viverra justo nec. Convallis tellus id interdum velit laoreet id. Iaculis at erat pellentesque adipiscing commodo. Sed velit dignissim sodales ut eu sem integer vitae. Tempor id eu nisl nunc mi ipsum. Rhoncus aenean vel elit scelerisque mauris pellentesque. Ultrices neque ornare aenean euismod elementum nisi. Nascetur ridiculus mus mauris vitae ultricies leo. Commodo nulla facilisi nullam vehicula. Lectus mauris ultrices eros in cursus turpis. Suspendisse sed nisi lacus sed viverra. Malesuada bibendum arcu vitae elementum curabitur. Quisque egestas diam in arcu cursus euismod quis. Nulla facilisi nullam vehicula ipsum. Dictum varius duis at consectetur lorem donec massa. Amet mauris commodo quis imperdiet massa tincidunt nunc. Fermentum odio eu feugiat pretium nibh ipsum consequat nisl vel.</p>
            <p>Amet est placerat in egestas. Nulla porttitor massa id neque aliquam vestibulum. Sapien eget mi proin sed libero enim sed faucibus. Vel eros donec ac odio tempor orci dapibus ultrices in. Id semper risus in hendrerit. Sagittis vitae et leo duis ut diam quam nulla porttitor. Diam ut venenatis tellus in metus vulputate. In iaculis nunc sed augue lacus viverra vitae. Eu non diam phasellus vestibulum lorem. Massa sapien faucibus et molestie ac feugiat sed. Tincidunt ornare massa eget egestas purus viverra. Egestas fringilla phasellus faucibus scelerisque. Risus viverra adipiscing at in tellus integer feugiat scelerisque. Eleifend mi in nulla posuere sollicitudin aliquam ultrices. Vestibulum mattis ullamcorper velit sed ullamcorper morbi. Porttitor eget dolor morbi non. Platea dictumst vestibulum rhoncus est pellentesque elit. Commodo nulla facilisi nullam vehicula ipsum. Turpis tincidunt id aliquet risus.</p>
            <asp:Button runat="server" Text="Leer más" CssClass="btn btn-info" />
        </div>
        <div class="col">
            <h5>¿En que proyectos participe?</h5>
            <asp:ListView runat="server" ID="lstProyectos">
                <LayoutTemplate>
                    <ul>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    </ul>
                </LayoutTemplate>
                <ItemTemplate>
                    <li><%# Container.DataItem %></li>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
