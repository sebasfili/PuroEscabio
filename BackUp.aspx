<%@ Page Title="Seguridad" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="BackUp.aspx.cs" Inherits="PuroEscabio.Security.Security" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
            <li class="breadcrumb-item active" aria-current="page">BackUp y Restore</li>
        </ol>
    </nav>

    <div class="container">
        <div class="row justify-content-md-center">
            <div class="col col-lg-5">
                <h2>BackUp y Restore</h2>
                <div class="form-floating mb-3">
                    <ul class="nav nav-tabs" id="myTab" role="tablist">
                      <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="backUp-tb" data-bs-toggle="tab" data-bs-target="#backUp" type="button" role="tab" aria-controls="backUp" aria-selected="true">BackUp</button>
                      </li>
                      <li class="nav-item" role="presentation">
                        <button class="nav-link" id="restore-tab" data-bs-toggle="tab" data-bs-target="#restore" type="button" role="tab" aria-controls="restore" aria-selected="false">Restore</button>
                      </li>
                    </ul>
                    <div class="tab-content" id="myTabContent">
                      <div class="tab-pane fade show active" id="backUp" role="tabpanel" aria-labelledby="backUp-tab">
                          <br />
                          <asp:Button CssClass="btn btn-warning" Text="BackUp" runat="server" ID="btnBackUp" OnClick="btnBackUp_Click" />
                      </div>
                      <div class="tab-pane fade" id="restore" role="tabpanel" aria-labelledby="restore-tab">
                          <br />
                          <asp:ListBox ID="listBackUp" runat="server"></asp:ListBox><br />
                          <asp:Button CssClass="btn btn-warning" ID="btnRestore" runat="server" Text="Restore" OnClick="btnRestore_Click" />
                      </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
