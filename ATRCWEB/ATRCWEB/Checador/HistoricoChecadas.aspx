<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="HistoricoChecadas.aspx.cs" Inherits="ATRCWEB.Checador.HistoricoChecadas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="box box-danger">
            <div class="box-header with-border">
                <h3 class="box-title">Historial checador</h3>
            </div>
            <div style="height: 25px;"></div>
            <div class="row center-block" style="width: 95%; padding-bottom: 20px">
                <label class="control-label">Del:</label>
                <dx:BootstrapDateEdit ID="dteDel" ClientInstanceName="dteDel" DisplayFormatString="D" runat="server">
                    <ValidationSettings ValidationGroup="Buscar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                </dx:BootstrapDateEdit>
                <label class="control-label">Al:</label>
                <dx:BootstrapDateEdit ID="dteAl" ClientInstanceName="dteAl" DisplayFormatString="D" runat="server">
                    <ValidationSettings ValidationGroup="Buscar" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                </dx:BootstrapDateEdit>
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
                <dx:BootstrapComboBox ID="cmbUsuario" ClientInstanceName="cmbUsuario" CallbackPageSize="8" OnDataBinding="cmbUsuario_DataBinding" EnableCallbackMode="true" ValueField="Oid" TextField="NomCompleto" ClientVisible="false" Width="100%" runat="server">
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
                <br />
                <dx:BootstrapButton ID="btnNuevo" runat="server" Text="Buscar" ValidationGroup="Buscar" CssClasses-Control="btn pull-right" AutoPostBack="false">
                    <Badge IconCssClass="fa fa-search" />
                    <SettingsBootstrap RenderOption="Primary" />
                    <ClientSideEvents Click="function(s,e){ if(cmbUsuario.GetSelectedItem() == null){grdChecadas.Refresh();}else{CallbackChecada.PerformCallback(cmbUsuario.GetSelectedItem().value);}}" />
                </dx:BootstrapButton>
                <dx:ASPxCallback ID="CallbackChecada" ClientInstanceName="CallbackChecada" OnCallback="CallbackChecada_Callback" runat="server">
                    <ClientSideEvents CallbackComplete="function(s,e){ grdChecadas.Refresh(); }" />
                </dx:ASPxCallback>
            </div>
        </div>
        <div class="panel-group" id="accordion">
            <div class="panel panel-default" id="panel1">
                <div class="panel-heading">
                    <h4 class="panel-title">
                        <a class="collapsed" data-toggle="collapse" data-target="#collapseOne"
                            href="#collapseOne">
                            <i class="nav-link-text fa fa-fw fa fa-info-circle"></i>
                            <span class="nav-link-text">Mas detalles</span>
                        </a>
                    </h4>

                </div>
                <div id="collapseOne" class="panel-collapse collapse">
                    <dx:BootstrapCallbackPanel ID="CallbackDetalles" ClientInstanceName="CallbackDetalles" EnableCallbackAnimation="true" OnCallback="CallbackDetalles_Callback" runat="server">
                        <ContentCollection>
                            <dx:ContentControl>
                                <table style="width: 100%">
                                    <tr>
                                        <td>&nbsp&nbsp&nbsp&nbsp</td>
                                        <td rowspan="4" style="width: 10%">
                                            <dx:BootstrapBinaryImage ID="imgFoto" ClientInstanceName="imgFoto" runat="server" CssClasses-Control="img-circle" Width="90"></dx:BootstrapBinaryImage>
                                        </td>
                                        <td style="width: 3%">&nbsp&nbsp&nbsp</td>
                                        <td>
                                            <label class="control-label">Fecha:&nbsp</label><span id="lblFecha" runat="server"></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>
                                            <label class="control-label">Nombre:&nbsp</label><span id="lblNombre" runat="server"></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>
                                            <label class="control-label">Del:&nbsp</label><span id="lblDel" runat="server"></span>
                                        </td>
                                        <td>
                                            <label class="control-label">AL:&nbsp</label><span id="lblAl" runat="server"></span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>&nbsp&nbsp&nbsp</td>
                                        <td>
                                            <label class="control-label">Horas laboradas:&nbsp</label><span id="lblHoras" runat="server"></span>
                                        </td>
                                    </tr>
                                </table>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:BootstrapCallbackPanel>

                </div>
            </div>
        </div>
        <div class="row center-block" style="text-align: center">
            <dx:BootstrapGridView ID="grdChecadas" ClientInstanceName="grdChecadas" KeyFieldName="Oid" OnRowUpdating="grdChecadas_RowUpdating" OnRowDeleting="grdChecadas_RowDeleting" OnCustomGroupDisplayText="grdChecadas_CustomGroupDisplayText"
                SettingsDetail-AllowOnlyOneMasterRowExpanded="true" OnDataBinding="grdChecadas_DataBinding" OnParseValue="grdChecadas_ParseValue" OnCellEditorInitialize="grdChecadas_CellEditorInitialize" OnCustomCallback="grdChecadas_CustomCallback" runat="server">
                <SettingsAdaptivity AdaptivityMode="HideDataCells" AllowOnlyOneAdaptiveDetailExpanded="true"></SettingsAdaptivity>
                <ClientSideEvents RowExpanding="function(s,e){grdChecadas.PerformCallback(e.visibleIndex); e.cancel = true;}" FocusedRowChanged="function(s,e){grdChecadas.GetRowValues(grdChecadas.GetFocusedRowIndex(), 'Oid;', function(s){ CallbackDetalles.PerformCallback(s);});}" />
                <SettingsEditing Mode="Inline"></SettingsEditing>
                <SettingsBehavior ConfirmDelete="true" AllowFocusedRow="true" />
                <SettingsDataSecurity AllowEdit="true" AllowDelete="true" />
                <Columns>
                    <dx:BootstrapGridViewCommandColumn ShowEditButton="true" ShowDeleteButton="true" Width="5%" />
                    <dx:BootstrapGridViewTextColumn Caption="ID" Width="10%" FieldName="Oid" SettingsEditForm-Visible="False" Visible="false" VisibleIndex="1">
                    </dx:BootstrapGridViewTextColumn>
                    <dx:BootstrapGridViewDateColumn Caption="Fecha de checada" Width="20%" FieldName="FechaChecada" SettingsEditForm-Visible="False" VisibleIndex="2">
                    </dx:BootstrapGridViewDateColumn>
                    <dx:BootstrapGridViewDataColumn Caption="Usuario" GroupIndex="0" FieldName="Usuario.Usuario.NumEmpleado" VisibleIndex="3">
                    </dx:BootstrapGridViewDataColumn>
                    <dx:BootstrapGridViewTimeEditColumn Caption="Hora de checada entrada" Width="30%" FieldName="HoraChecadaEntrada" VisibleIndex="4">
                    </dx:BootstrapGridViewTimeEditColumn>
                    <dx:BootstrapGridViewTimeEditColumn Caption="Hora de checada salida" Width="30%" FieldName="HoraChecadaSalida" VisibleIndex="5">
                    </dx:BootstrapGridViewTimeEditColumn>
                    <dx:BootstrapGridViewTextColumn Caption="Motivo" Width="20%" FieldName="Motivo" VisibleIndex="6">
                    </dx:BootstrapGridViewTextColumn>
                </Columns>
            </dx:BootstrapGridView>
        </div>
    </div>
</asp:Content>
