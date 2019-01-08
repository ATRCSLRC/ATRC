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
            XPView Notificaciones = new XPView(Unidad,typeof(Notificaciones));

            Notificaciones.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Receptor.Usuario.Nombre", SortDirection.None, "Concat(ToStr([Receptor.Usuario.NumEmpleado]), ' - ', [Receptor.Usuario.Nombre])", false, true),
                  new ViewProperty("Responsable.Usuario.Nombre", SortDirection.None, "[Responsable.Usuario.Nombre]", false, true),
                  new ViewProperty("Motivo", SortDirection.None, "Motivo", false, true)
                 });
            grdNotificaciones.DataSource = Notificaciones;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmNotificaciones xfrm = new xfrmNotificaciones())
            {
                UnidadDeTrabajo UnidadNuevo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = UnidadNuevo;
                xfrm.Notificacion = new Notificaciones(UnidadNuevo);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdNotificaciones.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void bbiDesactivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewRecord = grvNotificaciones.GetFocusedRow() as ViewRecord;
            if (ViewRecord != null)
            {
                Notificaciones Notificacion = (Notificaciones)ViewRecord.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer desactivar la notificación al usuario '" + Notificacion.Receptor.Usuario.NumEmpleado + " - " + Notificacion.Receptor.Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Notificacion.Receptor.Notificaciones.Remove(Notificacion);
                    Notificacion.Delete();
                    Unidad.CommitChanges();
                    XtraMessageBox.Show("La notificación se ha desactivado correctamente. ");
                    ((XPView)grdNotificaciones.DataSource).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }
    }
}
