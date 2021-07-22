<%@ Page Title="Champagnes" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Champagne.aspx.cs" Inherits="PuroEscabio.Products.Champagne" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/">Inicio</a></li>
            <li class="breadcrumb-item active" aria-current="page"><%: Title %></li>
        </ol>
    </nav>

    <div class="container">
        <h2><%: Title %></h2>
        <div class="row">
            <div class="col-2">
                <h5>Categorias</h5>
                <ul class="nav flex-column">
                    <li><a runat="server" href="~/Products/Beer"><i class="fa fa-arrow-right" aria-hidden="true"></i>Cervezas</a></li>
                    <li><a runat="server" href="~/Products/Wine"><i class="fa fa-arrow-right" aria-hidden="true"></i>Vinos</a></li>
                    <li><a runat="server" href="~/Products/Appetizer"><i class="fa fa-arrow-right" aria-hidden="true"></i>Aperitivos</a></li>
                    <li><a runat="server" href="~/Products/Champagne"><i class="fa fa-arrow-right" aria-hidden="true"></i>Champagnes</a></li>
                    <li><a runat="server" href="~/Products/Whiskey"><i class="fa fa-arrow-right" aria-hidden="true"></i>Whiskys</a></li>
                </ul>
            </div>


            <div class="col-10">
                <div class="row row-cols-1 row-cols-md-3 g-4">                    
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/champagne-chandon.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Champagne Chandon</h5>
                                <h4>$790.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/champagne-navarrocorrea.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Champagne Navarro Correa</h5>
                                <h4>$830.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/champagne-varonb.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Champagne Baron B</h5>
                                <h4>$930.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                  
                </div>
            </div>
        </div>
    </div>
</asp:Content>