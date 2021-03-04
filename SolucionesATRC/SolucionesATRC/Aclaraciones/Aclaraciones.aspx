<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Aclaraciones.aspx.cs" Inherits="SolucionesATRC.Aclaraciones.Aclaraciones" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Aclaraciones</p>
        </div>

        <div class="card">
            <div class="card-body">
                <div class="container-fluid">
                    <div class="row form-group">
                        <br />
                    </div>
                    <div class="row form-group">
                        <div class="col-0 align-self-end">
                            <label class="control-label">Del:</label>
                        </div>
                        <div class="col">
                            <dx:BootstrapDateEdit ID="dteDel" ClientInstanceName="dteDel" DisplayFormatString="D" runat="server">
                                <SettingsAdaptivity Mode="OnWindowInnerWidth" ModalDropDownCaption="De" />
                                <ValidationSettings ValidationGroup="Buscar" RequiredField-IsRequired="true" ValidateOnLeave="true" CausesValidation="false"></ValidationSettings>
                            </dx:BootstrapDateEdit>
                        </div>
                        <div class="col-0 align-self-end">
                            <label class="control-label">Del:</label>
                        </div>
                        <div class="col">
                            <dx:BootstrapDateEdit ID="dteAl" ClientInstanceName="dteAl" DisplayFormatString="D" runat="server">
                                <SettingsAdaptivity Mode="OnWindowInnerWidth" ModalDropDownCaption="Al" />
                                <ValidationSettings ValidationGroup="Buscar" RequiredField-IsRequired="true" ValidateOnLeave="true" CausesValidation="false"></ValidationSettings>
                            </dx:BootstrapDateEdit>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                           </div>
                        <div class="d-flex flex-row-reverse">
                            <dx:BootstrapButton ID="btnBuscar" ClientInstanceName="btnBuscar" runat="server" CssClasses-Control="btn-lg" AutoPostBack="false" Text="Buscar">
                                <ClientSideEvents Click="function(s, e) {  if( ASPxClientEdit.ValidateGroup('Buscar')){ grdAclaraciones.Refresh(); }}" />
                            </dx:BootstrapButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row form-group">
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdAclaraciones" ClientInstanceName="grdAclaraciones" OnDataBinding="grdAclaraciones_DataBinding" OnCustomCallback="grdAclaraciones_CustomCallback"
                    SettingsBehavior-AllowFocusedRow="true" OnCustomUnboundColumnData="grdAclaraciones_CustomUnboundColumnData" runat="server" AutoGenerateColumns="False">
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
            <%--<dx:BootstrapFABAction ActionName="NewRow" ContextName="NewRowContext" Text="Nueva aclaración" IconCssClass="fa fa-plus"></dx:BootstrapFABAction>--%>
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

    <%--<dx:BootstrapPopupControl ID="PopupNueva" ClientInstanceName="PopupNueva" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Aceptar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackNueva.PerformCallback(grdAclaraciones.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdAclaraciones.SetFocusedRowIndex(-1); PopupNueva.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <div class="container-fluid">
                        <div class="row form-group">
                            <div class="col">
                                <dx:BootstrapMemo ID="MemoDescripcion" ClientInstanceName="MemoDescripcion" NullText="Descripción del problema" runat="server"></dx:BootstrapMemo>
                                </div>
                            </div>
                    </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>--%>

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

    <dx:BootstrapPopupControl ID="PopupEnviar" ClientInstanceName="PopupEnviar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Guardar"  AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackEnviar.PerformCallback(grdAclaraciones.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdAclaraciones.SetFocusedRowIndex(-1); PopupEnviar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content demo-popup-title" id="lblEnviar">¿Desea aprobar la aclaraci&oacute;n?</p>
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

    <%--<dx:ASPxCallback ID="CallbackNueva" ClientInstanceName="CallbackNueva" OnCallback="CallbackNueva_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdAclaraciones.SetFocusedRowIndex(-1); PopupNueva.Hide(); grdAclaraciones.Refresh();} " />
    </dx:ASPxCallback>--%>
    <dx:ASPxCallback ID="CallbackRechazar" ClientInstanceName="CallbackRechazar" OnCallback="CallbackRechazar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdAclaraciones.SetFocusedRowIndex(-1); PopupMotivoRechazo.Hide(); grdAclaraciones.Refresh();}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackEnviar" ClientInstanceName="CallbackEnviar" OnCallback="CallbackEnviar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ PopupConfirmar.Show(); grdAclaraciones.SetFocusedRowIndex(-1); PopupEnviar.Hide(); grdAclaraciones.Refresh();} " />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackRevisar" ClientInstanceName="CallbackRevisar" OnCallback="CallbackRevisar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){  grdAclaraciones.SetFocusedRowIndex(-1); PopupRevisar.Hide(); grdAclaraciones.Refresh();} " />
    </dx:ASPxCallback>

    <script>
        function OnActionItemClick(s, e) {
            //if (e.actionName === "NewRow") {
            //    //$.LoadingOverlay("show");
            //    PopupNueva.Show();
            //    //$.LoadingOverlay("hide", true);
            //    //Loading.Show();
            //    //CallbackRedireccionar.PerformCallback();
            //}
            if (e.actionName === "DeleteRow") {
                fab.SetActionContext("DeleteRow");
                PopupRechazar.Show();
                //grdAclaraciones.GetRowValues(grdAclaraciones.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdAclaraciones.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdAclaraciones.SetFocusedRowIndex(-1);
            }
            else if (e.actionName === "RevisionRow") {
                fab.SetActionContext("RevisionRow");
                PopupRevisar.Show();
                //grdAclaraciones.GetRowValues(grdAclaraciones.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdAclaraciones.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdAclaraciones.SetFocusedRowIndex(-1);
            }
            else if (e.actionName === "EnviarRow") {
                fab.SetActionContext("EnviarRow");
                PopupEnviar.Show();
                //grdAclaraciones.GetRowValues(grdAclaraciones.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdAclaraciones.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdAclaraciones.SetFocusedRowIndex(-1);
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
                    fab.SetActionContext("NewRowContext");
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
            fab.SetActionContext("NewRowContext");
            s.SetFocusedRowIndex(-1);
        }

        function OnGetRowValues(values) {
            txtConfirm.innerText = "¿Desea rechazar la aclaracion " + values + "?";
            
        }

        function OnGetRowEstado(values) {

            switch (values) {
                case 'Creado_Maquiladora':
                case 'Revision_Rutas':
                case 'Aprobada_Maquiladora':
                case 'Aprobada_Rutas':
                case 'Rechazada_Maquiladora':
                case 'Rechazada_Rutas':
                    fab.SetActionContext("NewRowContext", true);
                    break;
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
