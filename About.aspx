<%@ Page Title="Sobre Nosotros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PuroEscabio.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Sobre Nosotros</li>
			</ol>
		</div>
	</div>
	<div class="about">
		<div class="container">
			<h3 class="w3_agile_header"><%: Title %></h3>
			<div class="about-agileinfo w3layouts">
				<div class="col-md-12 about-wthree-grids grid-top">
					<p class="top">Somos una empresa que está situada en la Ciudad Autónoma de Buenos Aires en el barrio de Palermo
                        sobre la Av. Dorrego N° 100. Nos dedicamos a la venta de bebidas para bares, restaurantes y particulares. Realizamos 
                        entregas a todo CABA y GBA con personal propio, y llegamos a todo el país a través de acuerdos comerciales con 
                        distintas empresas de transportes.</p>
					<p class="top">La transparencia es una de nuestras principales fortalezas, y por eso ponemos a disposición nuetsras listas
                        de precios siempre actualizadas en nuestra web.</p>
                    <p class="top">La calidad del servicio de distribución nos diferencia de nuestra competencia. Informamos a cada cliente día y 
                        horario de entrega del producto y lo cumplimos siempre.</p>
                    <p class="top">Además, contamos con un depósito ubicado en la Av. Dorrego N° 500 que funciona como punto de venta y retiro de mercadería.</p>
                    <p class="top">Para asegurar que los pedidos lleguen a destino en óptimas condiciones hemos diseñado unas cajas especiales y a medida.</p>
				</div>	
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
</asp:Content>
