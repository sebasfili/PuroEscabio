<%@ Page Title="Bitacora" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="PuroEscabio.Security.Bitacora" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <asp:GridView ID="gvBitacora" runat="server" PageSize="15" Width="90%" CssClass="table table-hover table-dark table-striped" HorizontalAlign="Center" />
</asp:Content>
