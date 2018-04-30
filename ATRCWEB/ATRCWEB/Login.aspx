<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ATRCWEB.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../Content/bootstrap.min.css"/>
</head>
<body>
    <div class="container">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="padding: 10px 10px; text-align: center; background-color: red">
                    <div class="form-group">
                        <div class="imgcontainer">
                            <img src="img/logo.jpg" alt="Logo" style="width: 40%" class="img-circle" />
                        </div>
                        <h3 style="color: white">Inicio de sesión</h3>
                    </div>
                </div>
                <div class="modal-body" style="padding: 40px 50px;">
                    <form role="form" id="form1" runat="server">
                        <div id="divUser" class="form-group to-animate-2">
                            <label class="control-label"><span class="fa fa-user"></span>Número de usuario</label>
                            <dx:BootstrapSpinEdit ID="spnNumUsuario" ClientInstanceName="spnNumUsuario" MinValue="0" MaxValue="9999" NullText="Ingresé su número de usuario" AllowMouseWheel="false" runat="server">
                                <SpinButtons ShowIncrementButtons="false" ShowLargeIncrementButtons="false" />
                            </dx:BootstrapSpinEdit>
                        </div>
                        <div id="divPass" class="form-group to-animate">
                            <label class="control-label"><span class="fa fa-key"></span>Contraseña</label>
                            <dx:BootstrapTextBox ID="txtContraseña" ClientInstanceName="txtContraseña" Password="true" NullText="Ingresé su contraseña" runat="server"></dx:BootstrapTextBox>
                        </div>
                        <dx:BootstrapButton ID="btnLogin" ClientInstanceName="btnLogin" runat="server" CssClasses-Control="btn-block" AutoPostBack="false" Text="Entrar">
                            <Badge IconCssClass="fa fa-save" />
                            <SettingsBootstrap RenderOption="Success" />
                            <ClientSideEvents Click="function(s,e){ CallbackLogin.PerformCallback(); }" />
                        </dx:BootstrapButton>
                        <dx:ASPxCallback ID="CallbackLogin" ClientInstanceName="CallbackLogin" OnCallback="CallbackLogin_Callback" runat="server">
                            <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){ alert(e.result);}}" />
                        </dx:ASPxCallback>
                    </form>
                </div>

            </div>
        </div>
    </div>
</body>

</html>
