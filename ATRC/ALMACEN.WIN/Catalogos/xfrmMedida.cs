
using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
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
    public partial class xfrmMedida : xfrmBase
    {
        public xfrmMedida()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Medidas Medida;

        #region Eventos
        private void xfrmPuesto_Load(object sender, EventArgs e)
        {
            memoDescripcion.DataBindings.Add("EditValue", Medida, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(memoDescripcion.Text))
            {
                Medida.Save();
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
