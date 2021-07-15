<%@ Page Title="Respaldo y Restauración de la Base de Datos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="BackUp.aspx.cs" Inherits="PuroEscabio.Security.Security" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
            <li class="breadcrumb-item active" aria-current="page">BackUp y Restore</li>
        </ol>
    </nav>
    <h2><%: Title %>.</h2>

    <ul class="nav nav-tabs nav-fill" id="myTab" role="tablist">
        <li class="nav-item" role="presentation">
            <button class="nav-link active" id="backUp-tb" data-bs-toggle="tab" data-bs-target="#backUp" type="button" role="tab" aria-controls="backUp" aria-selected="true">BackUp</button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="restore-tab" data-bs-toggle="tab" data-bs-target="#restore" type="button" role="tab" aria-controls="restore" aria-selected="false">Restore</button>
        </li>
    </ul>
    <div class="tab-content" id="myTabContent">
        <div class="tab-pane fade show active" id="backUp" role="tabpanel" aria-labelledby="backUp-tab">
            <div class="container m-3">
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
        </div>
        <div class="tab-pane fade" id="restore" role="tabpanel" aria-labelledby="restore-tab">
            <div class="container m-3">
                <div class="row justify-content-lg-center">
                    <div class="col-lg-4 form-floating">
                        <asp:DropDownList runat="server" ID="dpBackUps" CssClass="form-select">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="dpDB" SetFocusOnError="true" runat="server" CssClass="alert-danger" />
                        <asp:Label Text="Base de Datos" runat="server" CssClass="form-label" AssociatedControlID="dpDB" />
                    </div>
                </div>
                <div class="row">
                    <asp:Button Text="Ejecutar Back-Up" runat="server" CssClass="btn btn-warning btn-lg" ID="btnRestoreBD" OnClick="btnRestoreBD_Click" />
                    <asp:Label Text="Ocurrió un Error, intente más tarde" ID="Label1" Visible="false" CssClass="alert alert-danger" role="alert" runat="server" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
