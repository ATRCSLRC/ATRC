<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="MisAprobados.aspx.cs" Inherits="SolucionesATRC.Pedidos.MisAprobados" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Pedidos aprobados</p>
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

        <%-- CallBack --%>
        <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
            <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
        </dx:ASPxCallback>
    </div>
</asp:Content>
