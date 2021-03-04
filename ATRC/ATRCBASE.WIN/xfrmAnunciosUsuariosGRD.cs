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
using System.Windows.Forms;
using static ATRCBASE.BL.Enums;

namespace ATRCBASE.WIN
{
    public partial class xfrmAnunciosUsuariosGRD : xfrmBase 
    {
        public xfrmAnunciosUsuariosGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmAnunciosUsuariosGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevoAnuncio");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarAnuncio");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarAnuncio");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Usuarios = new XPView(Unidad, typeof(AnuncioUsuario), "Oid;Nombre;TipoAnuncio;Publicar;LugarPublicar", new BinaryOperator("LugarPublicar", LugarPublicar.Rutas, BinaryOperatorType.NotEqual));
            //Usuarios.Sorting.Add(new SortingCollection(new SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            grdAnuncios.DataSource = Usuarios;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmAnunciosUsuario xfrm = new xfrmAnunciosUsuario())
            {
                UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                xfrm.Unidad = NuevaUnidad;
                xfrm.EsNuevo = true;
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdAnuncios.DataSource as XPView).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewExtintor = grvAnuncios.GetFocusedRow() as ViewRecord;
            if (ViewExtintor != null)
                using (xfrmAnunciosUsuario xfrm = new xfrmAnunciosUsuario())
                {
                    UnidadDeTrabajo NuevaUnidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

                    xfrm.Unidad = NuevaUnidad;
                    xfrm.Anuncio = NuevaUnidad.GetObjectByKey<AnuncioUsuario>(ViewExtintor["Oid"]);
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdAnuncios.DataSource as XPView).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewExtintor = grvAnuncios.GetFocusedRow() as ViewRecord;
            if (ViewExtintor != null)
            {
                AnuncioUsuario Anuncio = (AnuncioUsuario)ViewExtintor.GetObject();
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el anuncio '" + Anuncio.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Anuncio.Delete();
                    Unidad.CommitChanges();
                    (grdAnuncios.DataSource as XPView).Reload();
                }
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
