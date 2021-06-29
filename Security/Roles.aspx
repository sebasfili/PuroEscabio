<%@ Page Title="Roles de Seguridad" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="PuroEscabio.Security.Roles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <asp:GridView ID="gvPermisos" runat="server" CssClass="table table-sm table-hover table-dark table-striped "></asp:GridView>
</asp:Content>
