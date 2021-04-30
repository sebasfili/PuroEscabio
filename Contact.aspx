

<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PuroEscabio.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Contacto</li>
			</ol>
		</div>
	</div>
	<div class="about">
        <h3 class="w3_agile_header"><%: Title %></h3><br />
		<div class="w3_agileits_contact_grids">
			<div class="col-md-6 w3_agileits_contact_grid_left">
				<div class="agile_map">
					<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3284.2706399869717!2d-58.45731628518167!3d-34.59731728046111!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x95bcb5f8f3287d1f%3A0x8f5e5f0d303a7993!2sAv.%20Dorrego%20100%2C%20C1414%20CJN%2C%20Buenos%20Aires!5e0!3m2!1ses!2sar!4v1619560571306!5m2!1ses!2sar" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
				</div>
			</div>
			<div class="col-md-6 w3_agileits_contact_grid_right">
				<h2 class="w3_agile_header">Enviar un mensaje</h2>

				<form action="#" method="post">
					<span class="input input--ichiro">
						<input class="input__field input__field--ichiro" type="text" id="input-25" name="Name" placeholder=" " required="" />
						<label class="input__label input__label--ichiro" for="input-25">
							<span class="input__label-content input__label-content--ichiro">Nombre</span>
						</label>
					</span>
					<span class="input input--ichiro">
						<input class="input__field input__field--ichiro" type="email" id="input-26" name="Email" placeholder=" " required="" />
						<label class="input__label input__label--ichiro" for="input-26">
							<span class="input__label-content input__label-content--ichiro">Email</span>
						</label>
					</span>
					<textarea name="Message" placeholder="Escribe tu mensaje aquí..." required=""></textarea>
					<input type="submit" value="Enviar">
				</form>
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>
</asp:Content>

