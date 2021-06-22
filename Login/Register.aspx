<%@ Page Title="Registro Usuario" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PuroEscabio.Login.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="breadcrumbs">
        <div class="container">
            <ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
                <li><a runat="server" href="~/"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Inicio</a></li>
                <li class="active">Registro</li>
            </ol>
        </div>
    </div>
    <div class="container">
        <form class="row g-3">
            <div class="col-md-6">
                <label for="inputEmail4" class="form-label">Email</label>
                <input type="email" class="form-control" id="inputEmail4">
            </div>
            <div class="col-md-6">
                <label for="inputPassword4" class="form-label">Password</label>
                <input type="password" class="form-control" id="inputPassword4">
            </div>
            <div class="col-12">
                <label for="inputAddress" class="form-label">Address</label>
                <input type="text" class="form-control" id="inputAddress" placeholder="1234 Main St">
            </div>
            <div class="col-12">
                <label for="inputAddress2" class="form-label">Address 2</label>
                <input type="text" class="form-control" id="inputAddress2" placeholder="Apartment, studio, or floor">
            </div>
            <div class="col-md-6">
                <label for="inputCity" class="form-label">City</label>
                <input type="text" class="form-control" id="inputCity">
            </div>
         
            <div class="col-md-2">
                <label for="inputZip" class="form-label">Zip</label>
                <input type="text" class="form-control" id="inputZip">
            </div>
            <div class="col-12">
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="gridCheck">
                    <label class="form-check-label" for="gridCheck">
                        Check me out
                    </label>
                </div>
            </div>
            <div class="col-12">
                <button type="submit" class="btn btn-primary">Sign in</button>
            </div>
        </form>
    </div>
    <%-- <div class="register">
        <div class="container">
            <h2>Registro Usuario</h2>
            <div class="login-form-grids">                
                <h5>Información del Perfil</h5>       
                <asp:TextBox runat="server" placeholder="Nombre" CssClass="form-control form-control-xl"/>
                <asp:TextBox runat="server" placeholder="Apellido" class="form-control form-control-xl"/>
                <asp:TextBox runat="server" placeholder="DNI" class="form-control form-control-xl"/>
                <asp:TextBox runat="server" placeholder="Dirección" class="form-control form-control-xl"/>
                <h6>Información de Login</h6>

                <input type="email" placeholder="Email" runat="server" class="form-control form-control-lg">
                <input type="password" id="txtPassword" runat="server" placeholder="Contraseña" class="form-control form-control-lg">
                <asp:RequiredFieldValidator ErrorMessage="Debe ingresar una contraseña" ControlToValidate="txtPassword" runat="server" />
                <input type="password" runat="server" id="txtRePassword" placeholder="Confirmación de Contraseña" class="form-control form-control-lg">
                <asp:RequiredFieldValidator ErrorMessage="Debe reingresar la contraseña" ControlToValidate="txtRePassword" runat="server" />
                <asp:RegularExpressionValidator ErrorMessage="Error de password" ControlToValidate="txtPassword" runat="server" ValidationExpression="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$" />
                <div class="register-check-box">
                    <div class="check">
                        <label class="checkbox">
                            <input type="checkbox" name="checkbox"><i> </i>Acepto los términos y condiciones</label>
                    </div>
                </div>
                <asp:Button Text="Registrar" runat="server"  ID="btnRegistrar" ClientIDMode="Static" OnClick="btnRegistrar_Click"/>
            </div>
            <div class="register-home">
                <a runat="server" href="~/">Inicio</a>
            </div>
        </div>
    </div>--%>
</asp:Content>
