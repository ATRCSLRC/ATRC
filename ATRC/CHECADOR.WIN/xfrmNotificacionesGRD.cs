using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
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

namespace CHECADOR.WIN
{
    public partial class xfrmNotificacionesGRD : xfrmBase
    {
        public xfrmNotificacionesGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;

        private void xfrmNotificacionesGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Notificaciones> Usuarios = new XPCollection<Notificaciones>(Unidad);
            grdNotificaciones.DataSource = Usuarios;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmNotificaciones xfrm = new xfrmNotificaciones())
            {
                xfrm.Unidad = Unidad;
                xfrm.Notificacion = new Notificaciones(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdNotificaciones.DataSource as XPCollection<Notificaciones>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notificaciones Notificacion = grvNotificaciones.GetFocusedRow() as Notificaciones;
            if (Notificacion != null)
                using (xfrmNotificaciones xfrm = new xfrmNotificaciones())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Notificacion = Notificacion;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdNotificaciones.DataSource as XPCollection<Notificaciones>).Reload();
                }
        }

        private void bbiDesactivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notificaciones Notificacion = grvNotificaciones.GetFocusedRow() as Notificaciones;
            if (Notificacion != null)
                if (XtraMessageBox.Show("¿Está seguro de querer desactivar la notificación al usuario '" + Notificacion.Receptor.Usuario.NumEmpleado + " - " + Notificacion.Receptor.Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Notificacion.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Notificaciones>)grdNotificaciones.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }
    }
}
