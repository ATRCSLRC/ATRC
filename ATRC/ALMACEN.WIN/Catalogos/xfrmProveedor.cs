
using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
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

namespace ALMACEN.WIN
{
    public partial class xfrmProveedor : xfrmBase
    {
        public xfrmProveedor()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Proveedor Proveedor;

        #region Eventos
        private void xfrmPuesto_Load(object sender, EventArgs e)
        {
            txtNombre.DataBindings.Add("EditValue", Proveedor, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombreFiscal.DataBindings.Add("EditValue", Proveedor, "NombreFiscal", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!Existe())
                {
                    Proveedor.Save();
                    Unidad.CommitChanges();
                    this.Close();
                } else
                {
                    XtraMessageBox.Show("Este proveedor se encuentra registrado.");
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            txtNombre.DataBindings.Clear();
            txtNombreFiscal.DataBindings.Clear();
            this.Close();
        }
        #endregion

        #region
        private bool Existe()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Proveedores = new XPView(UnidadConsulta, typeof(Proveedor), "Oid;Nombre", new BinaryOperator("Nombre", txtNombre.Text));
            if (Proveedores.Count > 0)
                return true;
            return false;
        }
        #endregion
    }
}
