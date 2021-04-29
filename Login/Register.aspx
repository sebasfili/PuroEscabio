<%@ Page Title="Registro Usuario" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PuroEscabio.Login.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Registro</li>
			</ol>
		</div>
	</div>
	<div class="register">
		<div class="container">
			<h2>Registro Usuario</h2>
			<div class="login-form-grids">
				<h5>Información del Perfil</h5>
				<form action="#" method="post">
					<input type="text" placeholder="Nombre" required=" " >
					<input type="text" placeholder="Apellido" required=" " >
				</form>
				<h6>Información de Login</h6>
					<form action="#" method="post">
					<input type="email" placeholder="Email" required=" " >
					<input type="password" placeholder="Contraseña" required=" " >
					<input type="password" placeholder="Confirmación de Contraseña" required=" " >
					<div class="register-check-box">
						<div class="check">
							<label class="checkbox"><input type="checkbox" name="checkbox"><i> </i>Acepto los términos y condiciones</label>
						</div>
					</div>
					<input type="submit" value="Registrarse">
				</form>
			</div>
			<div class="register-home">
				<a runat="server" href="~/">Inicio</a>
			</div>
		</div>
	</div>
</asp:Content>