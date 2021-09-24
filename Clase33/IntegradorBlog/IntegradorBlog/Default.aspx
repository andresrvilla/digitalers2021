<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntegradorBlog._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="card-group">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label runat="server" ID="lblTituloDestacadoUno"></asp:Label>
                        </h5>
                        <p class="card-text">Texto de la noticia destacada 1</p>
                        <p class="card-text"><small class="text-muted">20/09/2021</small></p>
                    </div>
                </div>
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label runat="server" ID="lblTituloDestacadoDos"></asp:Label>
                        </h5>
                        <p class="card-text">Resumen de la otra noticia destacada</p>
                        <p class="card-text"><small class="text-muted">20/09/2021</small></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row mt-4">
        <div class="col-md-9">
            <div class="mt-2">
                <h2>Blog Post 1</h2>
                <i class="text-muted">20/09/2021, por Carlos Sanchez</i>
                <div class="mt-3">
                    <p>Resumen del post 1</p>
                </div>                
            </div>
            <div class="mt-2">
                <h2>Blog Post 2</h2>
                <i class="text-muted">20/09/2021, por Carlos Sanchez</i>
                <div class="mt-3">
                    <p>Resumen del post 2</p>
                    <p>Resumen del post 2</p>
                </div>                
            </div>
        </div>
        <div class="col-md-3">
            <h4>Categorías</h4>
            <ul>
                <li>Tecnología</li>
                <li>Tecnología</li>
                <li>Tecnología</li>
                <li>Tecnología</li>
                <li>Tecnología</li>
                <li>Tecnología</li>
                <li>Tecnología</li>
            </ul>
        </div>
    </div>


</asp:Content>
