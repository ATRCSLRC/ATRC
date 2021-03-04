<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="AclaracionesRechazadas.aspx.cs" Inherits="SolucionesATRC.Aclaraciones.AclaracionesRechazadas" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Aclaraciones rechazadas</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdAclaraciones" ClientInstanceName="grdAclaraciones" OnDataBinding="grdAclaraciones_DataBinding" SettingsBehavior-AllowFocusedRow="true" OnCustomUnboundColumnData="grdAclaraciones_CustomUnboundColumnData" runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <SettingsPopup>
                        <HeaderFilter MinHeight="140px"></HeaderFilter>
                    </SettingsPopup>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="Estado" FieldName="Estado" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Fecha de creación" FieldName="FechaAlta" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewDataColumn FieldName="Descripcion" VisibleIndex="3">
                            <DataItemTemplate>
                                <%# Eval("Descripcion") %>
                                <dx:BootstrapButton ID="btnDescargar" Visible=<%# Eval("Pedido") == null || Eval("Estado").ToString() == "Creado_Rutas" || Eval("Estado").ToString() == "Creado_Maquiladora" ? false : true %> ClientInstanceName="btnDescargar" runat="server" OnInit="btnDescargar_Init" AutoPostBack="false" Text="" SettingsBootstrap-RenderOption="Link" ToolTip="Descargar rutas" CssClasses-Icon="fa fa-download fa-lg">
                                    <ClientSideEvents Click="function(s,e){ CallbackDescargar.PerformCallback(s.cpVisibleIndex);}" />
                                </dx:BootstrapButton>
                                <dx:BootstrapButton ID="btnHistorial" ClientInstanceName="btnHistorial" Visible=<%# Eval("Estado").ToString() == "Creado_Rutas" || Eval("Estado").ToString() == "Creado_Maquiladora" ? false : true %> runat="server" OnInit="btnDescargar_Init" AutoPostBack="false" Text="" SettingsBootstrap-RenderOption="Link" ToolTip="Historial de cambios" CssClasses-Icon="fa fa-cog  fa-lg">
                                    <ClientSideEvents Click="function(s,e){ grdHistorial.PerformCallback(s.cpVisibleIndex); PopupHistorial.Show();}" />
                                </dx:BootstrapButton>
                                
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                    </Columns>

                    <SettingsSearchPanel Visible="True" />
                </dx:BootstrapGridView>
            </div>
        </div>
    </div>


    <%-- Popup --%>

    <dx:BootstrapPopupControl ID="PopupHistorial" ClientInstanceName="PopupHistorial" runat="server" Modal="true" ShowHeader="true" HeaderText="" ResizingMode="Live"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="false" CloseAction="CloseButton" ShowCloseButton="true" Width="800px" Height="480px">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <ContentCollection>
            <dx:ContentControl Width="100%">
                <dx:BootstrapGridView ID="grdHistorial" ClientInstanceName="grdHistorial" OnCustomCallback="grdHistorial_CustomCallback" OnCustomUnboundColumnData="grdHistorial_CustomUnboundColumnData"
                    SettingsBehavior-AllowFocusedRow="true"  runat="server" AutoGenerateColumns="False"  Width="100%">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                        <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="Estado" FieldName="Estado" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Comentarios" FieldName="Descripcion" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                            <dx:BootstrapGridViewTextColumn Caption="Usuario modificación" FieldName="UsuarioCreacion" UnboundType="String" VisibleIndex="4">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Fecha modificación" FieldName="FechaAlta" VisibleIndex="3">
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

</asp:Content>