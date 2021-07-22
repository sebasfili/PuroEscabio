<%@ Page Title="Lista de Productos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="PuroEscabio.Products.ProductsList" %>

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
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/vino-donvalentin.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Vino Don Valentín</h5>
                                <h4>$180.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/vino-calia.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Vino Calia</h5>
                                <h4>$150.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/vino-lopez.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Vino Lopez</h5>
                                <h4>$150.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/fernet-branca.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Fernet Branca</h5>
                                <h4>$330.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/fernet-1982.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Fernet 1882</h5>
                                <h4>$280.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/gancia.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Gancia</h5>
                                <h4>$250.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/campari.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Campari</h5>
                                <h4>$230.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/vodka-smirnoff.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Vodka Smirnoff</h5>
                                <h4>$600.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
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
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/wisky-jackdaniels.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Whisky Jack Daniel's</h5>
                                <h4>$1500.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/wisky-smuggler.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Whisky Smuggler</h5>
                                <h4>$930.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="card h-100">
                            <img src="../Images/wisky-singleton.jfif" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title">Whisky Singleton</h5>
                                <h4>$1000.00</h4>
                            </div>
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-outline-secondary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
