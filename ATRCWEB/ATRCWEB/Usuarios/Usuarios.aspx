<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Usuarios.aspx.cs" Inherits="ATRCWEB.Usuarios.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 class="box-title">Usuarios</h3>
                <div class="box-tools pull-right">
                    <dx:BootstrapButton ID="btnNuevo" runat="server" Text="Nuevo usuario" CssClasses-Control="box-buttontitle" CausesValidation="false" UseSubmitBehavior="false" AutoPostBack="false">
                        <Badge IconCssClass="fa fa-plus" />
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){ pgcUsuario.SetActiveTabIndex(0); pgcUsuario.GetTabByName('Seguridad').SetVisible(false); txtNombre.SetIsValid(true); txtRFC.SetIsValid(true); txtIMSS.SetIsValid(true); cmbPuestos.SetIsValid(true); 
                  cmbDepartamento.SetIsValid(true); chkAdmistrador.SetChecked(false); PopupControlUsuario.Show(); txtContraseña.SetText(''); lblTituloNotificacion.SetText('Usuario'); CallbackNumEmpleado.PerformCallback(); bniFoto.PerformCallback(); }" />
                    </dx:BootstrapButton>
                    <dx:ASPxCallback ID="CallbackNumEmpleado" ClientInstanceName="CallbackNumEmpleado" OnCallback="CallbackNumEmpleado_Callback" runat="server">
                        <ClientSideEvents CallbackComplete="function(s,e){ txtNumEmpleado.SetText(e.result);}" />
                    </dx:ASPxCallback>
                </div>
            </div>
            <div style="height: 25px;"></div>
            <div class="row" style="text-align: center">
                <dx:BootstrapGridView ID="grdUsuarios" ClientInstanceName="grdNotificaciones" KeyFieldName="Oid" CssClasses-Control="center-block" OnDataBinding="grdUsuarios_DataBinding" OnHtmlRowPrepared="grdUsuarios_HtmlRowPrepared" Width="95%" runat="server" AutoGenerateColumns="False">
                    <Settings ShowFilterRow="True" />
                    <SettingsBehavior AllowFocusedRow="true" />
                    <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                    <Columns>
                        <dx:BootstrapGridViewTextColumn Caption="ID" Width="10%" FieldName="Oid" Visible="false" VisibleIndex="1">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Número de empleado" Width="15%" FieldName="NumEmpleado" VisibleIndex="2">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewTextColumn Caption="Nombre" Width="75%" FieldName="Nombre" VisibleIndex="3">
                        </dx:BootstrapGridViewTextColumn>
                        <dx:BootstrapGridViewDataColumn Width="10%" FieldName="Acciones" VisibleIndex="4">
                            <DataItemTemplate>
                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <dx:BootstrapButton ID="btnModificar" ToolTip="Modificar" CssClasses-Control="btn pull-center" Width="100%" runat="server" UseSubmitBehavior="false" AutoPostBack="false">
                                                <Badge IconCssClass="fa fa-edit" />
                                                <SettingsBootstrap RenderOption="Warning" />
                                            </dx:BootstrapButton>
                                        </td>
                                        <td>
                                            <dx:BootstrapButton ID="btnImprimir" ToolTip="Imprimir Gafete" CssClasses-Control="btn pull-center" UseSubmitBehavior="false" Width="100%" runat="server" AutoPostBack="false">
                                                <Badge IconCssClass="fa fa-edit" />
                                                <SettingsBootstrap RenderOption="Primary" />
                                            </dx:BootstrapButton>
                                        </td>
                                        <td>
                                            <dx:BootstrapButton ID="btnEliminar" ToolTip="Eliminar" CssClasses-Control="btn pull-center" UseSubmitBehavior="false" Width="100%" runat="server" AutoPostBack="false">
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
            <dx:BootstrapPopupControl ID="PopupControlUsuario" ClientInstanceName="PopupControlUsuario" runat="server" UseSubmitBehavior="false" ShowHeader="true" ShowFooter="true" Width="300%" Height="400px" CloseAction="None" ShowCloseButton="false">
                <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" FixedHeader="true" FixedFooter="true" />
                <HeaderTemplate>
                    <dx:ASPxLabel ID="lblTituloNotificacion" ClientInstanceName="lblTituloNotificacion" runat="server" Text="Usuario" Font-Size="Large" Font-Bold="true"></dx:ASPxLabel>
                </HeaderTemplate>
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:BootstrapPageControl ID="pgcUsuario" ClientInstanceName="pgcUsuario" runat="server" ActiveTabIndex="0">
                            <TabPages>
                                <dx:BootstrapTabPage Text="Datos generales">
                                    <ContentCollection>
                                        <dx:ContentControl runat="server">
                                            <div class="form-group">
                                                <dx:BootstrapCheckBox ID="chkAdmistrador" ClientInstanceName="chkAdmistrador" Text="Es administrador" runat="server">
                                                    <CssClasses Control="pull-right"></CssClasses>
                                                    <ClientSideEvents CheckedChanged="function(s,e){var isVisible = s.GetChecked(); pgcUsuario.GetTabByName('Seguridad').SetVisible(isVisible);}" />
                                                </dx:BootstrapCheckBox>
                                                <br />
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Número de empleado:</label>
                                                <dx:BootstrapTextBox ID="txtNumEmpleado" ClientInstanceName="txtNumEmpleado" ReadOnly="true" runat="server"></dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Nombre completo:</label>
                                                <dx:BootstrapTextBox ID="txtNombre" ClientInstanceName="txtNombre" runat="server">
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">RFC:</label>
                                                <dx:BootstrapTextBox ID="txtRFC" ClientInstanceName="txtRFC" runat="server">
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">IMSS:</label>
                                                <dx:BootstrapTextBox ID="txtIMSS" ClientInstanceName="txtIMSS" runat="server">
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Puesto:</label>
                                                <dx:BootstrapComboBox ID="cmbPuestos" ClientInstanceName="cmbPuestos" TextField="Descripcion" ValueField="Oid" TextFormatString="{0}" Width="100%" EnableCallbackMode="True" runat="server">
                                                    <ClearButton DisplayMode="OnHover" />
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapComboBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Departamento:</label>
                                                <dx:BootstrapComboBox ID="cmbDepartamento" ClientInstanceName="cmbDepartamento" TextField="Descripcion" ValueField="Oid" TextFormatString="{0}" Width="100%" EnableCallbackMode="True" runat="server">
                                                    <ClearButton DisplayMode="OnHover" />
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapComboBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Número de credencial:</label>
                                                <dx:BootstrapTextBox ID="txtCredencial" ClientInstanceName="txtCredencial" runat="server"></dx:BootstrapTextBox>
                                            </div>
                                        </dx:ContentControl>
                                    </ContentCollection>
                                </dx:BootstrapTabPage>
                                <dx:BootstrapTabPage Text="Datos adicionales" Name="DatosAdicinales">
                                    <ContentCollection>
                                        <dx:ContentControl runat="server">
                                            <div class="form-group">
                                                <label class="control-label">Fecha de ingreso:</label>
                                                <dx:BootstrapDateEdit ID="dteIngreso" ClientInstanceName="dteIngreso" runat="server"></dx:BootstrapDateEdit>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Patrón:</label>
                                                <dx:BootstrapComboBox ID="cmbPatron" ClientInstanceName="cmbPatron" runat="server">
                                                    <ClearButton DisplayMode="OnHover" />
                                                </dx:BootstrapComboBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Avisar a:</label>
                                                <dx:BootstrapTextBox ID="txtAvisarA" ClientInstanceName="txtAvisarA" runat="server"></dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Teléfono avisar:</label>
                                                <dx:BootstrapTextBox ID="txtTelefono" ClientInstanceName="txtTelefono" runat="server">
                                                    <MaskSettings Mask="(999)-00-00000" ShowHints="true" />
                                                </dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Tipo de sangre:</label>
                                                <dx:BootstrapTextBox ID="txtTipoSangre" ClientInstanceName="txtTipoSangre" runat="server"></dx:BootstrapTextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="control-label">Foto:</label>
                                                <dx:BootstrapBinaryImage ID="bniFoto" ClientInstanceName="bniFoto" OnCustomCallback="bniFoto_CustomCallback" Height="120px" runat="server">
                                                    <EditingSettings Enabled="true">
                                                        <ButtonPanelSettings Visibility="OnMouseOver" />
                                                    </EditingSettings>
                                                </dx:BootstrapBinaryImage>
                                            </div>
                                        </dx:ContentControl>
                                    </ContentCollection>
                                </dx:BootstrapTabPage>
                                <dx:BootstrapTabPage ClientVisible="false" Text="Seguridad" Name="Seguridad">
                                    <ContentCollection>
                                        <dx:ContentControl runat="server">
                                            <div class="form-group">
                                                <label class="control-label">Contraseña:</label>
                                                <dx:BootstrapTextBox ID="txtContraseña" ClientInstanceName="txtContraseña" Password="true" runat="server">
                                                    <ValidationSettings ValidationGroup="Guardar" SetFocusOnError="true" CausesValidation="false">
                                                        <RequiredField IsRequired="True"></RequiredField>
                                                    </ValidationSettings>
                                                </dx:BootstrapTextBox>
                                            </div>
                                        </dx:ContentControl>
                                    </ContentCollection>
                                </dx:BootstrapTabPage>
                            </TabPages>
                        </dx:BootstrapPageControl>
                    </dx:ContentControl>
                </ContentCollection>
                <FooterTemplate>
                    <dx:BootstrapButton ID="btnGuardar" ClientInstanceName="btnGuardar" Text="Guardar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){ if(ASPxClientEdit.ValidateGroup('Guardar')){ PopupControlUsuario.Hide(); if(lblTituloNotificacion.GetText() == 'Usuario'){CallbackUsuario.PerformCallback('Nuevo');}else{CallbackUsuario.PerformCallback('Modificacion');}} }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){ pgcUsuario.GetTabByName('Seguridad').SetVisible(false); CallbackUsuario.PerformCallback('Cancelar'); PopupControlUsuario.Hide(); chkAdmistrador.SetChecked(false); txtNumEmpleado.SetText(''); txtNombre.SetText(''); txtRFC.SetText('');
                        txtIMSS.SetText(''); txtCredencial.SetText(''); cmbPuestos.SetSelectedIndex(-1); cmbDepartamento.SetSelectedIndex(-1); dteIngreso.SetValue(null);  
                        txtAvisarA.SetText(''); txtTipoSangre.SetText(''); bniFoto.PerformCallback(); txtContraseña.SetText(''); txtTelefono.SetText('');}" />
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
                        <ClientSideEvents Click="function(s,e){ PopupControlEliminar.Hide(); CallbackUsuario.PerformCallback('Eliminar'); }" />
                    </dx:BootstrapButton>

                    <dx:BootstrapButton ID="btnCancelarConfirmacion" ClientInstanceName="btnCancelarConfirmacion" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){ PopupControlEliminar.Hide(); }" />
                    </dx:BootstrapButton>
                </FooterTemplate>
            </dx:BootstrapPopupControl>
        </div>
    </div>
    <dx:ASPxHiddenField ID="HiddenUsuario" ClientInstanceName="HiddenUsuario" runat="server"></dx:ASPxHiddenField>
    <dx:ASPxCallback ID="CallbackUsuario" ClientInstanceName="CallbackUsuario" OnCallback="CallbackUsuario_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){  grdNotificaciones.Refresh(); txtNumEmpleado.SetText(''); txtNombre.SetText(''); txtRFC.SetText('');
            txtIMSS.SetText(''); txtCredencial.SetText(''); cmbPuestos.SetSelectedIndex(-1); cmbDepartamento.SetSelectedIndex(-1); dteIngreso.SetValue(null);
            cmbPatron.SetSelectedIndex(-1); txtAvisarA.SetText(''); txtTipoSangre.SetText(''); txtContraseña.SetText('');  txtTelefono.SetText('');}" />
    </dx:ASPxCallback>
</asp:Content>

