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
    public partial class xfrmMarcas : xfrmBase
    {
        public xfrmMarcas()
        {
            InitializeComponent();
        }
        public UnidadDeTrabajo Unidad;
        public Marcas Marca;

        #region Eventos
        private void xfrmDepartamento_Load(object sender, EventArgs e)
        {
            memoNombre.DataBindings.Add("EditValue", Marca, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(memoNombre.Text))
            {
                if (!Existe())
                {
                    Marca.Save();
                    Unidad.CommitChanges();
                    this.Close();
                }else
                {
                    XtraMessageBox.Show("Esta marca se encuentra registrada.");
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            memoNombre.DataBindings.Clear();
            this.Close();
        }
        #endregion

        #region
        private bool Existe()
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Marcas = new XPView(UnidadConsulta, typeof(Marcas), "Oid;Nombre", new BinaryOperator("Nombre", memoNombre.Text));
            if (Marcas.Count > 0)
                return true;
            return false;
        }
        #endregion
    }
}
