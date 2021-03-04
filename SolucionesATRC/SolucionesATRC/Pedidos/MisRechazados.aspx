<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="MisRechazados.aspx.cs" Inherits="SolucionesATRC.Pedidos.MisRechazados" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Pedidos rechazados y cancelados</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdPedidos" ClientInstanceName="grdPedidos" OnDataBinding="grdPedidos_DataBinding" SettingsBehavior-AllowFocusedRow="true" OnCustomUnboundColumnData="grdPedidos_CustomUnboundColumnData" runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <SettingsPopup>
                        <HeaderFilter MinHeight="140px"></HeaderFilter>
                    </SettingsPopup>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="Estado" FieldName="Estado" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Fecha de creación" FieldName="Fecha" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewDataColumn FieldName="Nombre" VisibleIndex="3">
                            <DataItemTemplate>
                                <%# Eval("Nombre") %>
                                <dx:BootstrapButton ID="btnDescargar" ClientInstanceName="btnDescargar" runat="server" OnInit="btnDescargar_Init" AutoPostBack="false" Text="" SettingsBootstrap-RenderOption="Link" ToolTip="Descargar rutas" CssClasses-Icon="fa fa-download fa-lg">
                                    <ClientSideEvents Click="function(s,e){ CallbackDescargar.PerformCallback(s.cpVisibleIndex);}" />
                                </dx:BootstrapButton>
                                <dx:BootstrapButton ID="btnHistorial" ClientInstanceName="btnHistorial" runat="server" OnInit="btnDescargar_Init" AutoPostBack="false" Text="" SettingsBootstrap-RenderOption="Link" ToolTip="Historial de cambios" CssClasses-Icon="fa fa-cog  fa-lg">
                                    <ClientSideEvents Click="function(s,e){ grdHistorial.PerformCallback(s.cpVisibleIndex); PopupHistorial.Show();}" />
                                </dx:BootstrapButton>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Fecha de pedido" FieldName="FechaPedido" PropertiesTextEdit-DisplayFormatString="d" VisibleIndex="4">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Cantidad de rutas" FieldName="Rutas" VisibleIndex="5">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Creado" FieldName="UsuarioCreacion" UnboundType="String" VisibleIndex="6">
                        </dx:BootstrapGridViewTextColumn>
                    </Columns>
                    <SettingsSearchPanel Visible="True" />
                </dx:BootstrapGridView>
            </div>
        </div>

        <dx:BootstrapFloatingActionButton ID="fab" ClientInstanceName="fab" runat="server" ContainerCssSelector="#MainPedido" InitialActionContext="ChangeRowContext" VerticalPosition="Bottom">
        <Items>
            <dx:BootstrapFABAction ActionName="ChangeRow" ContextName="ChangeRowContext" Text="Cambiar estado" IconCssClass="fa fa-history"></dx:BootstrapFABAction>
        </Items>
        <ClientSideEvents ActionItemClick="OnActionItemClick" />
    </dx:BootstrapFloatingActionButton>

        <%-- Popup --%>
        <dx:BootstrapPopupControl ID="PopupHistorial" ClientInstanceName="PopupHistorial" runat="server" Modal="true" ShowHeader="true" HeaderText=""
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="false" CloseAction="CloseButton" ShowCloseButton="true">
            <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
            <ContentCollection>
                <dx:ContentControl>
                    <dx:BootstrapGridView ID="grdHistorial" ClientInstanceName="grdHistorial" OnCustomCallback="grdHistorial_CustomCallback" SettingsBehavior-AllowFocusedRow="true" runat="server" AutoGenerateColumns="False">
                        <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                            <dx:BootstrapGridViewTextColumn Caption="Estado" FieldName="Estado" VisibleIndex="1">
                            </dx:BootstrapGridViewTextColumn>
                            <dx:BootstrapGridViewTextColumn Caption="Nombre" FieldName="Nombre" VisibleIndex="2">
                            </dx:BootstrapGridViewTextColumn>
                            <dx:BootstrapGridViewTextColumn Caption="Usuario modificación" FieldName="Usuario" VisibleIndex="3">
                            </dx:BootstrapGridViewTextColumn>
                            <dx:BootstrapGridViewTextColumn Caption="Hora modificación" FieldName="HorarioModificacion" VisibleIndex="4">
                            </dx:BootstrapGridViewTextColumn>
                        </Columns>
                    </dx:BootstrapGridView>
                </dx:ContentControl>
            </ContentCollection>
        </dx:BootstrapPopupControl>

        <dx:BootstrapPopupControl ID="PopupEnviar" ClientInstanceName="PopupEnviar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Guardar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { $.LoadingOverlay('show'); CallbackEnviar.PerformCallback(grdPedidos.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdPedidos.SetFocusedRowIndex(-1); PopupEnviar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content demo-popup-title" id="lblEnviar">¿Desea cambiar estado a creado?</p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

        <%-- CallBack --%>
        <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
            <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
        </dx:ASPxCallback>

        <dx:ASPxCallback ID="CallbackEnviar" ClientInstanceName="CallbackEnviar" OnCallback="CallbackEnviar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){  grdPedidos.SetFocusedRowIndex(-1); PopupEnviar.Hide(); grdPedidos.Refresh(); $.LoadingOverlay('hide', true);} " />
    </dx:ASPxCallback>

    </div>
    <script>
    function OnActionItemClick(s, e) {
           
                PopupEnviar.Show();
        }
        </script>
</asp:Content>
