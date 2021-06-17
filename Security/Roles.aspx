<%@ Page Title="Roles de Seguridad" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="PuroEscabio.Security.Roles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>La página de seguridad funciona.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:GridView ID="gvPermisos" runat="server"></asp:GridView>
</asp:Content>