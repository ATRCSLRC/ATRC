<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorteo.aspx.cs" Inherits="ATRCWEB.Sorteo" %>

<!DOCTYPE html>

<html>
<head>
    <title>Sorteo ATRC</title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css">
    <link rel="stylesheet" href="../Content/font-awesome.min.css">
    <style type="text/css">
        #confetti {
            position: relative;
            top: 0;
            left: 0;
            z-index: 1;
        }

        #settings {
            display: inline-block;
            overflow: hidden;
            position: absolute;
            background: rgba(255,255,255,1);
            padding: 20px;
            margin: 0 auto;
            top: 10%;
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
    </style>
</head>

<body>

    <canvas id="confetti"></canvas>
    <div class="container">
        <form runat="server">
            
            <div id="settings" style=" height: 782px; background-image: url(../img/wheel_back.png); background-repeat: no-repeat; background-position: center; padding-left: 23px; padding-top: 94px;" align="center">
                <div class="box-tools pull-right">
                <dx:BootstrapButton ID="btnAgregarEmpleados" ClientInstanceName="btnAgregarEmpleados" runat="server" AutoPostBack="false" Text="Agregar Empleados">
                    <SettingsBootstrap RenderOption="Warning" />
                    <Badge IconCssClass="fa fa-plus" />
                    <ClientSideEvents Click="function(s,e){ grdEmpleados.Refresh(); PopupEmpleados.Show(); }" />
                </dx:BootstrapButton>
                    </div>
            <br />
            <br />
                <br />
            <br />
                <canvas id="canvas" width="434" height="434">
                    <p style="{color: white}" align="center">Sorry, your browser doesn't support canvas. Please try another.</p>
                </canvas>
                <br />
                    <br />
                <dx:BootstrapButton ID="BootstrapButton2" runat="server" AutoPostBack="false" Text="Iniciar">
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
                        <ClientSideEvents Click="function(s,e){ grdEmpleados.GetSelectedFieldValues('NumEmpleado', OnGetSelectedFieldValues); PopupEmpleados.Hide(); }" />
                    </dx:BootstrapButton>

                    <dx:BootstrapButton ID="btnSalir" ClientInstanceName="btnSalir" Text="Salir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <Badge IconCssClass="fa fa-remove" />
                        <ClientSideEvents Click="function(s,e){ PopupEmpleados.Hide(); }" />
                    </dx:BootstrapButton>
                </FooterTemplate>
            </dx:BootstrapPopupControl>
            <dx:BootstrapPopupControl ID="PopupGanador" ClientInstanceName="PopupGanador" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false" runat="server">
                <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                <HeaderTemplate>
                    <h4></span>Ganador</h4>
                </HeaderTemplate>
                <ContentCollection>
                    <dx:ContentControl>
                        <dx:BootstrapCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" EnableCallbackAnimation="true" OnCallback="CallbackPanel_Callback" runat="server" Width="100%">
                            <ContentCollection>
                                <dx:ContentControl>
                                    <div class="imgcontainer">
                                    <dx:BootstrapBinaryImage ID="imgFoto" align="center" CssClasses-Control="avatar" runat="server"></dx:BootstrapBinaryImage>
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
            <dx:ASPxCallback ID="CallbackEmpleados" ClientInstanceName="CallbackEmpleados"  runat="server">
                <ClientSideEvents CallbackComplete="function(){ PopupGanador.Show(); }" />
            </dx:ASPxCallback>
        </form>
    </div>
</body>

</html>
<script type="text/javascript" src="js/Winwheel.js"></script>
<script type="text/javascript" src="js/Confetti.js"></script>
<script src="http://cdnjs.cloudflare.com/ajax/libs/gsap/latest/TweenMax.min.js"></script>
<script>
    var confettiSettings = { target: 'confetti' };
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
                'duration': 6,
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
        var winningSegment = theWheel.getIndicatedSegment();
        PopupGanador.Show();
        CallbackPanel.PerformCallback(winningSegment.text);
        confetti.render();
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
</script>
