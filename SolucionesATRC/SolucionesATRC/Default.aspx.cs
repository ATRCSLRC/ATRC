using DevExpress.Web.Bootstrap;
using System;
using SolucionesATRC;
using System.Web.Security;
using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace SolucionesATRC {
    public partial class Default : System.Web.UI.Page {


        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.Header.DataBind();
            if (!Page.IsCallback || !Page.IsPostBack)
            {
                CardViewControl.DataBind();
            }
        }

        protected void CardViewControl_CustomCallback(object sender, DevExpress.Web.ASPxCardViewCustomCallbackEventArgs e) {
            int newPageSize = Int32.Parse(e.Parameters);
            CardViewControl.SettingsPager.ItemsPerPage = newPageSize;
            CardViewControl.DataBind();
        }

        protected void BootstrapScheduler1_Init(object sender, EventArgs e) {
            var scheduler = (BootstrapScheduler)sender;
            scheduler.Storage.Appointments.Labels.Clear();
            foreach(SchedulerLabel label in SchedulerLabelsHelper.GetItems())
                scheduler.Storage.Appointments.Labels.Add(label.Id, label.Name, label.BackgroundCssClass, label.TextCssClass);
        }

        protected void BootstrapButton1_Click(object sender, EventArgs e)
        {
            Session["USERNAME" + Session.SessionID] = null;
            Session["OidAdministrador"] = null;
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx", false);
        }

        public class PedidosEstado
        {
            public PedidosEstado(string Icono, string Titulo,  string Total)
            {
                this.Icono = Icono;
                this.Titulo = Titulo;
                this.Total = Total;
            }
            public string Icono { get; set; }

            public string Titulo { get; set; }

            public string Total { get; set; }

        }

        protected void CardViewControl_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            BinaryOperator boAprobado = new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Aprobado);
            BinaryOperator boRevision = new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Revision);

            GroupOperator GoRechazados = new GroupOperator(GroupOperatorType.Or);
            GoRechazados.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Rechazado));
            GoRechazados.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Cancelado));

            GroupOperator GoCreados = new GroupOperator(GroupOperatorType.Or);
            GoRechazados.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Creado));
            GoRechazados.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Enviado));


            XPView PedidosAprobados = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas), "Oid", boAprobado);
            XPView PedidosRevision = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas), "Oid", boRevision);
            XPView PedidosRechazados = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas), "Oid", GoRechazados);
            XPView PedidosCreados = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas), "Oid", GoCreados);

            List<PedidosEstado> Estados = new List<PedidosEstado>() {
                new PedidosEstado("fa fa-check-circle fa-4x","Pedidos aprobados",PedidosAprobados.Count.ToString()),
                new PedidosEstado("fa fa-times-circle fa-4x","Pedidos en revisión",PedidosRevision.Count.ToString()),
                new PedidosEstado("fa fa-eye fa-4x","Pedidos rechazados",PedidosRechazados.Count.ToString()),
                new PedidosEstado("fa fa-plus-circle fa-4x","Pedidos creados",PedidosCreados.Count.ToString())

                };
            CardViewControl.DataSource = Estados;
        }
    }
}