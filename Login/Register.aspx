<%@ Page Title="Registro de Nuevo Usuario" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PuroEscabio.Login.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.
    </h2>
    <h3>La página de seguridad funciona.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:TextBox ID="TextBox1" runat="server" ControlToValidate="TextBox1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="el campo debe ser completado" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
</asp:Content>