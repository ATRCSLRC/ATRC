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
using UNIDADES.BL;

namespace UNIDADES.WIN.Baterias
{
    public partial class xfrmHistorialInventarioBaterias : xfrmBase
    {
        public xfrmHistorialInventarioBaterias()
        {
            InitializeComponent();
        }

        private void xfrmHistorialInventarioBaterias_Load(object sender, EventArgs e)
        {
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dteDe.DateTime.Date > dteAl.DateTime.Date)
            {
                XtraMessageBox.Show("La primera fecha no debe ser mayor a segunda.");
                return;
            }

            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView HistorialBaterias = new XPView(Unidad, typeof(HistorialBaterias));
            HistorialBaterias.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Unidad.Nombre", SortDirection.None, "[Unidad.Nombre]", false, true),
                  new ViewProperty("Baterias", SortDirection.None, "[Baterias]", false, true),
                  new ViewProperty("ComentarioBateria", SortDirection.None, "[Comentarios]", false, true),
                  new ViewProperty("FechaInventarioBaterias", SortDirection.None,  "GETDATE([FechaInventarioBaterias])", false, true)});
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("FechaInventarioBaterias", dteDe.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaInventarioBaterias", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
            HistorialBaterias.Criteria = go;
            grdBaterias.DataSource = HistorialBaterias;
            if (HistorialBaterias.Count > 0)
                rpDetalle.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
            grdBaterias.DataSource = null;
            rpDetalle.Visible = false;
        }

        private void bbiImprimirHistorial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdBaterias.ShowRibbonPrintPreview();
        }
    }
}
