using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace REPORTES.Rutas
{
    public partial class AclaracionesPedido : DevExpress.XtraReports.UI.XtraReport
    {
        public AclaracionesPedido(int ID,int  IDAclaracion)
        {
            InitializeComponent();
            this.IDAclaracionReporte = IDAclaracion;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            XPCollection Aclaraciones = new XPCollection(Unidad, typeof(RUTAS.BL.RutasDePedido), new BinaryOperator("PedidoRutas", ID));

           

            //UnidadReporte = Unidad;
            //XPView Aclaraciones = new XPView(Unidad, typeof(RUTAS.BL.RutasDePedido),"Oid;Ruta;Servicio.Descripcion;TipoRuta;Turno.Descripcion;" +
            //    "HoraEntrada;HoraSalida;EsRutaExtra",new BinaryOperator("PedidoRutas", ID));
            this.DataSource = Aclaraciones;
        }
        int IDAclaracionReporte;
        UnidadDeTrabajo UnidadReporte;
        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DetailReport.RowCount <= 0)
            {
                // ReportHeader1.Visible = false;
                e.Cancel = true;
            }
            //else
            //{
            //    ReportHeader1.Visible = true;
            //}
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            RUTAS.BL.RutasDePedido viewRuta = (RUTAS.BL.RutasDePedido)GetCurrentRow();
            //GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("RutasDePedido", Convert.ToInt32(viewRuta["Oid"])));
            //go.Operands.Add(new BinaryOperator("EstadoPedido", Enums.EstadoPedidoRutas.Aprobado));
            //XPView Aclaraciones = new XPView(UnidadReporte, typeof(RUTAS.BL.HistorialRutasDePedido), "Oid;Ruta;Servicio.Descripcion;TipoRuta;Turno.Descripcion;" +
            //    "HoraEntrada;HoraSalida;EsRutaExtra;EstadoPedido", go);
            //Aclaraciones.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            viewRuta.Historial.Criteria = new NullOperator("Aclaracion");
            viewRuta.Historial.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            viewRuta.Historial.TopReturnedObjects = 2;

            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("RutasDePedido", viewRuta.Oid));
            go.Operands.Add(new BinaryOperator("Aclaracion", IDAclaracionReporte));
            XPCollection<RUTAS.BL.HistorialRutasDePedido> RutasAclaracion = new XPCollection<RUTAS.BL.HistorialRutasDePedido>(viewRuta.Session, go);
            RutasAclaracion.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            //RutasAclaracion.TopReturnedObjects = 2;

            XPCollection<RUTAS.BL.HistorialRutasDePedido> UltimoCambio = new XPCollection<RUTAS.BL.HistorialRutasDePedido>(viewRuta.Session, 0);
            if (RutasAclaracion.Count > 1)
            {
                UltimoCambio.Add(RutasAclaracion[1]);
            }else if (viewRuta.Historial.Count > 1)
            {
                UltimoCambio.Add(viewRuta.Historial[1]);
            }

            if(viewRuta.Historial.Count == 1 & RutasAclaracion.Count == 1)
                UltimoCambio.Add(viewRuta.Historial[0]);


            DetailReport.DataSource = UltimoCambio;

        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            //ViewRecord viewRuta = (ViewRecord)GetCurrentRow();
            //GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("RutasDePedido", Convert.ToInt32(viewRuta["Oid"])));
            //go.Operands.Add(new BinaryOperator("EstadoPedido", Enums.EstadoPedidoRutas.Aprobado));
            //XPView Aclaraciones = new XPView(UnidadReporte, typeof(RUTAS.BL.HistorialRutasDePedido), "Oid;Ruta;Servicio.Descripcion;TipoRuta;Turno.Descripcion;" +
            //    "HoraEntrada;HoraSalida;EsRutaExtra;EstadoPedido", go);
            //Aclaraciones.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            //if (Aclaraciones.Count > 0)
            //{
            //    lblRuta.Text = Aclaraciones[0]["Ruta"].ToString();
            //    lblServicio.Text = Aclaraciones[0]["Servicio.Descripcion"].ToString();
            //    lblTipoRuta.Text = Aclaraciones[0]["TipoRuta"].ToString();
            //    lblTurno.Text = Aclaraciones[0]["Turno.Descripcion"] != null ? Aclaraciones[0]["Turno.Descripcion"].ToString() : "";
            //}
        }

        private void AclaracionesPedido_DataSourceRowChanged(object sender, DataSourceRowEventArgs e)
        {

        }

        private void DetailReport_AfterPrint(object sender, EventArgs e)
        {

        }

        private void Detail1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DetailReport.RowCount <= 0)
            {
                //ReportHeader1.Visible = false;
                e.Cancel = true;
                //}else
                //{
                //    ReportHeader1.Visible = true;

            }
        }

        private void ReportHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DetailReport.RowCount <= 0)
            {
                //ReportHeader1.Visible = false;
                e.Cancel = true;
                //}else
                //{
                //    ReportHeader1.Visible = true;
            }
        }
    }
}
    
