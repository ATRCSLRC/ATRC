<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Checador.aspx.cs" Inherits="ATRCWEB.Checador.Checador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 class="box-title">Checador</h3>
            </div>

            <div style="height: 25px;"></div>
            <div class="row center-block" style="width: 95%; padding-bottom: 20px">
                <div class="form-group">
                    <label class="control-label">Fecha de entrada:</label>
                    <dx:BootstrapDateEdit ID="tdeFecha" ClientInstanceName="tdeFecha" DisplayFormatString="D" runat="server">
                        <ValidationSettings ValidationGroup="Guardar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                    </dx:BootstrapDateEdit>
                </div>
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
                    <label class="control-label">Hora de entrada:</label>
                    <dx:BootstrapTimeEdit ID="tmeEntrada" ClientInstanceName="tmeEntrada" EditFormatString="HH:mm" ClearButton-DisplayMode="Always" runat="server">
                        <ValidationSettings ValidationGroup="Guardar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                    </dx:BootstrapTimeEdit>
                </div>
                <div class="form-group">
                    <label class="control-label">Hora de salida:</label>
                    <dx:BootstrapTimeEdit ID="tmeSalida" ClientInstanceName="tmeSalida" EditFormatString="HH:mm" ClearButton-DisplayMode="Always" runat="server"></dx:BootstrapTimeEdit>
                </div>
                <div class="form-group">
                    <label class="control-label">Motivo:</label>
                    <dx:BootstrapMemo ID="memoObservacion" ClientInstanceName="memoObservacion" Width="100%" runat="server">
                    </dx:BootstrapMemo>
                </div>
                <br />
                <div class="pull-right">
                    <dx:BootstrapButton ID="btnGuardar" ClientInstanceName="btnGuardar" Text="Guardar" ValidationGroup="Guardar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <ClientSideEvents Click="function(s,e){ CallbackChecador.PerformCallback(cmbUsuario.GetSelectedItem().value); }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnCancelar" ClientInstanceName="btnCancelar" Text="Cancelar" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Danger" />
                        <ClientSideEvents Click="function(s,e){PopupControlNotificacion.Hide();}" />
                    </dx:BootstrapButton>
                </div>
            </div>
        </div>
    </div>
    <dx:ASPxHiddenField ID="HiddenNotificacion" ClientInstanceName="HiddenNotificacion" runat="server"></dx:ASPxHiddenField>
    <dx:ASPxCallback ID="CallbackChecador" ClientInstanceName="CallbackChecador" OnCallback="CallbackChecador_Callback" runat="server">
        <ClientSideEvents CallbackComplete="function(s,e){ alert('Los información se guardo correctamente'); window.location.href = '/Default.aspx'; }" />
    </dx:ASPxCallback>
</asp:Content>
