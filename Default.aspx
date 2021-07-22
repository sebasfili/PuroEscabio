<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PuroEscabio._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Usted ingres&oacute; como <asp:Label Text="text" runat="server"  ID="lblRolUsuario"/> </h1>
        <p class="lead">Bienvenido</p>      
    </div>   

   <div class="alert alert-danger" role="alert" runat="server" id="divIntegridad" visible="false">
                <h3 class="alert-heading">Error de Integridad de Datos</h3>
                <p>La integridad de la Base de Datos ha sido violada. Se requiere recuperar la misma para poder continuar.</p>
                <asp:GridView ID="gvErroresIntegridad" runat="server"></asp:GridView>
                <hr>
                <p class="mb-0">Reporte el error al Webmaster y reintente más tarde.</p>
            </div>
</asp:Content>

