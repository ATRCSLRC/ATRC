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
    public partial class xfrmDepartamento : xfrmBase
    {
        public xfrmDepartamento()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Departamento Departamento;

        #region Eventos
        private void xfrmDepartamento_Load(object sender, EventArgs e)
        {
            memoDescripcion.DataBindings.Add("EditValue", Departamento, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(memoDescripcion.Text))
            {
                Departamento.Save();
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            memoDescripcion.DataBindings.Clear();
            this.Close();
        }
        #endregion
    }
}
