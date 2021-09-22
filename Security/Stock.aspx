<%@ Page Language="C#" Title="Inventario" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stock.aspx.cs" Inherits="PuroEscabio.Security.Stock" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    
    <h3>Con Stock</h3>
    <asp:GridView runat="server" ID="gvStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
    <h3>Stock Faltante</h3>
    <asp:GridView runat="server" ID="gvNoStock" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center"></asp:GridView>
</asp:Content>

