<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.cs" Inherits="SolucionesATRC.Default" %>


<%@ Register Src="~/UserControls/Widget.ascx" TagPrefix="demo" TagName="Widget" %>
<%@ Register Src="~/UserControls/WidgetsContainer.ascx" TagPrefix="demo" TagName="WidgetsContainer" %>


<asp:Content runat="server" ContentPlaceHolderID="head">
    <script type="text/javascript" src="Content/dashboard.js" defer></script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="container-fluid">
        <div class="row">
            <p class="col-12 demo-content-title">Inicio</p>
        </div>
        <div class="row mb-4">
            <div class="col-12">
                <dx:BootstrapCardView ID="CardViewControl" ClientInstanceName="CardViewControl" runat="server"
                    OnCustomCallback="CardViewControl_CustomCallback" OnDataBinding="CardViewControl_DataBinding">
                    <CssClasses Control="shadow rounded demo-card-view demo-widget-area"
                        Content="bg-primary text-white border-0"
                        Card="bg-primary demo-card-view-item" PanelBodyBottom="bg-primary text-white" />
                    <CssClassesPager PageNumber="text-white" />
                    <SettingsPager ItemsPerPage="1" EnableAdaptivity="true">
                        <Summary Position="Right" />
                        <NextPageButton IconCssClass="demo-icon demo-icon-right" Text="" />
                        <PrevPageButton IconCssClass="demo-icon demo-icon-left" Text="" />
                    </SettingsPager>
                    <SettingsLayout CardColSpanXs="12" CardColSpanSm="12" CardColSpanMd="6" CardColSpanLg="4" CardColSpanXl="3" />
                    <Templates>
                        <Card>
                            <div class="d-flex">
                                <div class="p-2 mr-1">
                                    <span class="<%# Eval("Icono") %>"></span>
                                </div>
                                <div>
                                    <div class="text-nowrap" style="font-size: 2rem;">
                                        <span class="font-weight-bold ml-2"><%# Eval("Total") %></span>
                                    </div>
                                    <div class="text-nowrap">
                                        <p style="font-size: 1rem;"><%# Eval("Titulo") %></p>
                                    </div>
                                </div>
                            </div>
                        </Card>
                    </Templates>
                </dx:BootstrapCardView>
            </div>
        </div>
    </div>

    <asp:ObjectDataSource ID="DashboardCardsDataSource" runat="server"
        DataObjectTypeName="SolucionesATRC.DashboardCard"
        TypeName="SolucionesATRC.DataProvider"
        SelectMethod="GetDashboardCards"></asp:ObjectDataSource>
</asp:Content>