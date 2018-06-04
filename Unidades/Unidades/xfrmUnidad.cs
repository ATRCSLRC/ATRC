using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unidad.BL;

namespace Unidades
{
    public partial class xfrmUnidad : RibbonForm
    {
        public xfrmUnidad()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Unidad.BL.Unidad UnidadCamion;
        public bool esModificacion = false;

        private void xfrmUnidad_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UnidadCamion = new Unidad.BL.Unidad(Unidad);
            }
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text))
            {
                UnidadCamion.Save();
                Unidad.CommitChanges();
                if (esModificacion)
                    XtraMessageBox.Show("Se ha realizado la modificación correctamente.");
                else
                    XtraMessageBox.Show("Se ha guardado la unidad correctamente.");
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unidad.RollbackTransaction();
            this.Close();
        }

        private void LigarControles()
        {
            txtNombre.DataBindings.Add("EditValue", UnidadCamion, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMarca.DataBindings.Add("EditValue", UnidadCamion, "Marca", true, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("EditValue", UnidadCamion, "Modelo", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVIN.DataBindings.Add("EditValue", UnidadCamion, "VIN", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
