<%@ Page Title="Registro Usuario" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PuroEscabio.Login.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
        <div class="container">
            <ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
                <li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
                <li class="active">Registro</li>
            </ol>
        </div>
    </div>
    <div class="container">
        <div class="row g-3">
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="FirstName" ID="txtNombre" placeholder="Apellido" />
                <asp:Label Text="Nombre" runat="server" CssClass="form-label" AssociatedControlID="txtNombre" />
            </div>
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="LastName" ID="txtApellido" placeholder="Apellido" />
                <asp:Label Text="Apellido" runat="server" CssClass="form-label" AssociatedControlID="txtNombre" />
            </div>
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="None" ID="txtDNI" placeholder="DNI" />
                <asp:Label Text="DNI" runat="server" CssClass="form-label" AssociatedControlID="txtDNI" />
            </div>
            <div class="col-lg-3 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="HomeStreetAddress" ID="txtDireccion" placeholder="Dirección" />
                <asp:Label Text="Dirección" runat="server" CssClass="form-label" AssociatedControlID="txtDireccion" />
            </div>
            <div class="col-lg-3 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="Email" ID="txtCiudad" placeholder="Ciudad" />
                <asp:Label Text="Ciudad" runat="server" CssClass="form-label" AssociatedControlID="txtCiudad" />
            </div>
            <div class="col-lg-3 form-floating">
                <asp:DropDownList runat="server" ID="dpPais" CssClass="form-select">
                    <asp:ListItem Text="Argentina" Value="1" />
                    <asp:ListItem Text="Colombia" Value="2" />
                </asp:DropDownList>
                <asp:Label Text="País" runat="server" CssClass="form-label" AssociatedControlID="dpPais" />
            </div>
            <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="Email" ID="txtEmail" placeholder="E-mail" />
                <asp:Label Text="E-mail" runat="server" CssClass="form-label" AssociatedControlID="txtEmail" />
            </div>
            <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="txtPassword" placeholder="Contraseña" />
                <asp:Label Text="Contraseña" runat="server" CssClass="form-label" AssociatedControlID="txtPassword" />
            </div>
            <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="txtRePassword" placeholder="Repetir Contraseña" />
                <asp:Label Text="Repetir Contraseña" runat="server" CssClass="form-label" AssociatedControlID="txtRePassword" />
            </div>
            <div class="col-12">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="gridCheck">
                    <label class="form-check-label" for="gridCheck">
                        Check me out
                    </label>
                </div>
            </div>
            <div class="col-12">
                <asp:Button Text="Registrar" runat="server" CssClass="btn btn-warning" OnClick="btnRegistrar_Click" />
                <asp:Label Text="Ocurrió un Error, intente más tarde" ID="lblError" Visible="false" CssClass="alert alert-danger" role="alert" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
