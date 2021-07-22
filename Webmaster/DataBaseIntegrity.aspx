<%@ Page Title="Integridad de Base de Datos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="DataBaseIntegrity.aspx.cs" Inherits="PuroEscabio.Security.DataBaseIntegrity" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <br />
    <asp:Button ID="btnDigHorizontal" runat="server" Text="Recalcular Dígito Horizontal" CssClass="btn btn-warning" OnClick="btnDigHorizontal_Click" />
    <div class="alert alert-success alert-dismissible fade show" role="alert" runat="server" id="divExito" visible="false">
        <h3 class="alert-heading">Recálculo exitoso</h3>
        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        <p>El dígito verificador se recalculó con éxito</p>
        <hr>
        <p class="mb-0">Cierre la ventana del navegador y vuelva a iniciar sesión</p>
    </div>
    <div class="alert alert-danger alert-dismissible fade show" role="alert" runat="server" id="divError" visible="false">
        <h3 class="alert-heading">Error en recálculo</h3>
        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        <p>Ocurrió un error durante el proceso de recálculo del dígito verificador, no se pudo realizar de forma automática.</p>
        <hr>
        <p class="mb-0">Contacte al Administrador de Base de Datos.</p>
    </div>
</asp:Content>

