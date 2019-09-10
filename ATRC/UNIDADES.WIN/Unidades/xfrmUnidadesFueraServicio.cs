using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN.Unidades
{
    public partial class xfrmUnidadesFueraServicio : xfrmBase
    {
        public xfrmUnidadesFueraServicio()
        {
            InitializeComponent();
        }

        private void xfrmUnidadesFueraServicio_Load(object sender, EventArgs e)
        {
            bbiActivar.Visibility = Utilerias.VisibilidadPermiso("EstadoUnidadFueraServicio");
            bbiDetalleUnidad.Visibility = Utilerias.VisibilidadPermiso("DetallesUnidadFueraServicio");
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.FueraServicio));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Vendido));
            XPView Unidades = new XPView(Unidad, typeof(Unidad), "Oid;Nombre;EstadoUnidad;UltimoEstado", go);
            grdUnidades.DataSource = Unidades;
        }

        private void bbiActivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (viewUnidad != null)
            {
                if (XtraMessageBox.Show("¿Está seguro de querer activar la unidad '" + viewUnidad["Nombre"] + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Unidad UnidadCamion = (Unidad)viewUnidad.GetObject();
                    UnidadCamion.EstadoUnidad = Enums.EstadoUnidad.BuenEstado;
                    UnidadCamion.UltimoEstado = DateTime.Now;
                    UnidadCamion.Save();
                    UnidadCamion.Session.CommitTransaction();
                    (grdUnidades.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiDetalleUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewUnidad = grvUnidades.GetFocusedRow() as ViewRecord;
            if (viewUnidad != null)
            {
                ReportPrintTool repDetalleUnidad = new ReportPrintTool(new REPORTES.Unidades.DetalleDeUnidad(Convert.ToInt32(viewUnidad["Oid"])));
                repDetalleUnidad.ShowPreview();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
