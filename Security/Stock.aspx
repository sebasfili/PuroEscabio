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
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="updateStock-tab" data-bs-toggle="tab" data-bs-target="#tabUpdateStock" type="button" role="tab" aria-controls="tabUpdateStock" aria-selected="false">Actualizar Stock</button>
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
                                <br />
                                <asp:Label Text="Seleccione una Sucursal para ver los resultados" ID="lblGridInfo1" CssClass="alert alert-info" role="alert" runat="server" />
                                <asp:GridView runat="server" ID="gvSucStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                                <br />
                                <h3>Stock Faltante</h3>
                                <br />
                                <asp:Label Text="Seleccione una Sucursal para ver los resultados" ID="lblGridInfo2" CssClass="alert alert-info" role="alert" runat="server" />
                                <asp:GridView runat="server" ID="gvSucNoStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                </div>
            </div>
        </div>

        <div class="tab-pane fade" id="tabUpdateStock" role="tabpanel" aria-labelledby="restore-tab">
            <h4>Complete el formulario para actualizar el Stock</h4>
            <div class="container m-3">
                <asp:UpdatePanel runat="server" >
                    <ContentTemplate>
                        <div class="row g-3">

                            <div class="col-lg-4 form-floating">
                                <asp:DropDownList runat="server" ID="dpProducto" CssClass="form-select">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="dpProducto" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                                <asp:Label Text="Producto" runat="server" CssClass="form-label" AssociatedControlID="dpProducto" />
                            </div>
                            <div class="col-lg-4 form-floating">
                                <asp:DropDownList runat="server" ID="dpSucursalUpdate" CssClass="form-select">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="dpSucursalUpdate" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                                <asp:Label Text="Sucursal" runat="server" CssClass="form-label" AssociatedControlID="dpSucursalUpdate" />
                            </div>
                            <div class="col-lg-4 form-floating">
                                <asp:TextBox runat="server" CssClass="form-control" TextMode="Number" ID="txtCantidadStock" placeholder="Ciudad" />
                                <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="txtCantidadStock" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                                <br />
                                <asp:CompareValidator runat="server"
                                    CssClass="alert-danger"
                                    role="alert"
                                    SetFocusOnError="true"
                                    ControlToValidate="txtCantidadStock"
                                    Operator="GreaterThanEqual"
                                    ValueToCompare="0"
                                    Type="Integer"
                                    Text="Debe ingresar un valor mayor a cero" />
                                <asp:Label Text="Cantidad" runat="server" CssClass="form-label" AssociatedControlID="txtCantidadStock" />
                            </div>

                        </div>
                        <div class="row g-3">
                            <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-warning btn-lg" ID="btnAceptar" OnClick="btnAceptar_Click" />
                            <div class="alert alert-success alert-dismissible fade show" role="alert" runat="server" id="msgSuccess" visible="false">
                                <h3 class="alert-heading">Éxito</h3>
                                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                                <p>Se actuliazó correctamente el Stock</p>
                                <hr>
                                <p class="mb-0">Puede continuar trabajando...</p>
                            </div>
                        </div>
                    </ContentTemplate>                    
                </asp:UpdatePanel>
            </div>
        </div>

    </div>


</asp:Content>

