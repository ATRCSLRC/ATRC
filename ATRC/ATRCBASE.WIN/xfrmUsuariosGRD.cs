using ATRCBASE.BL;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmUsuariosGRD : xfrmBase
    {
        public xfrmUsuariosGRD()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public int IDUsuario;

        private void xfrmUsuariosGRD_Load(object sender, EventArgs e)
        {

            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                bbiAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                bbiModificarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiEliminarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiNuevos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                bbiGafete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                rpgGafete.Visible = false;
            }
            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;NumEmpleado;Nombre", null);
            grdUsuarios.DataSource = Usuarios;
        }

        private void bbiNuevos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmUsuario xfrm = new xfrmUsuario())
            {
                xfrm.Unidad = Unidad;
                xfrm.EsNuevo = true;
                xfrm.Usuario = new Usuario(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdUsuarios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
                using (xfrmUsuario xfrm = new xfrmUsuario())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Usuario = (Usuario)ViewUsuario.GetObject();
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
        }

        private void bbiEliminarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el usuario '" + Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario.Delete();
                    Unidad.CommitChanges();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
            }
        }

        private void bbiSalirUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void bbiAsignar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                IDUsuario = Usuario.NumEmpleado;
                this.Close();
            }
        }

        private void bbiGafete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                ReportPrintTool repGafeteFrente = new ReportPrintTool(new ATRCBASE.WIN.Reportes.GafeteFrente(Usuario));
                repGafeteFrente.ShowPreviewDialog();
                ReportPrintTool repGafeteAtras = new ReportPrintTool(new ATRCBASE.WIN.Reportes.GafeteAtras(Usuario));
                repGafeteAtras.ShowPreviewDialog();
            }
        }
    }
}
