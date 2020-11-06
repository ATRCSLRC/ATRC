<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="PedidosRutas.aspx.cs" Inherits="SolucionesATRC.PedidosRutas" %>


<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Pedidos de rutas</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdPedidos" ClientInstanceName="grdPedidos" OnDataBinding="grdPedidos_DataBinding" SettingsBehavior-AllowFocusedRow="true" OnCustomUnboundColumnData="grdPedidos_CustomUnboundColumnData" runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <ClientSideEvents RowClick="OnRowClick" Init="OnGridViewInit" />
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
                                
                                <%--<button type="button" class="btn btn-link" >
                                    <span class="demo-icon demo-icon-settings"></span>
                                </button>
                                <button type="button" class="btn btn-link">
                                    <span class="demo-icon demo-icon-export"></span>
                                </button>--%>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                       <%-- <dx:BootstrapGridViewTextColumn Caption="Nombre" FieldName="Nombre" VisibleIndex="3">
                        </dx:BootstrapGridViewTextColumn>--%>
                        <dx:BootstrapGridViewTextColumn Caption="Fecha de pedido" FieldName="FechaPedido" PropertiesTextEdit-DisplayFormatString="d" VisibleIndex="4">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Cantidad de rutas" FieldName="Rutas" VisibleIndex="5">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Creado" FieldName="UsuarioCreacion" UnboundType="String" VisibleIndex="6">
                        </dx:BootstrapGridViewTextColumn>
                        <%--<dx:BootstrapGridViewDataColumn Caption="" Width="50px" Settings-AllowDragDrop="False">
                            <DataItemTemplate>
                                <dx:BootstrapButton ID="BootstrapButton1" runat="server" AutoPostBack="false" Text="Button"></dx:BootstrapButton>
                                <dx:BootstrapButton ID="BootstrapButton2" runat="server" AutoPostBack="false" Text="Button"></dx:BootstrapButton>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>--%>
                    </Columns>

                    <SettingsSearchPanel Visible="True" />
                </dx:BootstrapGridView>
            </div>
        </div>
    </div>


    <dx:BootstrapFloatingActionButton ID="fab" ClientInstanceName="fab" runat="server" ContainerCssSelector="#MainPedido" InitialActionContext="NewRowContext" VerticalPosition="Bottom">
        <Items>
            <dx:BootstrapFABAction ActionName="NewRow" ContextName="NewRowContext" Text="Nuevo pedido" IconCssClass="fa fa-plus"></dx:BootstrapFABAction>
            <dx:BootstrapFABAction ActionName="Cancel" ContextName="CancelContext" IconCssClass="dxbs-icon dxbs-icon-fab-collapse"></dx:BootstrapFABAction>
            <dx:BootstrapFABActionGroup ContextName="FocusedRowContext">
                <Items>
                    <dx:BootstrapFABActionItem ActionName="DeleteRow" Badge-Text="Cancelar pedido" IconCssClass="fa fa-trash"></dx:BootstrapFABActionItem>
                    <dx:BootstrapFABActionItem ActionName="EditRow" Badge-Text="Modificar pedido" IconCssClass="fa fa-pencil"></dx:BootstrapFABActionItem>
                    <dx:BootstrapFABActionItem ActionName="EnviarRow" Badge-Text="Enviar pedido" IconCssClass="fa fa-paper-plane"></dx:BootstrapFABActionItem>
                </Items>
            </dx:BootstrapFABActionGroup>
            
            <dx:BootstrapFABActionGroup ContextName="EditingRowContext" Text="Cancel" CollapseIconCssClass="dxbs-icon dxbs-icon-fab-collapse">
                <Items>
                    <dx:BootstrapFABActionItem ActionName="Save" IconCssClass="icon icon-Save"></dx:BootstrapFABActionItem>
                </Items>
            </dx:BootstrapFABActionGroup>
        </Items>
        <ClientSideEvents ActionItemClick="OnActionItemClick" ActionCollapsing="OnActionCollapsing" />
    </dx:BootstrapFloatingActionButton>

    <%-- Popup --%>

    <dx:BootstrapPopupControl ID="PopupEliminar" ClientInstanceName="PopupEliminar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackEliminar.PerformCallback(grdPedidos.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdPedidos.SetFocusedRowIndex(-1); PopupEliminar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content" id="txtConfirm"></p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:BootstrapPopupControl ID="PopupHistorial" ClientInstanceName="PopupHistorial" runat="server" Modal="true" ShowHeader="true" HeaderText=""
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="false" CloseAction="CloseButton" ShowCloseButton="true">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <ContentCollection>
            <dx:ContentControl>
                <dx:BootstrapGridView ID="grdHistorial" ClientInstanceName="grdHistorial" OnCustomCallback="grdHistorial_CustomCallback" SettingsBehavior-AllowFocusedRow="true"  runat="server" AutoGenerateColumns="False">
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
                <ClientSideEvents Click="function(s, e) { CallbackEnviar.PerformCallback(grdPedidos.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdPedidos.SetFocusedRowIndex(-1); PopupEliminar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content demo-popup-title" id="lblEnviar"></p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:BootstrapPopupControl ID="PopupConfirmar" ClientInstanceName="PopupConfirmar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar" ValidationGroup="Ruta" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { grdPedidos.Refresh(); PopupConfirmar.Hide();  }" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-0">
                            <i class="fa fa-check-circle fa-2x" style="color:green"></i>
                        </div>
                        <div class="col-12">
                            <dx:ASPxLabel ID="lblConfirmacion" ClientInstanceName="lblConfirmacion" runat="server" CssClass="demo-popup-title" Text="Se ha enviado correctamente."></dx:ASPxLabel>
                        </div>
                    </div>
                </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <%-- CallBack --%>

    <dx:ASPxCallback ID="CallbackRedireccionar" ClientInstanceName="CallbackRedireccionar" OnCallback="CallbackRedireccionar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s, e){ 
                    if(e.result != ''){
                        window.location.href = 'EdicionPedidoRuta.aspx?id=' + e.result; 
                    }else
            {
                window.location.href = 'EdicionPedidoRuta.aspx'; 
            }
                }"
            CallbackError="function(s,e){$.LoadingOverlay('hide', true);}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackEliminar" ClientInstanceName="CallbackEliminar" OnCallback="CallbackEliminar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdPedidos.SetFocusedRowIndex(-1); PopupEliminar.Hide(); grdPedidos.Refresh();}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackEnviar" ClientInstanceName="CallbackEnviar" OnCallback="CallbackEnviar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ PopupConfirmar.Show(); grdPedidos.SetFocusedRowIndex(-1); PopupEliminar.Hide(); grdPedidos.Refresh();} " />
    </dx:ASPxCallback>

    <script>
        function OnActionItemClick(s, e) {
            if (e.actionName === "NewRow") {
                $.LoadingOverlay("show");
                //$.LoadingOverlay("hide", true);
                //Loading.Show();
                CallbackRedireccionar.PerformCallback();
            }
            else if (e.actionName === "EditRow") {
                $.LoadingOverlay("show");
                CallbackRedireccionar.PerformCallback(grdPedidos.GetFocusedRowIndex());
            }
            else if (e.actionName === "DeleteRow") {
                fab.SetActionContext("DeleteRow");
                grdPedidos.GetRowValues(grdPedidos.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdPedidos.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdPedidos.SetFocusedRowIndex(-1);
            }
            else if (e.actionName === "EnviarRow") {
                fab.SetActionContext("EnviarRow");
                PopupEnviar.Show();
                //grdPedidos.GetRowValues(grdPedidos.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdPedidos.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdPedidos.SetFocusedRowIndex(-1);
            }
            else if (e.actionName === "Save") {
                grdPedidos.UpdateEdit();
            }
            else if (e.actionName === "Cancel") {
                grdPedidos.CancelEdit();
            }
        }
        function OnActionCollapsing(s, e) {
            if ((e.contextName === "FocusedRowContext" || e.contextName === "EditingRowContext" ) && e.collapseReason === ASPxClientFloatingActionButtonCollapseReason.CollapseButton) {
                setTimeout(function () {
                    grdPedidos.SetFocusedRowIndex(-1);
                    fab.SetActionContext("NewRowContext");
                }, 100);
            }
        }

        function OnRowClick(s, e) {
            if (s.IsNewRowEditing() || s.IsEditing())
                e.cancel = true;
            else
                grdPedidos.GetRowValues(e.visibleIndex, 'Estado', OnGetRowEstado);
                
        }

        function OnGridViewInit(s, e) {
            fab.SetActionContext("NewRowContext");
            s.SetFocusedRowIndex(-1);
        }

        function OnGetRowValues(values) {
            txtConfirm.innerText = "¿Desea eliminar la ruta " + values + "?";
            PopupEliminar.Show();
        }

        function OnGetRowEstado(values) {
            if (values === 'Creado')
                fab.SetActionContext("FocusedRowContext", true);
            else
                fab.SetActionContext("NewRowContext", true);
        }
    </script>
</asp:Content>

