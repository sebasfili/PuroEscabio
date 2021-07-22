<%@ Page Title="Cervezas" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Beer.aspx.cs" Inherits="PuroEscabio.Products.Beer" %>

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
                            <img src="../Images/brahama-lata.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Brahama Lata</h5>
                                <h4>$80.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/brahama-litro.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Brahama Litro</h5>
                                <h4>$280.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/patagonia-lata.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Patagonia Lata</h5>
                                <h4>$250.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/patagonia-litro.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Patagonia Litro</h5>
                                <h4>$250.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/corona-personal.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Corona Personal</h5>
                                <h4>$90.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/corona-lata.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Cerveza Corona Lata</h5>
                                <h4>$90.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
