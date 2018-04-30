<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Reporte.aspx.cs" Inherits="ATRCWEB.Reportes.Reporte" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <br />
        <br />
        <dx:ASPxWebDocumentViewer ID="Viewer" runat="server" DisableHttpHandlerValidation="False" Height="800px"  >
        </dx:ASPxWebDocumentViewer>
        
    <dx:BootstrapPageControl ID="pgcGafete" ClientInstanceName="pgcGafete" runat="server" ClientVisible="false"  ActiveTabIndex="0">
        <TabPages>
            <dx:BootstrapTabPage Name="TabGafeteFrente" Text="Parte frontal de gafete">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxWebDocumentViewer ID="ViewerGafeteFrontal" ClientInstanceName="ViewerGafeteFrontal" Height="800px" runat="server"></dx:ASPxWebDocumentViewer>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>
            <dx:BootstrapTabPage Name="TabGafeteAtras" Text="Parte trasera de gafete">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxWebDocumentViewer ID="ViewerGafeteTrasero" ClientInstanceName="ViewerGafeteTrasero" Height="800px" runat="server"></dx:ASPxWebDocumentViewer>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>
        </TabPages>

    </dx:BootstrapPageControl>
        </div>
    </asp:Content>
