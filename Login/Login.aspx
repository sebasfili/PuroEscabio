<%@ Page Title="Login" MasterPageFile="~/Site.Master"  Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PuroEscabio.Login.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Login</li>
			</ol>
		</div>
	</div>
	<div class="login">
		<div class="container">
			<h2>Inicio de Sesión</h2>
		
			<div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">
				<form>
                    <asp:TextBox runat="server" Id="txtUsuario" AutoCompleteType="Email" placeholder="e-mail"/>
					<asp:TextBox runat="server" Id="txtPassword" placeholder="contraseña"/>
					
					<div class="forgot">
						<a href="#">¿Olvido la contraseña?</a>
					</div>
                    <asp:Button Text="Ingresar" runat="server" OnClick="Unnamed1_Click" />
					
				</form>
			</div>
			<h4>¿Todavía no esta registrado?</h4>
			<p><a runat="server" href="#">Registrarse aquí</a> o vaya al <a runat="server" href="~/">Inicio<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></a></p>
		</div>
	</div>
</asp:Content>