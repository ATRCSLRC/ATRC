<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="PlantillaRutas.aspx.cs" Inherits="SolucionesATRC.Plantilla.PlantillaRutas" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Plantillas de rutas</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdPlantillas" ClientInstanceName="grdPlantillas" OnDataBinding="grdPlantillas_DataBinding" SettingsBehavior-AllowFocusedRow="true" runat="server" AutoGenerateColumns="False">
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <ClientSideEvents RowClick="OnRowClick" Init="OnGridViewInit" />
                    <SettingsPopup>
                        <HeaderFilter MinHeight="140px"></HeaderFilter>
                    </SettingsPopup>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="Nombre de la plantilla" FieldName="Nombre" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Cantidad de rutas" FieldName="Rutas" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                    </Columns>
                    <SettingsSearchPanel Visible="True" />
                </dx:BootstrapGridView>
            </div>
        </div>
    </div>


    <dx:BootstrapFloatingActionButton ID="fab" ClientInstanceName="fab" runat="server" ContainerCssSelector="#MainPedido" InitialActionContext="NewRowContext" VerticalPosition="Bottom">
        <Items>
            <dx:BootstrapFABAction ActionName="NewRow" ContextName="NewRowContext" Text="Nueva plantilla"></dx:BootstrapFABAction>
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

    <dx:BootstrapPopupControl ID="PopupEliminar" ClientInstanceName="PopupEliminar" runat="server" Modal="true" ShowHeader="false"
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <FooterTemplate>
            <dx:BootstrapButton runat="server" Text="Guardar" ValidationGroup="Ruta" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) { CallbackEliminar.PerformCallback(grdPlantillas.GetFocusedRowIndex());  }" />
            </dx:BootstrapButton>
            <dx:BootstrapButton runat="server" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false">
                <ClientSideEvents Click="function(s, e) {fab.SetActionContext('NewRowContext'); grdPlantillas.SetFocusedRowIndex(-1); PopupEliminar.Hide();}" />
            </dx:BootstrapButton>
        </FooterTemplate>
        <ContentCollection>
            <dx:ContentControl>
                <p class="col-12 demo-content" id="txtConfirm"></p>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>

    <dx:ASPxCallback ID="CallbackRedireccionar" ClientInstanceName="CallbackRedireccionar" OnCallback="CallbackRedireccionar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s, e){ 
                    if(e.result != ''){
                        window.location.href = 'EdicionPlantillaRutas.aspx?id=' + e.result; 
                    }else
            {
                window.location.href = 'EdicionPlantillaRutas.aspx'; 
            }
                }" CallbackError="function(s,e){$.LoadingOverlay('hide', true);}" />
    </dx:ASPxCallback>
    <dx:ASPxCallback ID="CallbackEliminar" ClientInstanceName="CallbackEliminar" OnCallback="CallbackEliminar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdPlantillas.SetFocusedRowIndex(-1); PopupEliminar.Hide(); grdPlantillas.Refresh();}" />
    </dx:ASPxCallback>

    <dx:BootstrapPopupControl ID="Loading" ClientInstanceName="Loading" Width="5%" CssClasses-Control=".dxbs-popup .modal-content { width:10% !important; } " CssClasses-Content=".dxbs-popup .modal-content { width:10% !important; }" runat="server" ShowHeader="false" ShowFooter="false" Modal="true" PopupHorizontalAlign="WindowCenter"
        PopupVerticalAlign="WindowCenter" CloseAction="None">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
        <ContentCollection>
            <dx:ContentControl Width="50%">
                <div class="d-flex justify-content-center">
                    <div class="spinner-border" role="status" style="width: 3rem; height: 3rem;">
                        <span class="sr-only">Loading...</span>
                    </div>
                </div>
            </dx:ContentControl>
        </ContentCollection>
    </dx:BootstrapPopupControl>
      
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
                CallbackRedireccionar.PerformCallback(grdPlantillas.GetFocusedRowIndex());
            }
            else if (e.actionName === "DeleteRow") {
                fab.SetActionContext("DeleteRow");
                grdPlantillas.GetRowValues(grdPlantillas.GetFocusedRowIndex(), 'Nombre', OnGetRowValues);
                //grdPlantillas.DeleteRow(gridFAB.GetFocusedRowIndex());
                //grdPlantillas.SetFocusedRowIndex(-1);
            }
            else if (e.actionName === "Save") {
                grdPlantillas.UpdateEdit();
            }
            else if (e.actionName === "Cancel") {
                grdPlantillas.CancelEdit();
            }
        }
        function OnActionCollapsing(s, e) {
            if ((e.contextName === "FocusedRowContext" || e.contextName === "EditingRowContext") && e.collapseReason === ASPxClientFloatingActionButtonCollapseReason.CollapseButton) {
                setTimeout(function () {
                    grdPlantillas.SetFocusedRowIndex(-1);
                    fab.SetActionContext("NewRowContext");
                }, 100);
            }
        }

        function OnRowClick(s, e) {
            if (s.IsNewRowEditing() || s.IsEditing())
                e.cancel = true;
            else
                fab.SetActionContext("FocusedRowContext", true);
        }

        function OnGridViewInit(s, e) {
            fab.SetActionContext("NewRowContext");
            s.SetFocusedRowIndex(-1);
        }

        function OnGetRowValues(values) {
            txtConfirm.innerText = "¿Desea eliminar la ruta " + values + "?";
            PopupEliminar.Show();
        }
    </script>
</asp:Content>
