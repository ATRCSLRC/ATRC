using ATRCBASE.BL;
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
    public partial class xfrmEmpresa : xfrmBase
    {
        public xfrmEmpresa()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Empresas Empresa;

        #region Eventos
        private void xfrmPuesto_Load(object sender, EventArgs e)
        {
            txtClave.DataBindings.Add("EditValue", Empresa, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("EditValue", Empresa, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNombreOficial.DataBindings.Add("EditValue", Empresa, "NombreOficial", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRFC.DataBindings.Add("EditValue", Empresa, "RFC", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDireccion.DataBindings.Add("EditValue", Empresa, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocacion.DataBindings.Add("EditValue", Empresa, "Locacion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTel.DataBindings.Add("EditValue", Empresa, "Tel", true, DataSourceUpdateMode.OnPropertyChanged);
            spnIva.DataBindings.Add("EditValue", Empresa, "IVA", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                Empresa.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            txtNombre.DataBindings.Clear();
            txtClave.DataBindings.Clear();
            txtRFC.DataBindings.Clear();
            txtDireccion.DataBindings.Clear();
            txtLocacion.DataBindings.Clear();
            txtTel.DataBindings.Clear();
            spnIva.DataBindings.Clear();
            this.Close();
        }
        #endregion
    }
}
