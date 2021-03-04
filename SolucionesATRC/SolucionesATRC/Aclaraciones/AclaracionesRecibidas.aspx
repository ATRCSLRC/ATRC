<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="AclaracionesRecibidas.aspx.cs" Inherits="SolucionesATRC.Aclaraciones.AclaracionesRecibidas" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Aclaraciones recibidas</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdAclaraciones" ClientInstanceName="grdAclaraciones" OnDataBinding="grdAclaraciones_DataBinding" SettingsBehavior-AllowFocusedRow="true" runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <ClientSideEvents RowClick="OnRowClick" Init="OnGridViewInit" />
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


    <dx:BootstrapFloatingActionButton ID="fab" ClientInstanceName="fab" runat="server" ContainerCssSelector="#MainPedido" InitialActionContext="NewRowContext" VerticalPosition="Bottom">
        <Items>
            <dx:BootstrapFABAction ActionName="Cancel" ContextName="CancelContext" IconCssClass="dxbs-icon dxbs-icon-fab-collapse"></dx:BootstrapFABAction>
            <dx:BootstrapFABActionGroup ContextName="FocusedRowContext">
                <Items>
                    <dx:BootstrapFABActionItem ActionName="DeleteRow" Badge-Text="Cancelar aclaración" IconCssClass="fa fa-trash"></dx:BootstrapFABActionItem>
                    <dx:BootstrapFABActionItem ActionName="EnviarRow" Badge-Text="Aprobar aclaración" IconCssClass="fa fa-paper-plane"></dx:BootstrapFABActionItem>
                </Items>
            </dx:BootstrapFABActionGroup>

            <dx:BootstrapFABActionGroup ContextName="RevisionRowContext">
                <Items>
                    <dx:BootstrapFABActionItem ActionName="RevisionRow" Badge-Text="Revisar aclaración" IconCssClass="fa fa-trash"></dx:BootstrapFABActionItem>                    
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

    <dx:BootstrapPopupControl ID="PopupRechazar" ClientInstanceName="PopupRechazar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { PopupMotivoRechazo.Show(); PopupRechazar.Hide();  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdAclaraciones.SetFocusedRowIndex(-1); PopupRechazar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content" id="txtConfirm">¿Desea rechazar la aclaraci&oacute;n?</p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:BootstrapPopupControl ID="PopupMotivoRechazo" ClientInstanceName="PopupMotivoRechazo" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackRechazar.PerformCallback(grdAclaraciones.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdAclaraciones.SetFocusedRowIndex(-1); PopupMotivoRechazo.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <dx:BootstrapMemo ID="memoMotivoRechazo" ClientInstanceName="memoMotivoRechazo" NullText="Motivo de rechazo" runat="server"></dx:BootstrapMemo>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

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

    <dx:BootstrapPopupControl ID="PopupRevisar" ClientInstanceName="PopupRevisar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Revisar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackRevisar.PerformCallback(grdAclaraciones.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdAclaraciones.SetFocusedRowIndex(-1); PopupRevisar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content demo-popup-title" >¿Desea revisar la aclaraci&oacute;n?</p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:BootstrapPopupControl ID="PopupConfirmar" ClientInstanceName="PopupConfirmar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar" ValidationGroup="Ruta" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { grdAclaraciones.Refresh(); PopupConfirmar.Hide();  }" />
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
                            <dx:ASPxLabel ID="lblConfirmacion" ClientInstanceName="lblConfirmacion" runat="server" CssClass="demo-popup-title" Text="Se ha aprobado correctamente."></dx:ASPxLabel>
                        </div>
                    </div>
                </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <%-- CallBack --%>

    <dx:ASPxCallback ID="CallbackRechazar" ClientInstanceName="CallbackRechazar" OnCallback="CallbackRechazar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdAclaraciones.SetFocusedRowIndex(-1); PopupMotivoRechazo.Hide(); grdAclaraciones.Refresh();}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackRevisar" ClientInstanceName="CallbackRevisar" OnCallback="CallbackRevisar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){  grdAclaraciones.SetFocusedRowIndex(-1); PopupRevisar.Hide(); grdAclaraciones.Refresh();} " />
    </dx:ASPxCallback>

    <script>
        function OnActionItemClick(s, e) {
            if (e.actionName === "DeleteRow") {
                fab.SetActionContext("DeleteRow");
                PopupRechazar.Show();
            }
            else if (e.actionName === "RevisionRow") {
                fab.SetActionContext("RevisionRow");
                PopupRevisar.Show();
            }
            else if (e.actionName === "EnviarRow") {
                fab.SetActionContext("EnviarRow");
                PopupEnviar.Show();
            }
            else if (e.actionName === "Save") {
                grdAclaraciones.UpdateEdit();
            }
            else if (e.actionName === "Cancel") {
                grdAclaraciones.CancelEdit();
            }
        }
        function OnActionCollapsing(s, e) {
            if ((e.contextName === "FocusedRowContext" || e.contextName === "RevisionRowContext" ) && e.collapseReason === ASPxClientFloatingActionButtonCollapseReason.CollapseButton) {
                setTimeout(function () {
                    grdAclaraciones.SetFocusedRowIndex(-1);
                    fab.SetActionContext("NewRowContext", true);
                }, 100);
            }
        }

        function OnRowClick(s, e) {
            if (s.IsNewRowEditing() || s.IsEditing())
                e.cancel = true;
            else
                grdAclaraciones.GetRowValues(e.visibleIndex, 'Estado', OnGetRowEstado);
                
        }

        function OnGridViewInit(s, e) {
            s.SetFocusedRowIndex(-1);
        }

        function OnGetRowValues(values) {
            txtConfirm.innerText = "¿Desea rechazar la aclaracion " + values + "?";
            
        }

        function OnGetRowEstado(values) {

            switch (values) {
                
                case 'Creado_Rutas':
                    fab.SetActionContext("RevisionRowContext", true);
                    break;
                case 'Revision_Maquiladora':
                    fab.SetActionContext("FocusedRowContext", true);
                    break;
                
            }
        }
    </script>
</asp:Content>
