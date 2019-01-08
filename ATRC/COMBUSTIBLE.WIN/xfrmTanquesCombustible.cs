using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
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

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmTanquesCombustible : xfrmBase
    {
        public xfrmTanquesCombustible()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public DieselActual Tanque;

        #region Eventos
        private void xfrmDepartamento_Load(object sender, EventArgs e)
        {
            rgTipoCombustible.Properties.Items.AddEnum(typeof(Enums.Combustible));
            txtNombre.DataBindings.Add("EditValue", Tanque, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            spnCapacidad.DataBindings.Add("EditValue", Tanque, "Capacidad", true, DataSourceUpdateMode.OnPropertyChanged);
            rgTipoCombustible.DataBindings.Add("EditValue", Tanque, "TipoCombustible", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Tanque.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            txtNombre.DataBindings.Clear();
            spnCapacidad.DataBindings.Clear();
            this.Close();
        }
        #endregion

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe de agregar un nombre.");
                txtNombre.Focus();
                return false;
            }

            if (spnCapacidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe de agregar la capacidad del tanque.");
                spnCapacidad.Focus();
                return false;
            }

            return true;
        }

        private void xfrmTanquesCombustible_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
