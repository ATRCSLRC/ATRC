using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
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
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmUsuariosGRD : RibbonForm
    {
        public xfrmUsuariosGRD()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        private void xfrmUnidadGRD_Load(object sender, EventArgs e)
        {
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            }
            XPView Unidades = new XPView(Unidad, typeof(Unidad.BL.Usuario), "Oid;Nombre", null);
            grdUsuarios.DataSource = Unidades;
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsusario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsusario != null)
                using (xfrmUsuario xfrm = new xfrmUsuario())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Usuario = (Unidad.BL.Usuario)ViewUsusario.GetObject();
                    xfrm.esModificacion = true;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmUsuario xfrm = new xfrmUsuario())
            {
                xfrm.esModificacion = false;
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdUsuarios.DataSource as XPView).Reload();
            }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsusario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsusario != null)
            {
                Unidad.BL.Usuario Usuario = (Unidad.BL.Usuario)ViewUsusario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el usuario '" + Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.ReloadChangedObjects();
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void xfrmUnidadGRD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unidad.ReloadChangedObjects();
            Unidad.RollbackTransaction();
        }

        private void bbiDetalleUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsusario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsusario != null)
            {
               
            }
        }
    }
}
