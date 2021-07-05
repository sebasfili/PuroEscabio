<%@ Page Title="Listado de Packs" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="PackList.aspx.cs" Inherits="PuroEscabio.Products.PackList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
            <li class="breadcrumb-item active" aria-current="page">Packs</li>
        </ol>
    </nav>

    <h3><%: Title %></h3>

    <div class="row row-cols-1 row-cols-md-2 g-4">
        <div class="col">

            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 1</h5>
                </div>
                <div class="card-body">

                    <ul>
                        <li>
                            <p>2 Fernet Branca</p>
                        </li>
                        <li>
                            <p>2 Vodka Smirnoff</p>
                        </li>
                        <li>
                            <p>5 Vinos Don Valentín</p>
                        </li>
                    </ul>
                    <h4>$1800.00</h4>

                </div>
                <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
            </div>
        </div>
        <div class="col">
            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 2</h5>
                </div>
                <div class="card-body">
                    <ul>
                        <li>
                            <p>10 Cerveza Corona Personal</p>
                        </li>
                        <li>
                            <p>10 Cerveza Brahama Litro</p>
                        </li>
                        <li>
                            <p>10 Cerveza Patagonia Litro</p>
                        </li>
                    </ul>
                    <h4>$2500.00</h4>

                </div>
                <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
            </div>
        </div>
        <div class="col">
            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 3</h5>
                </div>
                <div class="card-body">
                    <ul>
                        <li>
                            <p>5 Whisky Jack Daniel's</p>
                        </li>
                        <li>
                            <p>10 Cerveza Pagagonia</p>
                        </li>
                        <li>
                            <p>5 Fernet Branca</p>
                        </li>
                    </ul>
                    <h4>$10000.00</h4>

                </div>
                <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
            </div>
        </div>
        <div class="col">
            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 4</h5>
                </div>
                <div class="card-body">
                    <ul>
                        <li>
                            <p>10 Vino Calia</p>
                        </li>
                        <li>
                            <p>10 Vino Don Valentin</p>
                        </li>
                        <li>
                            <p>10 Vino López</p>
                        </li>
                    </ul>
                    <h4>$3000.00</h4>

                </div>
                <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
            </div>
        </div>
        <div class="col">
            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 5</h5>
                </div>
                <div class="card-body">
                    <ul>
                        <li>
                            <p>5 Champagne Baron B</p>
                        </li>
                        <li>
                            <p>5 Champagne Navarro Correa</p>
                        </li>
                        <li>
                            <p>5 Champagne Chandon</p>
                        </li>
                    </ul>
                    <h4>$7000.00</h4>

                </div>
                
                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                
            </div>
        </div>
        <div class="col">
            <div class="card border-warning">
                <div class="card-header bg-warning">
                    <h5 class="card-title">Pack N° 6</h5>
                </div>
                <div class="card-body">
                    <ul>
                        <li>
                            <p>10 Cerveza Patagonia Litro</p>
                        </li>
                        <li>
                            <p>10 Vino Don Valentín</p>
                        </li>
                        <li>
                            <p>5 Champagne Baron B</p>
                        </li>
                    </ul>
                    <h4>$5500.00</h4>

                </div>
                
                    <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                
            </div>
        </div>
    </div>

</asp:Content>
