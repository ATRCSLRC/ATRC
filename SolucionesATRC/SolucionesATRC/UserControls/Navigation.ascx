<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigation.ascx.cs" Inherits="SolucionesATRC.Navigation" %>

<a href="https://www.devexpress.com/products/try/" target="_blank" class="demo-try-now-link bg-primary text-white">Try it now</a>
<dx:BootstrapTreeView runat="server">
    <CssClasses
        IconExpandNode="demo-icon demo-icon-col m-0"
        IconCollapseNode="demo-icon demo-icon-ex m-0"
        NodeList="demo-treeview-nodes m-0" Node="demo-treeview-node" Control="demo-treeview" />
    <Nodes>
        <dx:BootstrapTreeViewNode Text="Inicio" NavigateUrl="~/Default.aspx"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Pedidos de rutas" Expanded="true" NavigateUrl="~/Pedidos/MisPedidos.aspx" >
            <Nodes>
                 <dx:BootstrapTreeViewNode Text="Nuevos pedidos" NavigateUrl="~/Pedidos/PedidosRutas.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Pedidos aprobados" NavigateUrl="~/Pedidos/MisAprobados.aspx"></dx:BootstrapTreeViewNode>
                <dx:BootstrapTreeViewNode Text="Pedidos rechazados" NavigateUrl="~/Pedidos/MisRechazados.aspx"></dx:BootstrapTreeViewNode>
            </Nodes>
        </dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Aclaraciones" NavigateUrl="~/Default.aspx"></dx:BootstrapTreeViewNode>
        <dx:BootstrapTreeViewNode Text="Documentación" NavigateUrl="https://docs.devexpress.com/AspNetBootstrap/118796/getting-started" Target="_blank"></dx:BootstrapTreeViewNode>
    </Nodes>
</dx:BootstrapTreeView>