using ATRCBASE.BL;
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

namespace ATRCBASE.WIN
{
    public partial class xfrmPuestoGRD : xfrmBase
    {
        public xfrmPuestoGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmPuestoGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Puesto> Puestos = new XPCollection<Puesto>(Unidad);
            grdPuestos.DataSource = Puestos;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmPuesto xfrm = new xfrmPuesto())
            {
                xfrm.Unidad = Unidad;
                xfrm.Puesto = new Puesto(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdPuestos.DataSource as XPCollection<Puesto>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Puesto puesto = grvPuestos.GetFocusedRow() as Puesto;
            if (puesto != null)
                using (xfrmPuesto xfrm = new xfrmPuesto())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Puesto = puesto;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdPuestos.DataSource as XPCollection<Puesto>).Reload();
                }   
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Puesto puesto = grvPuestos.GetFocusedRow() as Puesto;
            if(puesto != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el puesto '" + puesto.Descripcion + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    puesto.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Puesto>)grdPuestos.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
