<%@ Page Title="Preguntas Frecuentes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrequentQuestions.aspx.cs" Inherits="PuroEscabio.FrequentQuestions" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Preguntas Frecuentes</li>
			</ol>
		</div>
	</div>
	<div class="about">
		<div class="container">
			<h3 class="w3_agile_header"><%: Title %></h3>
			<div class="about-agileinfo w3layouts">
				<div class="col-md-12 about-wthree-grids grid-top">
					<p class="top" style="font-size:25px"><b>¿Cuanto tarda el envío?</b></p>
					<p class="top">La tardanza del envío depende de la localidad. Si es en CABA o GBA el envío se realiza en 24hs a 48hs. Si el envío es 
                        al interior del país puede tener una tardanza de 2 a 7 días.
					</p>
                    <p class="top" style="font-size:25px"><b>¿Realizan envío al interior?</b></p>
					<p class="top">Si, realimos envios a toda la Argentina.</p>
                    <p class="top" style="font-size:25px"><b>¿El envío es gratis?</b></p>
					<p class="top">El envío es gratis únicamente para CABA y GBA. Para el resto del país es pago ya que tenemos convenios con empresas que distribuyen nuestron productos</p>
                    <p class="top" style="font-size:25px"><b>¿Cúal es la compra mínima?</b></p>
					<p class="top">No hay compra mínima, lo que el cliente necesite</p>
                    <p class="top" style="font-size:25px"><b>¿Cómo es el seguimiento del envío?</b></p>
					<p class="top">Una vez realizada la compra verificamos donde hay que realizar el envío. Si el envío es al interior luego de 24 hs hábiles se le informa por whatsapp el número de seguimiento. Luego se carga en el sistema para que el usuario lo pueda ver en su perfil</p>
				</div>	
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
</asp:Content>
