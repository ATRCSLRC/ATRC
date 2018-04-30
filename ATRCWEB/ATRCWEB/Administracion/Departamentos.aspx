<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Departamentos.aspx.cs" Inherits="ATRCWEB.Administracion.Departamentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 class="box-title">Departamentos</h3>
                <div class="box-tools pull-right">
                    <dx:BootstrapButton ID="btnNuevo" runat="server" Text="Nuevo departamento" CssClasses-Control="box-buttontitle" UseSubmitBehavior="false" CausesValidation="false" AutoPostBack="false">
                        <Badge IconCssClass="fa fa-plus" />
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){PopupControlDepartamento.Show(); lblTituloDepartamento.SetText('Departamento');}" />
                    </dx:BootstrapButton>
                </div>
            </div>
            <div style="height: 25px;"></div>
            <div class="row" style="text-align: center">
                <dx:BootstrapGridView ID="grdDepartamentos" ClientInstanceName="grdDepartamentos" KeyFieldName="Oid" CssClasses-Control="center-block" OnDataBinding="grdDepartamentos_DataBinding" OnHtmlRowPrepared="grdDepartamentos_HtmlRowPrepared" Width="95%" runat="server" AutoGenerateColumns="False">
                    <Settings ShowFilterRow="True" />
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="ID" Width="10%" FieldName="Oid" SettingsEditForm-Visible="False" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Descripción" Width="75%" FieldName="Descripcion" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewDataColumn Width="15%" FieldName="Acciones" VisibleIndex="3">
                            <DataItemTemplate>
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="border: none">
                                            <dx:BootstrapButton ID="btnModificar" ToolTip="Modificar" CssClasses-Control="btn pull-center" Width="100%" UseSubmitBehavior="false" CausesValidation="false" runat="server" AutoPostBack="false">
                                                <Badge IconCssClass="fa fa-edit" />
                                                <SettingsBootstrap RenderOption="Warning" />
                                            </dx:BootstrapButton>
                                        </td>
                                        <td style="border: none">
                                            <dx:BootstrapButton ID="btnEliminar" ToolTip="Eliminar" CssClasses-Control="btn pull-center" Width="100%" UseSubmitBehavior="false" CausesValidation="false" runat="server" AutoPostBack="false">
                                                <Badge IconCssClass="fa fa-remove" />
                                                <SettingsBootstrap RenderOption="Danger" />
                                            </dx:BootstrapButton>
                                        </td>
                                    </tr>
                                </table>
                            </DataItemTemplate>
                        </dx:BootstrapGridViewDataColumn>
                    </Columns>
                </dx:BootstrapGridView>
            </div>
            <dx:BootstrapPopupControl ID="PopupControlDepartamento" ClientInstanceName="PopupControlDepartamento" runat="server" ShowHeader="true" UseSubmitBehavior="false" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
                <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                <HeaderTemplate>
                    <dx:ASPxLabel ID="lblTituloDepartamento" ClientInstanceName="lblTituloDepartamento" runat="server" Text="Departamento" Font-Size="Large" Font-Bold="true"></dx:ASPxLabel>
                </HeaderTemplate>
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <label class="control-label">Descripción:</label>
                        <dx:BootstrapTextBox ID="txtDescripcion" ClientInstanceName="txtDescripcion" Width="100%" runat="server">
                            <ValidationSettings RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                        </dx:BootstrapTextBox>
                    </dx:ContentControl>
                </ContentCollection>
                <FooterTemplate>
                    <dx:BootstrapButton ID="btnGuardar" ClientInstanceName="btnGuardar" Text="Guardar" AutoPostBack="false" CausesValidation="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){ txtDescripcion.Validate(); if(txtDescripcion.GetIsValid()) { PopupControlDepartamento.Hide(); if(lblTituloDepartamento.GetText() == 'Departamento'){CallbackConfirmacion.PerformCallback('Nuevo');}else{CallbackConfirmacion.PerformCallback('Modificacion');}} }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" CausesValidation="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){PopupControlDepartamento.Hide(); txtDescripcion.SetText('');}" />
                    </dx:BootstrapButton>
                </FooterTemplate>
            </dx:BootstrapPopupControl>

            <dx:BootstrapPopupControl ID="PopupControlEliminar" ClientInstanceName="PopupControlEliminar" runat="server" HeaderText="Confirmación" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
                <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter"
                    FixedHeader="true" FixedFooter="true" />
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxLabel ID="lblContenidoConfimacion" ClientInstanceName="lblContenidoConfimacion" CssClass="control-label" runat="server" Text="" Font-Size="Large" Font-Bold="true"></dx:ASPxLabel>
                    </dx:ContentControl>
                </ContentCollection>
                <FooterTemplate>
                    <dx:BootstrapButton ID="btnAceptarConfirmacion" ClientInstanceName="btnAceptarConfirmacion" Text="Aceptar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){ PopupControlEliminar.Hide(); CallbackConfirmacion.PerformCallback('Eliminar'); }" />
                    </dx:BootstrapButton>

                    <dx:BootstrapButton ID="btnCancelarConfirmacion" ClientInstanceName="btnCancelarConfirmacion" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){ PopupControlEliminar.Hide(); }" />
                    </dx:BootstrapButton>
                </FooterTemplate>
            </dx:BootstrapPopupControl>
        </div>
    </div>
    <dx:ASPxHiddenField ID="HiddenDepartamento" ClientInstanceName="HiddenDepartamento" runat="server"></dx:ASPxHiddenField>
    <dx:ASPxCallback ID="CallbackConfirmacion" ClientInstanceName="CallbackConfirmacion" OnCallback="CallbackConfirmacion_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ txtDescripcion.SetText(''); grdDepartamentos.Refresh(); }" />
    </dx:ASPxCallback>
</asp:Content>
