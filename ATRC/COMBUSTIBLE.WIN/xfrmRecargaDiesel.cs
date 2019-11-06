using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmRecargaDiesel : xfrmBase
    {
        public xfrmRecargaDiesel()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        decimal Cantidad = 0;

        private void xfrmRecargaDiesel_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion", null);

            foreach (ViewRecord vr in Tanques)
                rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Oid"], vr["Descripcion"].ToString()));

            rgTanques.SelectedIndex = 0;
        }

        private void rgTanques_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            if (rg != null)
            {
                DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(rg.EditValue);
                if (Tanque != null)
                {
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Final", 0));
                    go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
                    arcScaleComponent1.Ranges.Clear();
                    arcScaleComponent1.MaxValue = Tanque.Capacidad;
                    int div = Tanque.Capacidad / 3;
                    arcScaleComponent1.Ranges.Add(CreateNewRange(0, div, Color.Red));
                    arcScaleComponent1.Ranges.Add(CreateNewRange(div + 1, (div * 2), Color.Yellow));
                    arcScaleComponent1.Ranges.Add(CreateNewRange((div * 2) + 1, Tanque.Capacidad, Color.Green));
                    Cantidad = Tanque.Cantidad;
                    arcScaleComponent1.Value = (float)Cantidad;
                    spnCantidad.EditValue = spnPrecio.EditValue = 0;
                    txtFactura.Text = txtProveedor.Text = string.Empty;
                    labelComponent1.Text = Cantidad.ToString("N2") + " lts";
                }
            }
        }

        private static IRange CreateNewRange(int startValue, int endValue, Color color)
        {
            IRange result = new ArcScaleRange();
            result.AppearanceRange.ContentBrush = new SolidBrushObject(color);
            result.StartValue = startValue;
            result.EndValue = endValue;
            result.ShapeOffset = 0;
            result.StartThickness = 10f;
            result.EndThickness = 10f;
            return result;
        }

        private void spnCantidad_EditValueChanged(object sender, EventArgs e)
        {
            arcScaleComponent1.Value = (float)Cantidad + (float)spnCantidad.EditValue;
            labelComponent1.Text = (float)Cantidad + (float)spnCantidad.EditValue + " lts";
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ValidarCampos())
            {
                UnidadDeTrabajo UnidadNueva = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                DieselActual Tanque = UnidadNueva.GetObjectByKey<DieselActual>(rgTanques.EditValue);
                Tanque.Cantidad += Convert.ToInt64(spnCantidad.EditValue);
                RecargaDiesel Recarga = new RecargaDiesel(UnidadNueva);
                Recarga.Cantidad = Convert.ToInt64(spnCantidad.EditValue);
                Recarga.PrecioLitro = Convert.ToDouble(spnPrecio.EditValue);
                Recarga.Factura = txtFactura.Text;
                Recarga.Proveedor = txtProveedor.Text;
                Recarga.Tanque = Tanque;
                Recarga.Lectura = txtLecturaInicial.Text;
                Recarga.Save();
                Tanque.Save();
                UnidadNueva.CommitChanges();
                XtraMessageBox.Show("Se ha realizadó la recarga correctamente.");
                this.Close();
            }
        }

        private void xfrmRecargaDiesel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private bool ValidarCampos()
        {
            if(Convert.ToInt32(spnPrecio.EditValue) <= 0)
            {
                XtraMessageBox.Show("Debe agregar el precio.");
                spnPrecio.Focus();
                return false;
            }

            if (Convert.ToInt32(spnCantidad.EditValue) <= 0)
            {
                XtraMessageBox.Show("Debe agregar la cantidad.");
                spnCantidad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFactura.Text))
            {
                XtraMessageBox.Show("Debe agregar la factura.");
                txtFactura.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtProveedor.Text))
            {
                XtraMessageBox.Show("Debe agregar el proveedor.");
                txtProveedor.Focus();
                return false;
            }
            return true;
        }
    }
}
