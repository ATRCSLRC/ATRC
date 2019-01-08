<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="ChecadorEmpleados.aspx.cs" Inherits="Checador.ChecadorEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">


    <div class="row">
        <div class="col-sm-2">
        </div>
        <div class="col-sm-8 Contenedor">
            <div class="imgcontainer animate-zoom " id="IMG_Container">
                <img src="Img/logo.jpg" class="avatar btn btn-warning" onerror="this.src='Img/logo.jpg'" id="Detalles"/>
            </div>
            <div style="cursor: none; z-index: 0;">
                <dx:BootstrapButtonEdit ID="bteNumEmpleado" ClientInstanceName="bteNumEmpleado" Width="100%" EnableViewState="false"
                    CssClasses-Control="Centered" CssClasses-NullText="Centered" NullTextDisplayMode="UnfocusedAndFocused"
                    CssClasses-Caption="Centered" CssClasses-Button="btn btn-success" NullText="Escanée el gafete" runat="server">
                    <Buttons>
                        <dx:BootstrapEditButton IconCssClass="fa fa-th" />
                    </Buttons>
                    <ClientSideEvents ButtonClick="function(s,e){popupTeclado.Show();}" TextChanged="function(s,e){Manual();}"
                        LostFocus="function(s,e){ bteNumEmpleado.SetFocus();}" />
                </dx:BootstrapButtonEdit>
            </div>
        </div>
        <div class="col-sm-2">
        </div>
    </div>

    <dx:BootstrapPopupControl ID="popupTeclado" ClientInstanceName="popupTeclado" EnableViewState="false" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false" runat="server">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <HeaderTemplate>
            <h4 id="Title"><span class="fa fa-th"></span>Escriba su número de empleado</h4>
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
                <Badge IconCssClass="fa fa-check" />
                <ClientSideEvents Click="function(s,e){ ChecaManual(); bteManual.SetText(''); Numero = ''; bteNumEmpleado.SetVisible(false); popupTeclado.Hide(); }" />
            </dx:BootstrapButton>

            <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" EnableViewState="false" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                <SettingsBootstrap RenderOption="Danger" />
                <Badge IconCssClass="fa fa-remove" />
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
                                    <dx:BootstrapListBox ID="lstEntradas" EnableViewState="false" ClientInstanceName="lstEntradas" runat="server" SelectedIndex="-1" EncodeHtml="true" ReadOnly="true" CssClasses-Item=" list-group-item-heading list-group-item-success">
                                    </dx:BootstrapListBox>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                        <dx:BootstrapTabPage Text="Salidas" TabCssClass="list-group-item-danger">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <dx:BootstrapListBox ID="lstSalida" EnableViewState="false" ClientInstanceName="lstSalida" runat="server" SelectedIndex="-1" EncodeHtml="true" ReadOnly="true" CssClasses-Item="list-group-item-heading list-group-item-danger">
                                    </dx:BootstrapListBox>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:BootstrapTabPage>
                    </TabPages>
                </dx:BootstrapPageControl>
            </dx:ContentControl>
        </ContentCollection>
        <FooterTemplate>
            <dx:BootstrapButton ID="btnLimpiar" ClientInstanceName="btnLimpiar" Text="Limpiar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                <SettingsBootstrap RenderOption="Warning" />
                <Badge IconCssClass="fa fa-trash" />
                <ClientSideEvents Click="function(s,e){ lstEntradas.ClearItems(); lstSalida.ClearItems();  popupDetalle.Hide(); }" />
            </dx:BootstrapButton>

            <dx:BootstrapButton ID="btnSalir" ClientInstanceName="btnSalir" Text="Salir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                <SettingsBootstrap RenderOption="Danger" />
                <Badge IconCssClass="fa fa-remove" />
                <ClientSideEvents Click="function(s,e){ popupDetalle.Hide(); }" />
            </dx:BootstrapButton>
        </FooterTemplate>
    </dx:BootstrapPopupControl>
</asp:Content>
