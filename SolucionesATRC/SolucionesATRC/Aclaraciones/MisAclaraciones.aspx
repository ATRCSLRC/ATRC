<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="MisAclaraciones.aspx.cs" Inherits="SolucionesATRC.Aclaraciones.MisAclaraciones" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Aclaraciones</p>
        </div>
        <div class="row">
            <div id="MainPedido" class="col-12">
                <dx:BootstrapGridView ID="grdAclaraciones" ClientInstanceName="grdAclaraciones" OnDataBinding="grdAclaraciones_DataBinding" SettingsBehavior-AllowFocusedRow="true" OnCustomUnboundColumnData="grdAclaraciones_CustomUnboundColumnData" runat="server" AutoGenerateColumns="False">
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
            <dx:BootstrapFABAction ActionName="NewRow" ContextName="NewRowContext" Text="Nueva aclaración" IconCssClass="fa fa-plus"></dx:BootstrapFABAction>
        </Items>
        <ClientSideEvents ActionItemClick="OnActionItemClick" ActionCollapsing="OnActionCollapsing" />
    </dx:BootstrapFloatingActionButton>

    <%-- Popup --%>

    <dx:BootstrapPopupControl ID="PopupNueva" ClientInstanceName="PopupNueva" runat="server" Modal="true" ShowHeader="false"
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


    <%-- CallBack --%>

    <dx:ASPxCallback ID="CallbackNueva" ClientInstanceName="CallbackNueva" OnCallback="CallbackNueva_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ grdAclaraciones.SetFocusedRowIndex(-1); PopupNueva.Hide(); grdAclaraciones.Refresh();} " />
    </dx:ASPxCallback>

    <dx:ASPxCallback ID="CallbackDescargar" ClientInstanceName="CallbackDescargar" OnCallback="CallbackDescargar_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){window.open('../Descargar.aspx?ID=' + e.result, '_blank');}}" />
    </dx:ASPxCallback>

    <script>
        function OnActionItemClick(s, e) {
            if (e.actionName === "NewRow") {
                //$.LoadingOverlay("show");
                PopupNueva.Show();
                //$.LoadingOverlay("hide", true);
                //Loading.Show();
                //CallbackRedireccionar.PerformCallback();
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
                fab.SetActionContext("NewRowContext", true);
                
        }

        function OnGridViewInit(s, e) {
            fab.SetActionContext("NewRowContext");
            s.SetFocusedRowIndex(-1);
        }

    </script>
</asp:Content>