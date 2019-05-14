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
    public partial class xfrmDepartamentoGRD : xfrmBase
    {
        public xfrmDepartamentoGRD()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmDepartamentoGRD_Load(object sender, EventArgs e)
        {
            bbiNuevo.Visibility = Utilerias.VisibilidadPermiso("NuevoDepartamento");
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarDepartamento");
            bbiEliminar.Visibility = Utilerias.VisibilidadPermiso("EliminarDepartamento");
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Departamento> Puestos = new XPCollection<Departamento>(Unidad);
            grdDepartamentos.DataSource = Puestos;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmDepartamento xfrm = new xfrmDepartamento())
            {
                xfrm.Unidad = Unidad;
                xfrm.Departamento = new Departamento(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdDepartamentos.DataSource as XPCollection<Departamento>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Departamento departamento = grvDepartamento.GetFocusedRow() as Departamento;
            if (departamento != null)
                using (xfrmDepartamento xfrm = new xfrmDepartamento())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Departamento = departamento;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdDepartamentos.DataSource as XPCollection<Departamento>).Reload();
                }
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Departamento departamento = grvDepartamento.GetFocusedRow() as Departamento;
            if (departamento != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar el departamento '" + departamento.Descripcion + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    departamento.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Departamento>)grdDepartamentos.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
