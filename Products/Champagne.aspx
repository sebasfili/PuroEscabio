<%@ Page Title="Champagnes" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Champagne.aspx.cs" Inherits="PuroEscabio.Products.Champagne" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
				<li class="active">Champagnes</li>
			</ol>
		</div>
	</div>
	<div class="products">
        <div class="container">
			<h3 class="w3_agile_header"><%: Title %></h3>
			<div class="col-md-4 products-left">
				<div class="categories">
					<h2>Categorias</h2>
					<ul class="cate">
						<li><a runat="server" href="~/Products/Beer"><i class="fa fa-arrow-right" aria-hidden="true"></i>Cervezas</a></li>
						<li><a runat="server" href="~/Products/Wine"><i class="fa fa-arrow-right" aria-hidden="true"></i>Vinos</a></li>
						<li><a runat="server" href="~/Products/Appetizer"><i class="fa fa-arrow-right" aria-hidden="true"></i>Aperitivos</a></li>
						<li><a runat="server" href="~/Products/Whiskey"><i class="fa fa-arrow-right" aria-hidden="true"></i>Whiskys</a></li>
					</ul>
				</div>																																												
			</div>
			<div class="col-md-8 products-right">
				<div class="agile_top_brands_grids">
					<div class="col-md-4 top_brand_left">
						<div class="hover14 column">
							<div class="agile_top_brand_left_grid">
								<div class="agile_top_brand_left_grid_pos">
								</div>
								<div class="agile_top_brand_left_grid1">
									<figure>
										<div class="snipcart-item block">
											<div class="snipcart-thumb">
												<a href="#"><img runat="server" title=" " alt=" " src="~/images/p16.jpg" class="img-responsive"></a>		
												<p>Champagne Navarro Correa</p>
												<h4>$830.00</h4>
											</div>
											<div class="snipcart-details top_brand_home_details">
												<form action="#" method="post">
													<fieldset>
														<input type="hidden" name="cmd" value="_cart">
														<input type="hidden" name="add" value="1">
														<input type="hidden" name="business" value=" ">
														<input type="hidden" name="item_name" value="Pepsi soft drink">
														<input type="hidden" name="amount" value="80.00">
														<input type="hidden" name="discount_amount" value="1.00">
														<input type="hidden" name="currency_code" value="USD">
														<input type="hidden" name="return" value=" ">
														<input type="hidden" name="cancel_return" value=" ">
														<input type="submit" name="submit" value="Agregar" class="button">
													</fieldset>
												</form>
											</div>
										</div>
									</figure>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 top_brand_left">
						<div class="hover14 column">
							<div class="agile_top_brand_left_grid">
								<div class="agile_top_brand_left_grid_pos">
								</div>
								<div class="agile_top_brand_left_grid1">
									<figure>
										<div class="snipcart-item block">
											<div class="snipcart-thumb">
												<a href="#"><img runat="server" title=" " alt=" " src="~/images/p17.jpg" class="img-responsive"></a>		
												<p>Champagne Baron B</p>
												<h4>$930</h4>
											</div>
											<div class="snipcart-details top_brand_home_details">
												<form action="#" method="post">
													<fieldset>
														<input type="hidden" name="cmd" value="_cart">
														<input type="hidden" name="add" value="1">
														<input type="hidden" name="business" value=" ">
														<input type="hidden" name="item_name" value="Pepsi soft drink">
														<input type="hidden" name="amount" value="120.00">
														<input type="hidden" name="discount_amount" value="1.00">
														<input type="hidden" name="currency_code" value="USD">
														<input type="hidden" name="return" value=" ">
														<input type="hidden" name="cancel_return" value=" ">
														<input type="submit" name="submit" value="Agregar" class="button">
													</fieldset>
												</form>
											</div>
										</div>
									</figure>
								</div>
							</div>
						</div>
					</div>
					<div class="col-md-4 top_brand_left">
						<div class="hover14 column">
							<div class="agile_top_brand_left_grid">
								<div class="agile_top_brand_left_grid_pos">
								</div>
								<div class="agile_top_brand_left_grid_pos">
								</div>
								<div class="agile_top_brand_left_grid1">
									<figure>
										<div class="snipcart-item block">
											<div class="snipcart-thumb">
												<a href="#"><img runat="server" title=" " alt=" " src="~/images/p15.jpg" class="img-responsive"></a>
												<p>Champagne Chandon</p>
												<h4>$790.00</h4>
											</div>
											<div class="snipcart-details top_brand_home_details">
												<form action="#" method="post">
													<fieldset>
														<input type="hidden" name="cmd" value="_cart">
														<input type="hidden" name="add" value="1">
														<input type="hidden" name="business" value=" ">
														<input type="hidden" name="item_name" value="Pepsi soft drink">
														<input type="hidden" name="amount" value="100.00">
														<input type="hidden" name="discount_amount" value="1.00">
														<input type="hidden" name="currency_code" value="USD">
														<input type="hidden" name="return" value=" ">
														<input type="hidden" name="cancel_return" value=" ">
														<input type="submit" name="submit" value="Agregar" class="button">
													</fieldset>
												</form>
											</div>
										</div>
									</figure>
								</div>
							</div>
						</div>
					</div>
						<div class="clearfix"> </div>
				</div>
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>
</asp:Content>