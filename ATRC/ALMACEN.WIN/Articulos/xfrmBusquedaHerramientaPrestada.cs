using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMACEN.WIN
{
    public partial class xfrmBusquedaHerramientaPrestada : xfrmBase
    {
        public xfrmBusquedaHerramientaPrestada()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmBusquedaHerramientaPrestada_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Fecha", dteDe.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("Fecha", dteAl.DateTime.Date.AddDays(1), BinaryOperatorType.LessOrEqual));

            switch (rgHerramienta.SelectedIndex)
            {
                case 1:
                    go.Operands.Add(new BinaryOperator("Articulo.Codigo", btnCodigoHerramienta.Text));
                    break;
            }
            switch (rgTipo.SelectedIndex)
            {
                case 1:
                    go.Operands.Add(new BinaryOperator("Entregado", true));
                    break;
                case 2:
                    go.Operands.Add(new BinaryOperator("Entregado", false));
                    break;
            }
            

            XPView Herramientas = new XPView(Unidad, typeof(DetallePrestamo));
            Herramientas.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Articulo.Nombre", SortDirection.None, "[Articulo.Nombre]", false, true),
                  new ViewProperty("Usuario.Nombre", SortDirection.None, "[Prestamo.Usuario.Nombre]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[Fecha]", false, true),
                  new ViewProperty("FechaEntrega", SortDirection.None, "[FechaEntrega]", false, true)
                 });
            Herramientas.Criteria = go;
            Herramientas.Sorting.Add(new SortProperty("Fecha",DevExpress.Xpo.DB.SortingDirection.Ascending));

            grdHerramienta.DataSource = Herramientas;
            if (Herramientas.Count > 0)
                rpReporte.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
            grdHerramienta.DataSource = null;
            rgHerramienta.SelectedIndex = rgTipo.SelectedIndex = 0;
            btnCodigoHerramienta.Text = string.Empty;
            lciHerramienta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            dteDe.Focus();
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xfrmBusquedaArticulos xfrm = new xfrmBusquedaArticulos();
            xfrm.Asignar = true;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (!string.IsNullOrEmpty(xfrm.Codigo))
            {
                btnCodigoHerramienta.Text = xfrm.Codigo;
            }
        }

        private void rgHerramienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgHerramienta.SelectedIndex == 1)
                lciHerramienta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
            {
                lciHerramienta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnCodigoHerramienta.Text = string.Empty;
            }

            
        }

        private void bbiReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPrintTool repHerramientaPrestada = new ReportPrintTool(new REPORTES.Almacen.HerramientaPrestada(dteDe.DateTime.Date, dteAl.DateTime.Date, (XPView)grdHerramienta.DataSource));
            repHerramientaPrestada.ShowPreview();
        }
    }
}
