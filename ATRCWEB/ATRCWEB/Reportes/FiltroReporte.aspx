<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="FiltroReporte.aspx.cs" Inherits="ATRCWEB.Reportes.FiltroReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 id="titulo" runat="server" class="box-title"></h3>
            </div>
            <div style="height: 25px;"></div>
            <div class="row center-block" style="width: 95%; padding-bottom: 20px">
                <div class="form-group">
                    <label class="control-label">Fecha del:</label>
                    <dx:BootstrapDateEdit ID="dteDel" ClientInstanceName="dteDel" DisplayFormatString="D" runat="server"></dx:BootstrapDateEdit>
                </div>
                <div class="form-group">
                    <label class="control-label">Al:</label>
                    <dx:BootstrapDateEdit ID="dteAl" ClientInstanceName="dteAl" DisplayFormatString="D" runat="server"></dx:BootstrapDateEdit>
                </div>
                <div class="form-group" id="divTipoBusqueda" runat="server">
                    <label class="control-label">Tipo de búsqueda:</label>
                    <dx:BootstrapRadioButtonList ID="rblTipoBusqueda" ClientInstanceName="rblTipoBusqueda" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                        <Items>
                            <dx:BootstrapListEditItem Text="Todos los usuarios" Selected="true" Value="Todos los usuarios">
                            </dx:BootstrapListEditItem>
                            <dx:BootstrapListEditItem Text="Usuario específico" Value="Usuario específico">
                            </dx:BootstrapListEditItem>
                        </Items>
                        <ClientSideEvents SelectedIndexChanged="function(s,e){ if(s.GetSelectedIndex() == 1){ cmbUsuario.SetVisible(true); } else{ cmbUsuario.SetVisible(false); }}" />
                    </dx:BootstrapRadioButtonList>
                    <dx:BootstrapComboBox ID="cmbUsuario" ClientInstanceName="cmbUsuario" CallbackPageSize="8" OnDataBinding="cmbUsuario_DataBinding" EnableCallbackMode="true" ValueField="Oid" ClientVisible="false" TextField="NomCompleto" Width="100%" runat="server">

                        <ClearButton DisplayMode="Always" />
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
                <br />
                <div class="pull-right">
                    <dx:BootstrapButton ID="btnImprimirConcentrado" ClientInstanceName="btnImprimirConcentrado" Text="Imprimir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <Badge IconCssClass="fa fa-print" />
                        <ClientSideEvents Click="function(s,e){ CallbackReporte.PerformCallback(); }" />
                    </dx:BootstrapButton>
                    <dx:BootstrapButton ID="btnImprimir" ClientInstanceName="btnImprimir" Text="Imprimir" AutoPostBack="false" UseSubmitBehavior="false" runat="server">
                        <SettingsBootstrap RenderOption="Success" />
                        <Badge IconCssClass="fa fa-print" />
                        <ClientSideEvents Click="function(s,e){ if(cmbUsuario.GetSelectedItem() == null){CallbackReporte.PerformCallback();}else{CallbackReporte.PerformCallback(cmbUsuario.GetSelectedItem().value);} }" />
                    </dx:BootstrapButton>
                </div>
            </div>
        </div>
        <dx:ASPxCallback ID="CallbackReporte" ClientInstanceName="CallbackReporte" OnCallback="CallbackReporte_Callback" runat="server">
            <ClientSideEvents CallbackComplete="function(s,e){ if(e.result != ''){ alert(e.result);}}" />
        </dx:ASPxCallback>
    </div>
</asp:Content>
