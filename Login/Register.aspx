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
        <div class="row g-3">
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="FirstName" ID="txtNombre" placeholder="Apellido" />
                <asp:Label Text="Nombre" runat="server" CssClass="form-label" AssociatedControlID="txtNombre" />
            </div>
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="LastName" ID="txtApellido" placeholder="Apellido" />
                <asp:Label Text="Apellido" runat="server" CssClass="form-label" AssociatedControlID="txtNombre" />
            </div>
            <div class="col-lg-4 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="None" ID="txtDNI" placeholder="DNI" />
                <asp:Label Text="DNI" runat="server" CssClass="form-label" AssociatedControlID="txtDNI" />
            </div>
            <div class="col-lg-3 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="HomeStreetAddress" ID="txtDireccion" placeholder="Dirección" />
                <asp:Label Text="Dirección" runat="server" CssClass="form-label" AssociatedControlID="txtDireccion" />
            </div>
            <div class="col-lg-3 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="Email" ID="txtCiudad" placeholder="Ciudad" />
                <asp:Label Text="Ciudad" runat="server" CssClass="form-label" AssociatedControlID="txtCiudad" />
            </div>
             <div class="col-lg-3 form-floating">
                 <asp:DropDownList runat="server" ID="dpPais" CssClass="form-select">
                     <asp:ListItem Text="Argentina" />
                     <asp:ListItem Text="Colombia" />
                 </asp:DropDownList>                
                <asp:Label Text="País" runat="server" CssClass="form-label" AssociatedControlID="dpPais" />
            </div>
            <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" AutoCompleteType="Email" ID="txtEmail" placeholder="E-mail" />
                <asp:Label Text="E-mail" runat="server" CssClass="form-label" AssociatedControlID="txtEmail" />
            </div>
            <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="txtPassword" placeholder="Contraseña" />
                <asp:Label Text="Contraseña" runat="server" CssClass="form-label" AssociatedControlID="txtPassword" />
            </div>
             <div class="col-lg-6 form-floating">
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" ID="txtRePassword" placeholder="Repetir Contraseña" />
                <asp:Label Text="Repetir Contraseña" runat="server" CssClass="form-label" AssociatedControlID="txtRePassword" />
            </div>
            
            <%--<div class="col-md-4">
                <label for="inputState" class="form-label">State</label>
                <select id="inputState" class="form-select">
                    <option selected>Choose...</option>
                    <option>...</option>
                </select>
            </div>
            <div class="col-md-2">
                <label for="inputZip" class="form-label">Zip</label>
                <input type="text" class="form-control" id="inputZip">
            </div>--%>
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
        </div>
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
