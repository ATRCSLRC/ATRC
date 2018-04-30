<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Notificaciones.aspx.cs" Inherits="ATRCWEB.Checador.Notificaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 class="box-title">Notificaciones</h3>
                <div class="box-tools pull-right">
                    <dx:BootstrapButton ID="btnNuevo" runat="server" Text="Nuevo notificación" CssClasses-Control="box-buttontitle" UseSubmitBehavior="false" AutoPostBack="false">
                        <Badge IconCssClass="fa fa-plus" />
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){PopupControlNotificacion.Show(); lblTituloNotificacion.SetText('Notificación');}" />
                    </dx:BootstrapButton>
                </div>
            </div>
            <div style="height: 25px;"></div>
            <div class="row" style="text-align: center">
                <dx:BootstrapGridView ID="grdNotificaciones" ClientInstanceName="grdNotificaciones" CssClasses-Control="center-block" KeyFieldName="Oid" OnDataBinding="grdNotificaciones_DataBinding" OnHtmlRowPrepared="grdNotificaciones_HtmlRowPrepared" Width="95%" runat="server" AutoGenerateColumns="False">
                    <Settings ShowFilterRow="True" />
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="ID" Width="10%" FieldName="Oid" Visible="false" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Usuario con notificación" Width="20%" FieldName="Receptor.Usuario.Nombre" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Responsable" Width="20%" FieldName="Responsable.Usuario.Nombre" VisibleIndex="3">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Motivo" Width="45%" FieldName="Motivo" VisibleIndex="4">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewDataColumn Width="10%" FieldName="Acciones" VisibleIndex="5">
                            <DataItemTemplate>
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="border: none">
                                            <dx:BootstrapButton ID="btnEliminar" ToolTip="Eliminar" CssClasses-Control="btn pull-center" Width="100%" UseSubmitBehavior="false" runat="server" AutoPostBack="false">
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
            <dx:BootstrapPopupControl ID="PopupControlNotificacion" ClientInstanceName="PopupControlNotificacion" runat="server" ShowHeader="true" ShowFooter="true" UseSubmitBehavior="false" CloseAction="None" ShowCloseButton="false">
                <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                <HeaderTemplate>
                    <dx:ASPxLabel ID="lblTituloNotificacion" ClientInstanceName="lblTituloNotificacion" runat="server" Text="Notificación" Font-Size="Large" Font-Bold="true"></dx:ASPxLabel>
                </HeaderTemplate>
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <div class="form-group">
                            <label class="control-label">Usuario:</label>
                            <dx:BootstrapComboBox ID="cmbUsuario" ClientInstanceName="cmbUsuario" CallbackPageSize="8" OnDataBinding="cmbUsuario_DataBinding" EnableCallbackMode="true" ValueField="Oid" TextField="NomCompleto" Width="100%" runat="server">
                                <ValidationSettings ValidationGroup="Guardar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                                <ClearButton DisplayMode="OnHover" />
                                <%--<Fields>
                                    <dx:BootstrapListBoxField FieldName="NumEmpleado" />
                                    <dx:BootstrapListBoxField FieldName="Nombre" />
                                </Fields>
                                <ItemTemplate>
                                    <div class="media list-group-item">
                                        <div class="pull-left image">
                                            <dx:BootstrapBinaryImage runat="server" AlternateText="" CssClasses-Control="img-circle" Value='<%# ObtenerFoto( Eval("Imagen") == null ? "" : Eval("Imagen").ToString() ) %>' Width="64">
                                            </dx:BootstrapBinaryImage>
                                        </div>
                                        <div class="pull-left info">
                                            <h5><%# Eval("NumEmpleado") %> - <%# Eval("Nombre") %></h5>
                                            <a><i class="text-red"><%# Eval("Departamento") %></i></a>
                                        </div>
                                    </div>
                                </ItemTemplate>--%>
                            </dx:BootstrapComboBox>
                        </div>
                        <div class="form-group">
                            <label class="control-label">Pasar con:</label>
                            <dx:BootstrapComboBox ID="cmbResponsable" ClientInstanceName="cmbResponsable" CallbackPageSize="8" OnDataBinding="cmbResponsable_DataBinding" EnableCallbackMode="true" ValueField="Oid" TextField="NomCompleto" Width="100%" runat="server">
                                <ValidationSettings ValidationGroup="Guardar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                                <ClearButton DisplayMode="OnHover" />
                                <%--<Fields>
                                    <dx:BootstrapListBoxField FieldName="NumEmpleado" />
                                    <dx:BootstrapListBoxField FieldName="Nombre" />
                                </Fields>
                                <ItemTemplate>
                                    <div class="media list-group-item">
                                        <div class="pull-left image">
                                            <dx:BootstrapBinaryImage runat="server" AlternateText="" CssClasses-Control="img-circle" Value='<%# ObtenerFoto( Eval("Imagen") == null ? "" : Eval("Imagen").ToString() ) %>' Width="64">
                                            </dx:BootstrapBinaryImage>
                                        </div>
                                        <div class="pull-left info">
                                            <h5><%# Eval("NumEmpleado") %> - <%# Eval("Nombre") %></h5>
                                            <a><i class="text-red"><%# Eval("Departamento") %></i></a>
                                        </div>
                                    </div>
                                </ItemTemplate>--%>
                            </dx:BootstrapComboBox>
                        </div>
                        <div class="form-group">
                            <label class="control-label">Observación:</label>
                            <dx:BootstrapMemo ID="memoObservacion" ClientInstanceName="memoObservacion" Width="100%" runat="server">
                            </dx:BootstrapMemo>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
                <FooterTemplate>
                    <dx:BootstrapButton ID="btnGuardar" ClientInstanceName="btnGuardar" Text="Guardar" ValidationGroup="Guardar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){if(ASPxClientEdit.ValidateGroup('Guardar')){ PopupControlNotificacion.Hide(); if(lblTituloNotificacion.GetText() == 'Notificación'){CallbackConfirmacion.PerformCallback('Nuevo|' + cmbUsuario.GetSelectedItem().value +'|'+ cmbResponsable.GetSelectedItem().value);}} }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){PopupControlNotificacion.Hide(); cmbUsuario.SetSelectedIndex(-1); cmbResponsable.SetSelectedIndex(-1); memoObservacion.SetText(''); }" />
                    </dx:BootstrapButton>
                </FooterTemplate>
            </dx:BootstrapPopupControl>

            <dx:BootstrapPopupControl ID="PopupControlEliminar" ClientInstanceName="PopupControlEliminar" runat="server" HeaderText="Confirmación" UseSubmitBehavior="false" ShowHeader="true" ShowFooter="true" CloseAction="None" ShowCloseButton="false">
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
    <dx:ASPxHiddenField ID="HiddenNotificacion" ClientInstanceName="HiddenNotificacion" runat="server"></dx:ASPxHiddenField>
    <dx:ASPxCallback ID="CallbackConfirmacion" ClientInstanceName="CallbackConfirmacion" OnCallback="CallbackConfirmacion_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){  grdNotificaciones.Refresh(); cmbUsuario.SetSelectedIndex(-1); cmbResponsable.SetSelectedIndex(-1); memoObservacion.SetText(''); }" />
    </dx:ASPxCallback>
</asp:Content>
