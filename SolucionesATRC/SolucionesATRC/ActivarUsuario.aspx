<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Exterior.Master" CodeBehind="ActivarUsuario.aspx.cs" Inherits="SolucionesATRC.ActivarUsuario" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    
    <div id="fun" class=" funfacts">
        <%--<div class="modal-dialog">--%>
            <%--<div id="fun" class="col">--%>
                 <img class="slide one" src="Content/Exterior/SCHOOL.PNG"  />
           <%-- </div>--%>
       <div class="container form-group">
        <div class="row form-group justify-content-end">
                <div class="col-5">
                </div>
                <div class="col-5">
                
        <div class="container form-group">

            <div class="row form-group justify-content-center">
                <div class="col">
                    <p class="col-12 demo-content-title">Activacion de usuario</p>
                </div>
            </div>
            <div class="row form-group">
                <div class="col">
                    <p class="col-12 demo-content">Para continuar, debe ingresar una contrasena.</p>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-12">
                    <dx:BootstrapTextBox ID="BootstrapTextBox1" NullText="Contraseña" runat="server"></dx:BootstrapTextBox>
                </div>
            </div>
            <div class="row form-group">
                <div class="col">
                    <dx:BootstrapTextBox ID="BootstrapTextBox2" NullText="Confirmar Contraseña" runat="server"></dx:BootstrapTextBox>
                </div>
            </div>
            <div class="row form-group justify-content-center">
                <div class="col-3">
                    <dx:BootstrapButton ID="BootstrapButton1" runat="server" AutoPostBack="false" Text="Button"></dx:BootstrapButton>
                </div>
            </div>

        </div>
                </div>
            </div>
        </div>
        </div>
        
</asp:Content>
