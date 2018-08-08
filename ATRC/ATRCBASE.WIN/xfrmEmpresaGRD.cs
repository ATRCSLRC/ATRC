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
    public partial class xfrmEmpresaGRD : xfrmBase
    {
        public xfrmEmpresaGRD()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmPuestoGRD_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPCollection<Empresas> Puestos = new XPCollection<Empresas>(Unidad);
            grdEmpresa.DataSource = Puestos;
        }

        private void bbiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (xfrmEmpresa xfrm = new xfrmEmpresa())
            {
                xfrm.Unidad = Unidad;
                xfrm.Empresa = new Empresas(Unidad);
                xfrm.ShowDialog();
                xfrm.Dispose();
                (grdEmpresa.DataSource as XPCollection<Empresas>).Reload();
            }
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empresas Empresa = grvEmpresa.GetFocusedRow() as Empresas;
            if (Empresa != null)
                using (xfrmEmpresa xfrm = new xfrmEmpresa())
                {
                    xfrm.Unidad = Unidad;
                    xfrm.Empresa = Empresa;
                    xfrm.ShowInTaskbar = false;
                    xfrm.ShowDialog();
                    xfrm.Dispose();
                    (grdEmpresa.DataSource as XPCollection<Empresas>).Reload();
                }   
        }

        private void bbiEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Empresas Empresa = grvEmpresa.GetFocusedRow() as Empresas;
            if(Empresa != null)
                if (XtraMessageBox.Show("¿Está seguro de querer eliminar la empresa '" + Empresa.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Empresa.Delete();
                    Unidad.CommitChanges();
                    ((XPCollection<Empresas>)grdEmpresa.DataSource).Reload();
                }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
