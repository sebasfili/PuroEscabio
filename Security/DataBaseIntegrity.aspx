<%@ Page Title="Integridad de Base de Datos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="DataBaseIntegrity.aspx.cs" Inherits="PuroEscabio.Security.DataBaseIntegrity" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <br />
    <asp:Button ID="btnDigHorizontal" runat="server" Text="Recalcular Dígito Horizontal" CssClass="btn btn-warning" OnClick="btnDigHorizontal_Click" />
</asp:Content>

