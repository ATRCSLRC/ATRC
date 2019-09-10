using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL.Clases;

namespace UNIDADES.WIN
{
    public partial class xfrmHistorialExtintores : xfrmBase
    {
        public xfrmHistorialExtintores()
        {
            InitializeComponent();
        }

        private void xfrmHistorialExtintores_Load(object sender, EventArgs e)
        {
            dteDe.DateTime = dteA.DateTime = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dteDe.DateTime.Date > dteA.DateTime.Date)
            {
                XtraMessageBox.Show("La primera fecha no debe ser mayor a segunda.");
                return;
            }

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView HistorialExtintor = new XPView(Unidad, typeof(HistorialExtintores));
            HistorialExtintor.Properties.AddRange(new 
                [] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumExtintor", SortDirection.None, "[NumExtintor]", false, true),
                  new ViewProperty("FechaRecarga", SortDirection.None, "[FechaRecarga]", false, true),
                  new ViewProperty("FechaVencimiento", SortDirection.None, "[FechaVencimiento]", false, true),
                  new ViewProperty("UbicacionExtintor", SortDirection.None,  "iif([UbicacionExtintor] == 0,[Unidad.Nombre],iif([UbicacionExtintor] == 1, [Oficina], 'Almacen'))", false, true),
                  new ViewProperty("Peso", SortDirection.None,  "ToStr([Peso]) + ' kg'", false, true),
                  new ViewProperty("Tipo", SortDirection.None,  "[Tipo]", false, true),
                  new ViewProperty("EstadoExtintor", SortDirection.None,  "[EstadoExtintor]", false, true),
                  new ViewProperty("FechaInventario", SortDirection.None,  "GETDATE([FechaInventario])", false, true),
                  new ViewProperty("UltimoComentario", SortDirection.None,  "[UltimoComentario]", false, true)});
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaInventario", dteDe.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaInventario", dteA.DateTime.Date, BinaryOperatorType.LessOrEqual));
            HistorialExtintor.Criteria = go;
            grdHistorial.DataSource = HistorialExtintor;
            if(HistorialExtintor.Count > 0)
                rpDetalle.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dteDe.DateTime = dteA.DateTime = DateTime.Now;
            grdHistorial.DataSource = null;
            rpDetalle.Visible = false;
        }

        private void bbiImprimirHistorial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdHistorial.ShowRibbonPrintPreview();
        }
    }
}
