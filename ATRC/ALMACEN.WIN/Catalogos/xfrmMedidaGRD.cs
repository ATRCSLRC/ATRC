using ALMACEN.BL;
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
    public partial class xfrmMedidaGRD : xfrmBase
    {
        public xfrmMedidaGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmPuestoGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Medidas> Medidas = new XPCollection<Medidas>(Unidad);
            grdMedidas.DataSource = Medidas;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmMedida xfrm = new xfrmMedida())
            {
                xfrm.Unidad = Unidad;
                xfrm.Medida = new Medidas(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdMedidas.DataSource as XPCollection<Medidas>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medidas Medidas = grvMedidas.GetFocusedRow() as Medidas;
            if (Medidas != null)
                using (xfrmMedida xfrm = new xfrmMedida())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Medida = Medidas;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdMedidas.DataSource as XPCollection<Medidas>).Reload();
                }   
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Medidas Medidas = grvMedidas.GetFocusedRow() as Medidas;
            if(Medidas != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la medida '" + Medidas.Descripcion + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Medidas.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Medidas>)grdMedidas.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
