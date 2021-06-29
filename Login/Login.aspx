<%@ Page Title="Login" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PuroEscabio.Login.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
        <div class="container">
            <ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
                <li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
                <li class="active">Login</li>
            </ol>
        </div>
    </div>
    <div class="container">

        <div class="row justify-content-md-center">
            <div class="col col-lg-5">
                <h2>Inicio de Sesión</h2>
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" AutoCompleteType="Email" ID="txtUsuario" TextMode="Email" placeholder="e-mail" CssClass="form-control" />
                    <asp:Label Text="E-mail" runat="server" AssociatedControlID="txtUsuario"></asp:Label>
                </div>
                <asp:RequiredFieldValidator ID="reqEmail" runat="server" CssClass="alert alert-danger" role="alert" ControlToValidate="txtUsuario" ErrorMessage="El campo es requerido"></asp:RequiredFieldValidator>

                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Contraseña" class="form-control form-control-lg" />
                    <asp:Label Text="Contraseña" runat="server" AssociatedControlID="txtPassword" />
                </div>

                <asp:RequiredFieldValidator ID="reqPassword" runat="server" CssClass="alert alert-danger" role="alert" ControlToValidate="txtPassword" ErrorMessage="El campo es requerido"></asp:RequiredFieldValidator>

                <div>
                    <a href="#" class="link-secondary">¿Olvido la contraseña?</a>
                </div>
                <asp:Button CssClass="btn btn-warning" Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" />

                <asp:Label ID="lblErrorLogin" runat="server" ForeColor="Red" Font-Size="Medium" Visible="false" />
            </div>
        </div>
        <div class="row justify-content-md-center">
            <div class="col col-lg-5">
                <h5>¿Todavía no esta registrado?</h5>
                <p><a class="link-success" runat="server" href="#">Registrarse aquí</a></p>
            </div>
        </div>


    </div>
</asp:Content>
