using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class xfrmMarcasGRD : xfrmBase
    {
        public xfrmMarcasGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmDepartamentoGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<BL.Marcas> Marcas = new XPCollection<BL.Marcas>(Unidad);
            grdMarcas.DataSource = Marcas;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmMarcas xfrm = new xfrmMarcas())
            {
                xfrm.Unidad = Unidad;
                xfrm.Marca = new BL.Marcas(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdMarcas.DataSource as XPCollection<BL.Marcas>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BL.Marcas Marca = grvMarcas.GetFocusedRow() as BL.Marcas;
            if (Marca != null)
                using (xfrmMarcas xfrm = new xfrmMarcas())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Marca = Marca;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdMarcas.DataSource as XPCollection<BL.Marcas>).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BL.Marcas Marca = grvMarcas.GetFocusedRow() as BL.Marcas;
            if (Marca != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la marca '" + Marca.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Marca.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<BL.Marcas>)grdMarcas.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
