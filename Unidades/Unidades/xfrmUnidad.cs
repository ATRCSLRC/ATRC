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
        GastosUnidad Gasto;
        public bool esModificacion = false;

        private void xfrmUnidad_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UnidadCamion = new Unidad.BL.Unidad(Unidad);
                Gasto = new GastosUnidad(Unidad);
            }else
            {
                Gasto = UnidadCamion.Gastos[0];
            }
            cboTipoMoneda.Properties.Items.AddRange(typeof(Enums.TipoMoneda).GetEnumValues());
            cboFormaPago.Properties.Items.AddRange(typeof(Enums.FormaPago).GetEnumValues());
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text))
            {
                
                Gasto.ConceptoDeGasto = Enums.ConceptoGasto.CompraUnidad;
                UnidadCamion.Gastos.Add(Gasto);
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

            dteFecha.DataBindings.Add("EditValue", Gasto, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            spnPrecio.DataBindings.Add("EditValue", Gasto, "Cantidad", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTipoMoneda.DataBindings.Add("EditValue", Gasto, "TipoMoneda", true, DataSourceUpdateMode.OnPropertyChanged);
            cboFormaPago.DataBindings.Add("EditValue", Gasto, "FormaDePago", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLugar.DataBindings.Add("EditValue", Gasto, "LugarCompra", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
