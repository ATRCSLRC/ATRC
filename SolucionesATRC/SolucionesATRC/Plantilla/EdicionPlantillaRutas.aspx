<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="EdicionPlantillaRutas.aspx.cs" Inherits="SolucionesATRC.Plantilla.EdicionPlantillaRutas" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">

            <p class="col-12 demo-content-title">Edición de plantilla de rutas</p>
        </div>

        <div class="row form-group">
            <div class="col-md-12">
                <dx:BootstrapTextBox ID="txtNombre" ClientInstanceName="txtNombre" runat="server" NullText="Nombre del pedido">
                    <ValidationSettings ValidationGroup="Pedido" ValidateOnLeave="false">
                        <RequiredField IsRequired="true" />
                    </ValidationSettings>
                </dx:BootstrapTextBox>
            </div>
        </div>
        <div class="row form-group">
            <div id="MainRuta" class="col-md-12">
                <dx:BootstrapGridView ID="grdRutas" ClientInstanceName="grdRutas" OnDataBinding="grdRutas_DataBinding" SettingsBehavior-AllowFocusedRow="true"  runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <ClientSideEvents RowClick="OnRowClick" Init="OnGridViewInit"/>
                    <SettingsPopup>
                        <HeaderFilter MinHeight="140px"></HeaderFilter>
                    </SettingsPopup>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="Ruta" FieldName="Ruta" VisibleIndex="0">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Servicio" FieldName="Servicio.Descripcion" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Tipo de ruta" FieldName="TipoRuta" VisibleIndex="4" AdaptivePriority="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Turno" FieldName="Turno.Descripcion" VisibleIndex="5" AdaptivePriority="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Hora de " FieldName="HoraEntrada" PropertiesTextEdit-DisplayFormatString="t" VisibleIndex="2" AdaptivePriority="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="A hora" FieldName="HoraSalida" PropertiesTextEdit-DisplayFormatString="t" VisibleIndex="3" AdaptivePriority="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Es extra" FieldName="EsRutaExtra" VisibleIndex="6" Width="20%" AdaptivePriority="2">
                        </dx:BootstrapGridViewTextColumn>
                    </Columns>
                </dx:BootstrapGridView>
            </div>


        </div>
        <div class="row form-group justify-content-center">
            <div class="col-3 ">
                <dx:BootstrapButton runat="server" Text="Guardar" SettingsBootstrap-RenderOption="Primary" UseSubmitBehavior="false" AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { $.LoadingOverlay('show'); if( ASPxClientEdit.ValidateGroup('Pedido')){CallbackGuardarPedido.PerformCallback();} }" />
                </dx:BootstrapButton>
                <dx:BootstrapButton runat="server" Text="Cancelar" SettingsBootstrap-RenderOption="Link" UseSubmitBehavior="false" AutoPostBack="false">
                    <ClientSideEvents Click="function(s, e) { $.LoadingOverlay('show'); window.location.href = 'PlantillaRutas.aspx' }" />
                </dx:BootstrapButton>
            </div>
        </div>
        <dx:BootstrapFloatingActionButton ID="fab" ClientInstanceName="fab" runat="server" ContainerCssSelector="#MainRuta" InitialActionContext="NewRowContext" VerticalPosition="Bottom">
            <Items>
                <dx:BootstrapFABAction ActionName="NewRow" ContextName="NewRowContext" Text="Nueva ruta"></dx:BootstrapFABAction>
                <dx:BootstrapFABAction ActionName="Cancel" ContextName="CancelContext" IconCssClass="dxbs-icon dxbs-icon-fab-collapse"></dx:BootstrapFABAction>
                <dx:BootstrapFABActionGroup ContextName="FocusedRowContext">
                    <Items>
                        <dx:BootstrapFABActionItem ActionName="DeleteRow" IconCssClass="demo-icon demo-icon-del"></dx:BootstrapFABActionItem>
                        <dx:BootstrapFABActionItem ActionName="EditRow" IconCssClass="demo-icon demo-icon-edit"></dx:BootstrapFABActionItem>
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

        <dx:BootstrapPopupControl ID="PopupRuta" ClientInstanceName="PopupRuta" runat="server" Modal="true" HeaderText="Ruta"
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" Width="500px" CloseAction="None" ShowCloseButton="false">
            <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
            <FooterTemplate>
                <dx:BootstrapButton runat="server" Text="Guardar" ValidationGroup="Ruta" AutoPostBack="false" UseSubmitBehavior="false">
                    <ClientSideEvents Click="function(s, e) {  if( ASPxClientEdit.ValidateGroup('Ruta')){ CallbackGuardarRutas.PerformCallback(fab.GetActionContext() +'|'+cmbTipoRuta.GetValue()); }}" />
                </dx:BootstrapButton>
                <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                    <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); ASPxClientEdit.ClearEditorsInContainerById('Ruta'); PopupRuta.Hide();}" />
                </dx:BootstrapButton>
            </FooterTemplate>
            <ContentCollection>
                <dx:ContentControl>
                    <dx:BootstrapCallbackPanel ID="PanelRuta" ClientInstanceName="PanelRuta" OnCallback="PanelRuta_Callback" runat="server">
                        <ClientSideEvents EndCallback="function(s,e){ PopupRuta.Show(); grdRutas.SetFocusedRowIndex(-1);}" />
                        <ContentCollection>
                            <dx:ContentControl>
                                <div class="container-fluid">
                                    <div class="row form-group">
                                        <div class="col">
                                            <dx:BootstrapTextBox ID="txtRuta" ClientInstanceName="txtRuta" NullText="Ruta" NullTextDisplayMode="UnfocusedAndFocused" runat="server">
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                            </dx:BootstrapTextBox>
                                        </div>
                                        <div class="col">
                                            <dx:BootstrapCheckBox ID="chkRutaExtra" ClientInstanceName="chkRutaExtra" Text="Es ruta extra" runat="server"></dx:BootstrapCheckBox>
                                        </div>
                                    </div>
                                    <div class="row form-group">
                                        <div class="col">
                                            <dx:BootstrapComboBox ID="cmbServicio" ClientInstanceName="cmbServicio" NullText="Servicio" ValueField="Oid" TextField="Descripcion" ValueType="System.Int32" OnDataBinding="cmbServicio_DataBinding" NullTextDisplayMode="UnfocusedAndFocused" runat="server">
                                                <SettingsAdaptivity Mode="OnWindowInnerWidth" ModalDropDownCaption="Seleccionar servicio" />
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                                <ClientSideEvents SelectedIndexChanged="OnTipoRuta" />
                                            </dx:BootstrapComboBox>
                                        </div>
                                    </div>
                                    <div class="row form-group">
                                        <div class="col">
                                            <dx:BootstrapComboBox ID="cmbTipoRuta" ClientInstanceName="cmbTipoRuta" OnCallback="cmbTipoRuta_Callback" NullText="Tipo de ruta" ValueType="System.Int32" NullTextDisplayMode="UnfocusedAndFocused" runat="server">
                                                <SettingsAdaptivity Mode="OnWindowInnerWidth" ModalDropDownCaption="Seleccionar tipo de ruta" />
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                                <ClientSideEvents SelectedIndexChanged="OnValidarTipoRuta" ValueChanged="OnValidarTipoRuta" TextChanged="OnValidarTipoRuta" />
                                            </dx:BootstrapComboBox>
                                        </div>
                                        <div class="col">
                                            <dx:BootstrapComboBox ID="cmbTurno" ClientInstanceName="cmbTurno" NullText="Turno" ValueField="Oid" TextField="Descripcion" ValueType="System.Int32" OnDataBinding="cmbTurno_DataBinding" NullTextDisplayMode="UnfocusedAndFocused" runat="server">
                                                <SettingsAdaptivity Mode="OnWindowInnerWidth" ModalDropDownCaption="Seleccionar turno" />
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="false" />
                                                </ValidationSettings>
                                            </dx:BootstrapComboBox>
                                        </div>
                                    </div>
                                    <div class="row form-group">
                                        <div class="col">
                                            <dx:BootstrapTimeEdit ID="tmeHoraDe" ClientInstanceName="tmeHoraDe" NullText="Hora de" EditFormat="DateTime" DisplayFormatString="t" EditFormatString="t" runat="server">
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                                <ClientSideEvents Validation="OnValidarEntrada" />
                                            </dx:BootstrapTimeEdit>
                                        </div>
                                        <div class="col">
                                            <dx:BootstrapTimeEdit ID="tmeAhora" ClientInstanceName="tmeAhora" NullText="A hora" EditFormat="DateTime" DisplayFormatString="t" EditFormatString="t" runat="server">
                                                <ValidationSettings ValidationGroup="Ruta" ValidateOnLeave="true">
                                                    <RequiredField IsRequired="true" />
                                                </ValidationSettings>
                                                <ClientSideEvents Validation="OnValidarSalida" />
                                            </dx:BootstrapTimeEdit>
                                        </div>
                                    </div>
                                </div>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapCallbackPanel>


                </dx:ContentControl>
            </ContentCollection>
        </dx:BootstrapPopupControl>

        <dx:BootstrapPopupControl ID="PopupEliminar" ClientInstanceName="PopupEliminar" runat="server" Modal="true" ShowHeader="false"
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
            <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
            <FooterTemplate>
                <dx:BootstrapButton runat="server" Text="Guardar" ValidationGroup="Ruta" AutoPostBack="false" UseSubmitBehavior="false">
                    <ClientSideEvents Click="function(s, e) { CallbackGuardarRutas.PerformCallback(fab.GetActionContext() +'|'+cmbTipoRuta.GetValue());  }" />
                </dx:BootstrapButton>
                <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                    <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); PopupEliminar.Hide();}" />
                </dx:BootstrapButton>
            </FooterTemplate>
            <ContentCollection>
                <dx:ContentControl>
                    <p class="col-12 demo-content" id="txtConfirm"></p>
                </dx:ContentControl>
            </ContentCollection>
        </dx:BootstrapPopupControl>

        <dx:ASPxCallback ID="CallbackGuardarRutas" ClientInstanceName="CallbackGuardarRutas" OnCallback="CallbackGuardarRutas_Callback" runat="server">
            <ClientSideEvents CallbackComplete="function(s,e){grdRutas.Refresh(); fab.SetActionContext('NewRowContext'); OnLimpiar(); PopupRuta.Hide(); PopupEliminar.Hide(); }" />
        </dx:ASPxCallback>
        <dx:ASPxCallback ID="CallbackGuardarPedido" ClientInstanceName="CallbackGuardarPedido" OnCallback="CallbackGuardarPedido_Callback" runat="server">
            <ClientSideEvents CallbackComplete="function(s,e){
                        var windowUrl = 'PlantillaRutas.aspx';  
                        window.location.href = windowUrl; }" />
        </dx:ASPxCallback>
    </div>

    <script>
        function OnActionItemClick(s, e) {
            if (e.actionName === "NewRow") {
                PopupRuta.Show();
            }
            else if (e.actionName === "EditRow") {
                fab.SetActionContext("EditRow");
                PanelRuta.PerformCallback(grdRutas.GetFocusedRowIndex());
            }
            else if (e.actionName === "DeleteRow") {
                fab.SetActionContext("DeleteRow");
                grdRutas.GetRowValues(grdRutas.GetFocusedRowIndex(), 'Ruta', OnGetRowValues);
                
            }
            else if (e.actionName === "Save") {
                grdRutas.UpdateEdit();
            }
            else if (e.actionName === "Cancel") {
                grdRutas.CancelEdit();
            }
        }
        function OnActionCollapsing(s, e) {
            if ((e.contextName === "FocusedRowContext" || e.contextName === "EditingRowContext") && e.collapseReason === ASPxClientFloatingActionButtonCollapseReason.CollapseButton) {
                setTimeout(function () {
                    grdRutas.SetFocusedRowIndex(-1);
                   fab.SetActionContext("NewRowContext");
                }, 100);
            }
        }
        //function onFloatingActionButtonActionItemClick(s, e) {
        //    s.ExpandActionGroupItems();
        //    //dxbsDemo.showToast("The '" + e.actionName + "' action item has been clicked.");
        //}
        //function onActionGroupInit(s, e) {
        //    s.SetActionContext("c1", true);
        //}
        function OnTipoRuta(s, e) {
            cmbTipoRuta.PerformCallback(s.GetValue());
        }

        function OnRowClick(s, e) {
            if (s.IsNewRowEditing() || s.IsEditing())
                e.cancel = true;
            else
                fab.SetActionContext("FocusedRowContext", true);
        }

        function OnLimpiar(s, e) {
            txtRuta.SetValue(null);
            chkRutaExtra.SetValue(false);
            cmbServicio.SetValue(null);
            cmbTipoRuta.SetValue(null);
            cmbTurno.SetValue(null);
            tmeHoraDe.SetValue(null);
            tmeAhora.SetValue(null);

        }

        function OnGetRowValues(values) {
            txtConfirm.innerText = "¿Desea eliminar la ruta " + values + "?";
            PopupEliminar.Show();
        }
        function OnValidarEntrada(s, e) {
            if (cmbTipoRuta.GetValue() === 0 && e.value !== null) {
                e.isValid = true;
            } else if (cmbTipoRuta.GetValue() === 1 && e.value !== null) {
                e.isValid = true;
            } else if (cmbTipoRuta.GetValue() === 2 && e.value !== null) {
                e.isValid = false;
            } else {
                e.isValid = false;
            }
        }

        function OnValidarSalida(s, e) {
            if (cmbTipoRuta.GetValue() === 0 && e.value !== null) {
                e.isValid = true;
            } else if (cmbTipoRuta.GetValue() === 1 && e.value !== null) {
                e.isValid = false;
            } else if(cmbTipoRuta.GetValue() === 2 && e.value !== null){
                e.isValid = true;
            } else {
                e.isValid = false;
            }
        }

        function OnValidarTipoRuta(s, e) {
            tmeAhora.SetIsValid(true);
            tmeHoraDe.SetIsValid(true);
            if (cmbTipoRuta.GetValue() === 0) {
                //tmeAhora.SetReadOnly(false);
                //tmeAhora.SetEnabled(true);
                //tmeHoraDe.SetReadOnly(false);
                //tmeHoraDe.SetEnabled(true);
                tmeAhora.SetVisible(true);
                tmeHoraDe.SetVisible(true);
            } else if (cmbTipoRuta.GetValue() === 1) {
                //tmeAhora.SetReadOnly(true);
                //tmeAhora.SetEnabled(false);
                //tmeHoraDe.SetReadOnly(false);
                //tmeHoraDe.SetEnabled(true);
                tmeAhora.SetValue(null);
                tmeAhora.SetVisible(false);
                tmeHoraDe.SetVisible(true);
            } else {
                //tmeAhora.SetReadOnly(false);
                //tmeAhora.SetEnabled(true);
                //tmeHoraDe.SetReadOnly(true);
                //tmeHoraDe.SetEnabled(false);
                tmeHoraDe.SetValue(null);
                tmeHoraDe.SetVisible(false);
                tmeAhora.SetVisible(true);
            }
            
            //ASPxClientEdit.ValidateGroup('Ruta');
           // ASPxClientEdit.ClearEditorsInContainerById("tmeAhora");
           // ASPxClientEdit.ClearEditorsInContainerById("tmeHoraDe");
        }

        function OnGridViewInit(s, e) {
            fab.SetActionContext("NewRowContext");
            s.SetFocusedRowIndex(-1);
        }
    </script>
</asp:Content>