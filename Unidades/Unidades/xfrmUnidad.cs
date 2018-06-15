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

        #region Eventos

        private void xfrmUnidad_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                UnidadCamion = new Unidad.BL.Unidad(Unidad);
                Gasto = new GastosUnidad(Unidad);
                
            }
            else
            {
                Gasto = UnidadCamion.Gastos[0];
            }
            cboTipoMoneda.Properties.Items.AddRange(typeof(Enums.TipoMoneda).GetEnumValues());
            cboFormaPago.Properties.Items.AddRange(typeof(Enums.FormaPago).GetEnumValues());
            rgTipoUnidad.Properties.Items.AddEnum(typeof(Enums.TipoUnidad));
            rgTransmision.Properties.Items.AddEnum(typeof(Enums.Transmision));
            rgFrenos.Properties.Items.AddEnum(typeof(Enums.Frenos));
            LigarControles();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ValidarCampos())
            {
                Guardar();
               
                if (esModificacion)
                {
                    XtraMessageBox.Show("Se ha realizado la modificación correctamente.");
                }
                else
                {
                    XtraMessageBox.Show("Se ha guardado la unidad correctamente.");
                    UnidadCamion.Estado = Enums.Estado.Translado;
                }

                UnidadCamion.Save();
                Unidad.CommitChanges();

                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void rgTipoUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            if (rg != null)
            {
                txtNombre.Text = Utilerias.NombreUnidad(Unidad, (Enums.TipoUnidad)rg.EditValue);
            }
        }

        #endregion

        #region Metodos
        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe de agregar el nombre de la unidad.");
                txtNombre.Focus();
                return false;
            }

            if (spnPrecio.Value <= 0)
            {
                XtraMessageBox.Show("Debe de agregar el costo de la unidad.");
                tabbedControlGroup1.SelectedTabPage = TabCosto;
                spnPrecio.Focus();
                return false;
            }

            return true;
        }

        private void LigarControles()
        {
            #region General
            txtMarca.Text = UnidadCamion.Marca;
            txtModelo.Text = UnidadCamion.Modelo;
            txtVIN.Text = UnidadCamion.VIN;
            txtMotor.Text = UnidadCamion.Motor;
            spnCilindros.EditValue = UnidadCamion.Cilindros;
            rgTransmision.EditValue = UnidadCamion.Transmision;
            rgFrenos.EditValue = UnidadCamion.Frenos;
            rgAireAcondicionado.EditValue = UnidadCamion.AireAcondicionado;

            if (esModificacion)
            {
                rgTipoUnidad.EditValue = UnidadCamion.TipoUnidad;
                txtNombre.Text = UnidadCamion.Nombre;
            }
            else
                rgTipoUnidad.EditValue = UnidadCamion.TipoUnidad;

            #endregion

            #region Costo

            spnTipoCambio.Value = Gasto.TipoCambio;
            dteFecha.DateTime = Gasto.Fecha == DateTime.MinValue ? DateTime.Now : Gasto.Fecha;
            spnPrecio.EditValue = Gasto.Cantidad;
            cboTipoMoneda.EditValue = Gasto.TipoMoneda;
            cboFormaPago.EditValue = Gasto.FormaDePago;
            txtLugar.Text = Gasto.LugarCompra;

            #endregion
        }

        private void Guardar()
        {
            #region General
            UnidadCamion.Nombre = txtNombre.Text;
            UnidadCamion.TipoUnidad = (Enums.TipoUnidad)rgTipoUnidad.EditValue;
            UnidadCamion.Marca = txtMarca.Text;
            UnidadCamion.Modelo = txtModelo.Text;
            UnidadCamion.VIN = txtVIN.Text;
            UnidadCamion.Motor = txtMotor.Text;
            UnidadCamion.Cilindros = Convert.ToInt32(spnCilindros.Value);
            UnidadCamion.Transmision = (Enums.Transmision)rgTransmision.EditValue;
            UnidadCamion.Frenos = (Enums.Frenos)rgFrenos.EditValue;
            UnidadCamion.AireAcondicionado = Convert.ToBoolean(rgAireAcondicionado.EditValue);
            #endregion

            #region Costo
            Gasto.TipoCambio = spnTipoCambio.Value;
            Gasto.Fecha = dteFecha.DateTime;
            Gasto.Cantidad = spnPrecio.Value;
            Gasto.TipoMoneda = (Enums.TipoMoneda)cboTipoMoneda.EditValue;
            Gasto.FormaDePago = (Enums.FormaPago)cboFormaPago.EditValue;
            Gasto.LugarCompra = txtLugar.Text;
            Gasto.TipoTransaccion = Enums.TipoTransaccion.Gasto;
            #endregion

            Gasto.ConceptoDeGasto = Enums.ConceptoGasto.CompraUnidad;
            UnidadCamion.Gastos.Add(Gasto);
        }

        #endregion
        
    }
}
