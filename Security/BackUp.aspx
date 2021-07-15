<%@ Page Title="Respaldo y Restauración de la Base de Datos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="BackUp.aspx.cs" Inherits="PuroEscabio.Security.Security" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="container align-middle">
        <div class="row justify-content-lg-center">
            <div class="col-lg-4 form-floating">
                <asp:DropDownList runat="server" ID="dpDB" CssClass="form-select">
                    <asp:ListItem Text="PuroEscabio" Value="PuroEscabio" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="dpDB" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                <asp:Label Text="Base de Datos" runat="server" CssClass="form-label" AssociatedControlID="dpDB" />
            </div>
             <div class="col-lg-4 form-floating">
                <asp:DropDownList runat="server" ID="dpServer" CssClass="form-select">
                    <asp:ListItem Text="Local Host" Value="." />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="dpServer" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                <asp:Label Text="Servidor" runat="server" CssClass="form-label" AssociatedControlID="dpServer" />
            </div>
        </div> 
        <div class=" row-cols-1">
            <asp:Button Text="Ejecutar Back-Up" runat="server" CssClass="btn btn-warning btn-lg" ID="btnExecBackup" OnClick="btnExecBackup_Click" />
            <asp:Label Text="Ocurrió un Error, intente más tarde" ID="lblError" Visible="false" CssClass="alert alert-danger" role="alert" runat="server" />
        </div>
    </div>
</asp:Content>
