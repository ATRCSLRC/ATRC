<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChecadorEmpleados.aspx.cs" Inherits="ATRCWEB.ChecadorEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
</head>
    <style>
    h1, h2, h3, h4, h5 {
        margin: 0px;
    }

    html, body {
        height: 100%;
        width: 100%;
        cursor: none;
    }

    a {
        color: inherit;
    }

    .btn {
        cursor: none;
    }

    .imgcontainer {
        text-align: center;
        margin: 6px 0 6px 0;
        position: relative;
        cursor: none;
    }

    img.avatar {
        max-width: 201px;
        max-height: 180px;
        width: 35%;
        border-radius: 50%;
        cursor: none;
    }

    .container-fluid {
        padding: 0px;
        margin: 0px;
        height: 100%
    }

    .row {
        padding: 0px;
        margin: 0px;
    }

    .Header {
        background-color: red;
        width: 100%;
        height: 30%;
        color: white;
        text-shadow: 2px 2px #404040;
    }

    .Body {
        height: 50%;
        border-top: 5px;
        border-bottom: 5px;
        border-style: solid;
        border-color: #F0AD4E;
    }

    .Footer {
        text-shadow: 2px 2px #404040;
        background-color: red;
        color: white;
        width: 100%;
        height: 20%;
        text-align: center;
        font-size: 2.5em;
    }

    .Contenido {
        height: 100%;
    }

    .Centered input {
        text-align: center;
        cursor: none;
    }

    #fecha {
        text-align: center;
        font-size: 3em;
    }

    #hora {
        text-align: center;
        font-size: 3.5em;
    }

    #mensaje {
        text-align: center;
        font-size: 0.7em;
    }
    /* Add Zoom Animation */
    .animate-zoom {
        -webkit-animation: animatezoom 0.6s;
        animation: animatezoom 0.6s;
    }

    .btn-danger {
        background-color: red;
        border-color: red;
    }

    @-webkit-keyframes animatezoom {
        from {
            -webkit-transform: scale(0)
        }

        to {
            -webkit-transform: scale(1)
        }
    }

    @keyframes animatezoom {
        from {
            transform: scale(0)
        }

        to {
            transform: scale(1)
        }
    }

    .modal-content {
        border-radius: 0;
    }

        .modal-content .row {
            margin: 2px;
        }

    .modal-header, #Title {
        color: white !important;
        text-align: left;
        padding: 7px;
        font-size: 20px;
        background-color: red;
    }

    /* CONFIGURACION DE COLLAPSE */
    .collapse {
        margin-top: 5px;
        margin-bottom: 5px;
    }

    div.accordion:hover {
        cursor: pointer;
        background-color: #ddd;
    }

    div.accordion {
        border-style: solid;
        border-width: 2px;
        border-color: #ddd;
        border-left-width: 20px;
        color: #444;
        background-color: #eee;
    }
</style>
<script type="text/javascript">
    var Numero = "";
    function PrepareTimeValue(value) {
        if (value < 10)
            value = "0" + value;
        return value;
    }
    var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };

    function UpdateTime(s, e) {
        var dateTime = new Date();
        var timeString = PrepareTimeValue(dateTime.getHours()) + ":" + PrepareTimeValue(dateTime.getMinutes()) + ":" +
            PrepareTimeValue(dateTime.getSeconds());
        document.getElementById("hora").innerHTML = timeString;
        document.getElementById("fecha").innerHTML = dateTime.toLocaleDateString('MX', options);
    }
    function Concatenar(Num) {
        if (Numero.length > 6) {
            return;
        }
        Numero += "" + Num;
        bteManual.SetText(Numero);
    }

    function Delete() {
        Numero = Numero.slice(0, Numero.length - 1);
        bteManual.SetText(Numero);
    }
</script>
<body style="height: 100%" oncontextmenu="return false;" onload="bteNumEmpleado.SetFocus();">

    <div class="Header">
        <div class="row">
            <div id="fecha">
               <%-- <%:  char.ToUpper(DateTime.Now.ToLongDateString()[0]) + DateTime.Now.ToLongDateString().Substring(1) %>--%>
            </div>
        </div>
        <div class="row">
            <div id="hora">
            </div>
        </div>
    </div>
    <div class="Body">
        <div class="row">
            <form runat="server">
                <div class="col-sm-2">
                </div>
                <div class="col-sm-8 Contenedor">
                    <%--<br />--%>
                    <%--<dx:ASPxBinaryImage ID="ASPxBinaryImage1" ClientInstanceName="ASPxBinaryImage1" LoadingImageUrl="~/img/logo.jpg" OnDataBinding="ASPxBinaryImage1_DataBinding"  CssClasses-Control="avatar btn btn-warning" OnCustomCallback="ASPxBinaryImage1_CustomCallback" EmptyImage-Url="~/img/logo.jpg" runat="server"></dx:ASPxBinaryImage>--%>
                    <div class="imgcontainer animate-zoom " id="IMG_Container" ondblclick="popupDetalle.Show();">
                        <dx:BootstrapCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" EnableViewState="false" EnableCallbackAnimation="true" OnCallback="CallbackPanel_Callback" runat="server" Width="100%">
                            <ContentCollection>
                                <dx:ContentControl>

                                    <dx:BootstrapBinaryImage ID="bbimg" ClientInstanceName="bbimg" EnableViewState="false" CssClasses-Control="avatar btn btn-warning" EmptyImageUrl="~/img/logo.jpg" runat="server">
                                    </dx:BootstrapBinaryImage>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapCallbackPanel>
                    </div>
                    <%--<br />--%>
                    <div style="cursor: none; z-index: 10;">

                        <dx:BootstrapButtonEdit ID="bteNumEmpleado" ClientInstanceName="bteNumEmpleado" EnableViewState="false" CssClasses-Control="Centered" CssClasses-NullText="Centered" NullTextDisplayMode="UnfocusedAndFocused" CssClasses-Caption="Centered" CssClasses-Button="btn btn-success" NullText="Escanée el gafete" runat="server">
                            <Buttons>
                                <dx:BootstrapEditButton IconCssClass="glyphicon glyphicon-th" />
                            </Buttons>
                            <ClientSideEvents ButtonClick="function(s,e){ popupTeclado.Show();}" TextChanged="function(s,e){ Callback.PerformCallback(bteNumEmpleado.GetText() +'|gafete'); bteNumEmpleado.SetVisible(false); bteNumEmpleado.SetText(''); }"
                                LostFocus="function(s,e){ bteNumEmpleado.SetFocus();}" />
                        </dx:BootstrapButtonEdit>

                        <dx:ASPxCallback ID="Callback" ClientInstanceName="Callback" EnableViewState="false" OnCallback="Callback_Callback" runat="server">
                            <ClientSideEvents CallbackComplete="function(s,e){CallbackPanel.PerformCallback(); document.getElementById('mensaje').innerHTML = e.result; lstEntradas.PerformCallback(); lstSalida.PerformCallback();
                                setTimeout(function(){ document.getElementById('mensaje').innerHTML = ''; CallbackPanel.PerformCallback('logo'); bteNumEmpleado.SetVisible(true); bteNumEmpleado.SetFocus(); },2500);   }" />
                        </dx:ASPxCallback>
                    </div>
                </div>
                <div class="col-sm-2">
                </div>
                <dx:BootstrapPopupControl ID="popupTeclado" ClientInstanceName="popupTeclado" EnableViewState="false" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false" runat="server">
                    <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                    <HeaderTemplate>
                        <h4 id="Title"><span class="glyphicon glyphicon-th"></span>Escriba su número de empleado</h4>
                    </HeaderTemplate>
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <div class="row">
                                <dx:BootstrapButtonEdit ID="bteManual" ClientInstanceName="bteManual" CssClasses-Control="Centered" CssClasses-Button="btn btn-danger" runat="server">
                                    <Buttons>
                                        <dx:BootstrapEditButton Text="DEL" />
                                    </Buttons>
                                    <ClientSideEvents ButtonClick="function(s,e){ Delete(); }" />
                                </dx:BootstrapButtonEdit>
                            </div>
                            <div class="row">
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('7');">
                                    <h1>7</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('8');">
                                    <h1>8</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('9');">
                                    <h1>9</h1>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('4');">
                                    <h1>4</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('5');">
                                    <h1>5</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('6');">
                                    <h1>6</h1>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('1');">
                                    <h1>1</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('2');">
                                    <h1>2</h1>
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('3');">
                                    <h1>3</h1>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-4">
                                </div>
                                <div class="col-xs-4 btn btn-success" onclick="Concatenar('0');">
                                    <h1>0</h1>
                                </div>
                                <div class="col-xs-4">
                                </div>
                            </div>
                        </dx:ContentControl>
                    </ContentCollection>
                    <FooterTemplate>
                        <dx:BootstrapButton ID="btnAceptar" ClientInstanceName="btnAceptar" EnableViewState="false" Text="Aceptar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                            <SettingsBootstrap RenderOption="Success" />
                            <Badge IconCssClass="glyphicon glyphicon-ok" />
                            <ClientSideEvents Click="function(s,e){ Callback.PerformCallback(bteManual.GetText() +'|manual'); bteManual.SetText(''); Numero = ''; bteNumEmpleado.SetVisible(false); popupTeclado.Hide(); }" />
                        </dx:BootstrapButton>

                        <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" EnableViewState="false" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                            <SettingsBootstrap RenderOption="Danger" />
                            <Badge IconCssClass="glyphicon glyphicon-remove" />
                            <ClientSideEvents Click="function(s,e){ bteManual.SetText(''); Numero = ''; popupTeclado.Hide(); }" />
                        </dx:BootstrapButton>
                    </FooterTemplate>
                </dx:BootstrapPopupControl>
                <dx:BootstrapPopupControl ID="popupDetalle" ClientInstanceName="popupDetalle" EnableViewState="false" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false" runat="server">
                    <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                    <HeaderTemplate>
                        <h4 id="Title"><span class="fa fa-address-card"></span>Detallado de checadas</h4>
                    </HeaderTemplate>
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" ActiveTabIndex="0">
                                <TabPages>
                                    <dx:BootstrapTabPage Text="Entradas" TabCssClass="list-group-item-success">
                                        <ContentCollection>
                                            <dx:ContentControl runat="server">
                                                <dx:BootstrapListBox ID="lstEntradas" EnableViewState="false" ClientInstanceName="lstEntradas" runat="server" OnCallback="lstEntradas_Callback" SelectedIndex="-1" ReadOnly="true" CssClasses-Item="list-group-item-success">
                                                    <ItemTemplate>
                                                        <div class="list-group-item list-group-item-success">
                                                            <h5 class="list-group-item-heading" style="font-weight: 600"><%# Eval("Usuario!.Usuario!.NumEmpleado") %> - <%# Eval("Usuario!.Usuario!.Nombre") %></h5>
                                                            <p class="list-group-item-text">Entrada: <%# ((DateTime)Eval("FechaChecada")).ToShortDateString() %> <%# Eval("HoraChecadaEntrada") %></p>
                                                        </div>
                                                    </ItemTemplate>
                                                </dx:BootstrapListBox>
                                            </dx:ContentControl>
                                        </ContentCollection>
                                    </dx:BootstrapTabPage>
                                    <dx:BootstrapTabPage Text="Salidas" TabCssClass="list-group-item-danger">
                                        <ContentCollection>
                                            <dx:ContentControl runat="server">
                                                <dx:BootstrapListBox ID="lstSalida" EnableViewState="false" ClientInstanceName="lstSalida" runat="server" OnCallback="lstSalida_Callback" SelectedIndex="-1"  ReadOnly="true" CssClasses-Item="list-group-item-danger">
                                                    <ItemTemplate>
                                                        <div class="list-group-item list-group-item-danger">
                                                            <h5 class="list-group-item-heading" style="font-weight: 600"><%# Eval("Usuario!.Usuario!.NumEmpleado") %> - <%# Eval("Usuario!.Usuario!.Nombre") %></h5>
                                                            <p class="list-group-item-text">Salida: <%# ((DateTime)Eval("FechaChecada")).ToShortDateString() %> <%# Eval("HoraChecadaSalida") %></p>
                                                        </div>
                                                    </ItemTemplate>
                                                </dx:BootstrapListBox>
                                            </dx:ContentControl>
                                        </ContentCollection>
                                    </dx:BootstrapTabPage>
                                </TabPages>
                            </dx:BootstrapPageControl>
                        </dx:ContentControl>
                    </ContentCollection>
                    <FooterTemplate>
                        <dx:BootstrapButton ID="btnLimpiar" ClientInstanceName="btnLimpiar" Text="Limpiar"  AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                            <SettingsBootstrap RenderOption="Warning" />
                            <Badge IconCssClass="glyphicon glyphicon-trash" />
                            <ClientSideEvents Click="function(s,e){ CallbackLimpiar.PerformCallback();  popupDetalle.Hide(); }" />
                        </dx:BootstrapButton>
                        <dx:ASPxCallback ID="CallbackLimpiar" EnableViewState="false" ClientInstanceName="CallbackLimpiar" OnCallback="CallbackLimpiar_Callback" runat="server">
                            <ClientSideEvents CallbackComplete="function(s,e){ lstEntradas.PerformCallback(); lstSalida.PerformCallback(); popupDetalle.Hide(); }"/>
                        </dx:ASPxCallback>

                        <dx:BootstrapButton ID="btnSalir" ClientInstanceName="btnSalir" Text="Salir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                            <SettingsBootstrap RenderOption="Danger" />
                            <Badge IconCssClass="glyphicon glyphicon-remove" />
                            <ClientSideEvents Click="function(s,e){ popupDetalle.Hide(); }" />
                        </dx:BootstrapButton>
                    </FooterTemplate>
                </dx:BootstrapPopupControl>

                <dx:ASPxTimer runat="server" ID="Timer" EnableViewState="false" ClientInstanceName="timer" Interval="1000">
                    <ClientSideEvents Init="UpdateTime" Tick="UpdateTime" />
                </dx:ASPxTimer>
            </form>
        </div>

    </div>
    <div class="Footer">
        <div id="mensaje">
        </div>
    </div>
</body>

</html>
