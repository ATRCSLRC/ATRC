using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using RUTAS.WIN.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmTurnosGRD : xfrmBase
    {
        public xfrmTurnosGRD()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        private void bbiEliminarTurno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewTurno = grvTurnos.GetFocusedRow() as ViewRecord;
            if (ViewTurno != null)
            {
                Turno Turno = (Turno)ViewTurno.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el turno " + Turno.Descripcion + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Turno.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdTurnos.DataSource).Reload();
                }
            }
        }

        private void xfrmTurnosGRD_Load(object sender, EventArgs e)
        {
            bbiNuevoTurno.Visibility = Utilerias.VisibilidadPermiso("NuevoTurno");
            bbiModificarTurno.Visibility = Utilerias.VisibilidadPermiso("ModificarTurno");
            bbiEliminarTurno.Visibility = Utilerias.VisibilidadPermiso("EliminarTurno");

            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Turnos = new XPView(Unidad, typeof(Turno), "Oid;Descripcion", null);
            grdTurnos.DataSource = Turnos;
        }

        private void bbiNuevoTurno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmTurno xfrm = new xfrmTurno())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                //xfrm.Turno = new Turno(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdTurnos.DataSource as XPView).Reload();
            }
        }

        private void bbiModificarTurno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewTurno = grvTurnos.GetFocusedRow() as ViewRecord;
            if (ViewTurno != null)
                using (xfrmTurno xfrm = new xfrmTurno())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Turno = (Turno)ViewTurno.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdTurnos.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
