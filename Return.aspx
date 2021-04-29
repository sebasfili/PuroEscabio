<%@ Page Title="Devolucion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Return.aspx.cs" Inherits="PuroEscabio.Return" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Devolucion</li>
			</ol>
		</div>
	</div>
	<div class="about">
		<div class="container">
			<h3 class="w3_agile_header"><%: Title %></h3>
			<div class="about-agileinfo w3layouts">
				<div class="col-md-10 about-wthree-grids grid-top">
					<p class="top">Podes comprar tranquilo en Puro Escabio. Tu pedido está protegido por nuestra política de devolución.</p>
					<p class="top">Podes solicitar la devolución de dinero o cambio de productos:</p>
                    <ul>
                        <li><p class="top">Si recibís un producto distinto al que habías pedido.</p></li>
                        <li><p class="top">Si alguno de los productos llega en mal estado o con roturas.</p></li>
                        <li><p class="top">Si alguno de los productos llega vencido.</p></li>
                    </ul>
                    <p class="top">En los casos mencionados arriba vas a poder solicitar el cambio de productos o la devolución del dinero por tu compra sin costo adicional dentro de las 24 hs de haber recibido o retirado el producto.</p>
                    <p class="top">Si necesitas hacer un cambio o una devolución escribinos por mail a puroescabio@gmail.com.ar</p>
				</div>	
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
</asp:Content>
