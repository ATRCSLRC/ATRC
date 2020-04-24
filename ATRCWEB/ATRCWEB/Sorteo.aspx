<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorteo.aspx.cs" Inherits="ATRCWEB.Sorteo" %>

<!DOCTYPE html>

<html>
<head>
    <title>Sorteo ATRC</title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css">
    <link rel="stylesheet" href="../Content/font-awesome.min.css">
    <script src="../js/jquery.min.js"></script>
    <!-- Bootstrap 3.3.7 -->
    <script src="../js/bootstrap.min.js"></script>
    <style type="text/css">
        #confetti {
            /*position: relative;
            top: 0;
            left: 0;
            z-index: 1;*/
            position: absolute;
        }

        #settings {
            display: inline-block;
            overflow: hidden;
            background: rgba(255,255,255,1);
            padding: 20px;
            margin: 0 auto;
            top: 5%;
            left: 0;
            right: 0;
            width: 80%;
            max-width: 600px;
            z-index: 9;
        }

        img.avatar {
            max-width: 201px;
            max-height: 180px;
            width: 40%;
            border-radius: 50%;
            cursor: none;
        }

        .imgcontainer {
            text-align: center;
            margin: 6px 0 6px 0;
            position: relative;
            cursor: none;
        }

        .header {
            font-size: x-large;
            font-weight: bold;
        }

        .modal-header, #Title {
        color: white !important;
        /*text-align: left;
        padding: 7px;
        font-size: 20px;*/
        background-color: red;
    }
    </style>
</head>

<body>

    <canvas id="confetti"></canvas>
    <%--<div class="container">--%>
    <div>&nbsp&nbsp&nbsp&nbsp</div>
    <div>&nbsp&nbsp&nbsp&nbsp</div>
    <form runat="server" align="center">
        <div class="col-sm-6 col-sm-offset-3">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    <h4 class="panel-title">
                        <a class="collapsed" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true"
                            href="#collapseOne">
                            <i class="nav-link-text fa fa-fw fa fa-info-circle"></i>
                            <span class="nav-link-text">Sorteos ATRC</span>
                        </a>
                    </h4>
                </div>
                <%--<div class="panel-heading">Sorteos ATRC</div>--%>
                <div id="collapseOne" class="panel-collapse collapse in">
                <div class="panel-body">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 10%">
                                <label class="control-label">Premio:&nbsp</label><span id="Span1" runat="server"></span>
                            </td>
                            <td>
                                <dx:BootstrapTextBox ID="txtPremio" ClientInstanceName="txtPremio" NullText="Premio (Emplaedo del mes, etc.)" runat="server"></dx:BootstrapTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label class="control-label">Número de intentos:&nbsp</label><span id="Span2" runat="server"></span>
                            </td>
                            <td>
                                <dx:BootstrapSpinEdit ID="spinIntentos" ClientInstanceName="spinIntentos" MinValue="0" MaxValue="99" MaxLength="2" Number="1" runat="server"></dx:BootstrapSpinEdit>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <dx:BootstrapRadioButtonList ID="rblSorteo" ClientInstanceName="rblSorteo" runat="server" RepeatColumns="2" SelectedIndex="0">
                                    <Items>
                                        <dx:BootstrapListEditItem Selected="True" Text="Empleados" Value="Empleados">
                                        </dx:BootstrapListEditItem>
                                        <dx:BootstrapListEditItem Text="Boletos" Value="Boletos">
                                        </dx:BootstrapListEditItem>
                                    </Items>
                                    <ClientSideEvents SelectedIndexChanged ="function(s,e){ if(s.GetValue() == 'Boletos'){document.getElementById('Boletos').style.display = 'block'; document.getElementById('Empleados').style.display = 'none'; }else{document.getElementById('Boletos').style.display = 'none'; document.getElementById('Empleados').style.display = 'block';}} " />
                                </dx:BootstrapRadioButtonList>
                            </td>
                        </tr>
                    </table>
                    <div id="Empleados">
                        <dx:BootstrapButton ID="btnAgregarEmpleados" ClientInstanceName="btnAgregarEmpleados" EnableViewState="false" UseSubmitBehavior="false" runat="server" AutoPostBack="false" Text="Agregar Empleados">
                            <SettingsBootstrap RenderOption="Warning" />
                            <Badge IconCssClass="fa fa-plus" />
                            <ClientSideEvents Click="function(s,e){ grdEmpleados.Refresh(); PopupEmpleados.Show(); }" />
                        </dx:BootstrapButton>
                    </div>
                    <div id="Boletos" style="width: 100%; display:none">
                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <dx:BootstrapSpinEdit ID="spnInicial" ClientInstanceName="spnInicial" runat="server"></dx:BootstrapSpinEdit>
                                </td>
                                <td>
                                    <label class="control-label">a:&nbsp</label><span id="Span3" runat="server"></span>
                                </td>
                                <td>
                                    <dx:BootstrapSpinEdit ID="spnFinal" ClientInstanceName="spnFinal" runat="server"></dx:BootstrapSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp</td>
                                </tr>
                            <tr>
                                <td colspan="3" align="right">
                                    <dx:BootstrapButton ID="btnAgregarBoletos" ClientInstanceName="btnAgregarBoletos" EnableViewState="false" UseSubmitBehavior="false" runat="server" AutoPostBack="false" Text="Agregar Boletos">
                                        <SettingsBootstrap RenderOption="Warning" />
                                        <Badge IconCssClass="fa fa-plus" />
                                        <ClientSideEvents Click="function(s,e){ OnGetSelectedFieldValuesBoletos(spnInicial.GetValue(), spnFinal.GetValue()); }" />
                                    </dx:BootstrapButton>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                </div>
            </div>
            
        </div>
        <div id="settings" style="height: 594px; background-image: url(../img/wheel_back.png); background-repeat: no-repeat; background-position: center; padding-left: 24px; padding-top: 0px;">

            <%--<div class="box-tools pull-right">
                
            </div>--%>
            <br />
            <br />
            <br />
            <br />
            <canvas id="canvas" width="434" height="434">
                <p style="{color: white}" align="center">Sorry, your browser doesn't support canvas. Please try another.</p>
            </canvas>
            <br />
            <br />
            <dx:BootstrapButton ID="BootstrapButton2" runat="server" EnableViewState="false" UseSubmitBehavior="false" AutoPostBack="false" Text="Iniciar">
                <SettingsBootstrap RenderOption="Success" />
                <Badge IconCssClass="fa fa-play" />
                <ClientSideEvents Click="function(s,e){ startSpin(); }" />
            </dx:BootstrapButton>
        </div>
        <dx:BootstrapPopupControl ID="PopupEmpleados" ClientInstanceName="PopupEmpleados" ShowHeader="true" HeaderText="Seleccionar empleados" ShowFooter="true" CloseAction="None" ShowCloseButton="false" runat="server">
            <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
            <ContentCollection>
                <dx:ContentControl>
                    <dx:BootstrapGridView ID="grdEmpleados" ClientInstanceName="grdEmpleados" OnDataBinding="grdEmpleados_DataBinding" runat="server" KeyFieldName="NumEmpleado">
                        <SettingsPager PageSize="15"></SettingsPager>
                        <Settings ShowFilterRow="true" />
                        <Columns>
                            <dx:BootstrapGridViewCommandColumn ShowSelectCheckbox="True" SelectAllCheckboxMode="AllPages" />
                            <dx:BootstrapGridViewDataColumn FieldName="NumEmpleado" />
                            <dx:BootstrapGridViewDataColumn FieldName="Nombre" />
                        </Columns>
                    </dx:BootstrapGridView>
                </dx:ContentControl>
            </ContentCollection>
            <FooterTemplate>
                <dx:BootstrapButton ID="btnAgregar" ClientInstanceName="btnAgregar" Text="Agregar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                    <SettingsBootstrap RenderOption="Warning" />
                    <Badge IconCssClass="fa fa-trash" />
                    <ClientSideEvents Click="function(s,e){ grdEmpleados.GetSelectedFieldValues('NumEmpleado', OnGetSelectedFieldValues); PopupEmpleados.Hide(); grdEmpleados.UnselectRows(); }" />
                </dx:BootstrapButton>

                <dx:BootstrapButton ID="btnSalir" ClientInstanceName="btnSalir" Text="Salir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                    <SettingsBootstrap RenderOption="Danger" />
                    <Badge IconCssClass="fa fa-remove" />
                    <ClientSideEvents Click="function(s,e){  PopupEmpleados.Hide(); grdEmpleados.UnselectRows(); }" />
                </dx:BootstrapButton>
            </FooterTemplate>
        </dx:BootstrapPopupControl>
        <dx:BootstrapPopupControl ID="PopupGanador" ClientInstanceName="PopupGanador" ShowHeader="true" ShowFooter="true" HeaderText="Ganador" CloseAction="None" ShowCloseButton="false" runat="server">
            <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
            <CssClasses Header="header" />
            <ContentCollection>
                <dx:ContentControl>
                    <dx:BootstrapCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" EnableCallbackAnimation="true" OnCallback="CallbackPanel_Callback" runat="server" Width="100%">
                        <ContentCollection>
                            <dx:ContentControl>
                                <div class="imgcontainer">
                                    <dx:BootstrapBinaryImage ID="imgFoto" EmptyImageUrl="~/img/logo.jpg" align="center" CssClasses-Control="avatar" runat="server"></dx:BootstrapBinaryImage>
                                    <dx:ASPxLabel ID="lblGanador" ClientInstanceName="lblGanador" Font-Bold="true" Font-Size="Larger" align="center" Width="100%" runat="server" Text=""></dx:ASPxLabel>
                                </div>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapCallbackPanel>
                </dx:ContentControl>
            </ContentCollection>
            <FooterTemplate>
                <dx:BootstrapButton ID="btnSalir" ClientInstanceName="btnSalir" Text="Salir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                    <SettingsBootstrap RenderOption="Danger" />
                    <Badge IconCssClass="fa fa-remove" />
                    <ClientSideEvents Click="function(s,e){ confetti.clear(); PopupGanador.Hide(); }" />
                </dx:BootstrapButton>
            </FooterTemplate>
        </dx:BootstrapPopupControl>
        <dx:ASPxCallback ID="CallbackEmpleados" ClientInstanceName="CallbackEmpleados" runat="server">
            <ClientSideEvents CallbackComplete="function(){ PopupGanador.Show(); }" />
        </dx:ASPxCallback>
    </form>
    <%--</div>--%>
</body>

</html>
<script type="text/javascript" src="js/Winwheel.js"></script>
<script type="text/javascript" src="js/Confetti.js"></script>
<script src="http://cdnjs.cloudflare.com/ajax/libs/gsap/latest/TweenMax.min.js"></script>
<script>
    var confettiSettings = { target: 'confetti' };
    var ida = 1;
    var confetti = new window.ConfettiGenerator(confettiSettings);
    var theWheel = new Winwheel({
        'numSegments': 1,
        'outerRadius': 212,
        'innerRadius': 120,
        'textMargin': 0,
        'textOrientation': 'vertical',
        'segments':
            [
            ],
        'animation':
            {
                'type': 'spinToStop',
                'duration': 3,
                'spins': 8,
                'callbackFinished': 'alertPrize()'
            }
    });

    function startSpin() {
        resetWheel();
        theWheel.startAnimation();
        wheelSpinning = true;
    }

    function resetWheel() {
        theWheel.stopAnimation(false);
        theWheel.rotationAngle = 0;
        theWheel.draw();
    }

    function alertPrize() {
        //setTimeout(function () {
            var ganador = theWheel.getIndicatedSegment();
            if (ida == spinIntentos.GetValue()) {
                PopupGanador.SetHeaderText('Ganador de ' + txtPremio.GetText());
                PopupGanador.Show();
                if (rblSorteo.GetValue() == "Boletos") {
                    lblGanador.SetText("Número de boleto ganador " + ganador.text);
                } else {
                    CallbackPanel.PerformCallback(ganador.text);
                }
                
                confetti.render();
                theWheel.deleteSegment(theWheel.getIndicatedSegmentNumber());
                theWheel.draw();
                ida = 1;
            } else {
                ida++;
                PopupGanador.SetHeaderText('Descalificado');
                theWheel.deleteSegment(theWheel.getIndicatedSegmentNumber());
                theWheel.draw();
                CallbackPanel.PerformCallback(ganador.text);
                PopupGanador.Show();
            }
        //}, 1500);
    }

    function OnGetSelectedFieldValues(selectedValues) {
        if (selectedValues.length == 0) return;
        var color = 1;
        for (i = 0; i < selectedValues.length; i++) {
            var newSegment = theWheel.addSegment();
            newSegment.text = selectedValues[i].toString();
            switch (color) {
                case 1:
                    newSegment.fillStyle = '#FF0033';
                    color = 2;
                    break;
                case 2:
                    newSegment.fillStyle = '#CCFF33';
                    color = 3;
                    break;
                case 3:
                    newSegment.fillStyle = '#FDFEFE';
                    color = 1;
                    break;
            }
        }
        theWheel.deleteSegment(1);
        theWheel.draw();
    }

    function OnGetSelectedFieldValuesBoletos(inicial, final) {
        var color = 1;
        for (i = inicial; i <= final; i++) {
            var newSegment = theWheel.addSegment();
            newSegment.text = i.toString();
            switch (color) {
                case 1:
                    newSegment.fillStyle = '#FF0033';
                    color = 2;
                    break;
                case 2:
                    newSegment.fillStyle = '#CCFF33';
                    color = 3;
                    break;
                case 3:
                    newSegment.fillStyle = '#FDFEFE';
                    color = 1;
                    break;
            }
        }
        theWheel.deleteSegment(1);
        theWheel.draw();
    }
</script>
