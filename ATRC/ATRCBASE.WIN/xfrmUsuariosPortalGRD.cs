using ATRCBASE.BL;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRCBASE.WIN
{
    public partial class xfrmUsuariosPortalGRD : xfrmBase
    {
        public xfrmUsuariosPortalGRD()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public int IDUsuario;

        private void xfrmUsuariosPortalGRD_Load(object sender, EventArgs e)
        {
            if (Unidad == null)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            }
            else
            {
                //bbiModificarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //bbiEliminarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //bbiNuevos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //bbiGafete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //rpgGafete.Visible = false;
            }
            XPView Usuarios = new XPView(Unidad, typeof(Usuario), "Oid;Nombre;Activo;Empresa.Nombre;Correo", null);
            //Usuarios.Sorting.Add(new SortingCollection(new SortProperty("FechaAlta", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            Usuarios.Criteria = new BinaryOperator("EsExterno", true);
            grdUsuarios.DataSource = Usuarios;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmUsuarioPortal xfrm = new xfrmUsuarioPortal())
            {
                UnidadDeTrabajo UnidadNuevo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = UnidadNuevo;
                xfrm.EsNuevo = true;
                xfrm.Usuario = new Usuario(UnidadNuevo);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdUsuarios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
                using (xfrmUsuarioPortal xfrm = new xfrmUsuarioPortal())
                {
                    UnidadDeTrabajo UnidadModificar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    xfrm.Unidad = UnidadModificar;
                    xfrm.Usuario = UnidadModificar.GetObjectByKey<Usuario>(ViewUsuario["Oid"]);
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    ((XPView)grdUsuarios.DataSource).Reload();
                }
        }

        private void bbiDesactivarActivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewUsuario = grvUsuarios.GetFocusedRow() as ViewRecord;
            if (ViewUsuario != null)
            {
                Usuario Usuario = (Usuario)ViewUsuario.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer " + (!Usuario.Activo ? "activar" : "desactivar") + " el usuario '" + Usuario.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Usuario.Activo = !Usuario.Activo;
                    Unidad.CommitChanges();
                    ((XPView)grdUsuarios.DataSource).Reload();
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
