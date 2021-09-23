<%@ Page Language="C#" Title="Inventario" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="PuroEscabio.Security.Stock" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <ul class="nav nav-tabs nav-fill" id="myTab" role="tablist">
        <li class="nav-item" role="presentation">
            <button class="nav-link active" id="stock-tb" data-bs-toggle="tab" data-bs-target="#tabStockTotal" type="button" role="tab" aria-controls="stock" aria-selected="true">Stock Completo</button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="stockSucursal-tab" data-bs-toggle="tab" data-bs-target="#tabStockSucursal" type="button" role="tab" aria-controls="stockSucursal" aria-selected="false">Stock por Sucursal</button>
        </li>
    </ul>
    <div class="tab-content" id="myTabContent">
        <div class="tab-pane fade show active" id="tabStockTotal" role="tabpanel" aria-labelledby="backUp-tab">
            <div class="container m-3">
                <div class="row justify-content-lg-center">
                    <div class="col-lg form-floating">
                        <h3>Con Stock</h3>
                        <asp:GridView runat="server" ID="gvStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                        <h3>Stock Faltante</h3>
                        <asp:GridView runat="server" ID="gvNoStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                    </div>

                </div>
                <div class=" row-cols-1">
                    <asp:Button Text="Refrescar Lista" runat="server" CssClass="btn btn-warning btn-lg" ID="btnRefresh" OnClick="btnRefresh_Click" />
                    <asp:Label Text="Ocurrió un Error, intente más tarde" ID="lblError" Visible="false" CssClass="alert alert-danger" role="alert" runat="server" />
                </div>
            </div>
        </div>
        <div class="tab-pane fade" id="tabStockSucursal" role="tabpanel" aria-labelledby="restore-tab">
            <div class="container m-3">
                <div class="row justify-content-lg-center">
                    <div class="col-lg-4">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <div class="form-floating">
                                    <asp:DropDownList runat="server" ID="dpSucursales" CssClass="form-select" AutoPostBack="true" OnSelectedIndexChanged="dpSucursales_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:Label Text="Sucursales" runat="server" CssClass="form-label" AssociatedControlID="dpSucursales" />
                                </div>
                                <div id="lblErrorSucursal" runat="server" visible="false">
                                    <br />
                                    <asp:Label Text="Seleccione una Sucursal" ID="Label1" CssClass="alert alert-danger" role="alert" runat="server" />
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="alert alert-danger" role="alert" runat="server" id="sinBackup" visible="false">
                        Debe seleccionar un back-up de la lista
                    </div>
                </div>
                <div class="row justify-content-lg-center">
                    <div class="col-lg form-floating">
                        <asp:UpdatePanel ID="updateGrids" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <h3>Con Stock</h3>
                                <asp:GridView runat="server" ID="gvSucStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                                <h3>Stock Faltante</h3>
                                <asp:GridView runat="server" ID="gvSucNoStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                </div>



            </div>
        </div>
    </div>


</asp:Content>

