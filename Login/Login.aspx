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
    <form id="frmLogin" runat="server">
        <div class="login">
            <div class="container">
                <h2>Inicio de Sesión</h2>

                <div class="login-form-grids">
                    <asp:TextBox runat="server" AutoCompleteType="Email" ID="txtUsuario" TextMode="Email" placeholder="e-mail" CssClass="form-control form-control-lg" />
                    <asp:RequiredFieldValidator ID="reqEmail" runat="server" CssClass="alert alert-danger" role="alert" ControlToValidate="txtUsuario" ErrorMessage="El campo es requerido"></asp:RequiredFieldValidator>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="contraseña" class="form-control form-control-lg" />
                    <asp:RequiredFieldValidator ID="reqPassword" runat="server" CssClass="alert alert-danger" role="alert" ControlToValidate="txtPassword" ErrorMessage="El campo es requerido"></asp:RequiredFieldValidator>

                    <div class="forgot">
                        <a href="#">¿Olvido la contraseña?</a>
                    </div>
                    <asp:Button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" />

                    <asp:Label ID="lblErrorLogin" runat="server" ForeColor="Red" Font-Size="Medium" Visible="false" />
                </div>
                <h4>¿Todavía no esta registrado?</h4>
                <p><a runat="server" href="#">Registrarse aquí</a> o vaya al <a runat="server" href="~/">Inicio<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
            </div>
        </div>
    </form>
</asp:Content>
