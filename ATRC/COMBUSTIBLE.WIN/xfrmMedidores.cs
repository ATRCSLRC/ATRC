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
using static ATRCBASE.BL.Enums;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmMedidores : xfrmBase
    {
        public xfrmMedidores()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        public Combustible TipoCombustible = Combustible.Ninguno;
        private void xfrmMedidores_Load(object sender, EventArgs e)
        {
            
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Tanques;
            if (TipoCombustible == Combustible.Ninguno)
                Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion", null);
            else
                Tanques = new XPView(Unidad, typeof(DieselActual), "Oid;Descripcion;TipoCombustible", new BinaryOperator("TipoCombustible", TipoCombustible));

            foreach (ViewRecord vr in Tanques)
                rgTanques.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(vr["Oid"], vr["Descripcion"].ToString()));

            rgTanques.SelectedIndex = 0;
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
                    XPCollection<MedidorDiesel> Medidor = new XPCollection<MedidorDiesel>(Unidad, go);
                    if(Medidor.Count > 0)
                    {
                        txtIniciales.Text = Medidor[0].Inicial.ToString();
                        txtIniciales.ReadOnly = true;
                    }
                    else
                    {
                        txtIniciales.Text = string.Empty;
                        txtIniciales.ReadOnly = false;
                    }
                    arcScaleComponent1.Ranges.Clear();
                    arcScaleComponent1.MaxValue = Tanque.Capacidad;
                    int div = Tanque.Capacidad / 3;
                    arcScaleComponent1.Ranges.Add(CreateNewRange(0, div, Color.Red));
                    arcScaleComponent1.Ranges.Add(CreateNewRange(div + 1, (div * 2), Color.Yellow));
                    arcScaleComponent1.Ranges.Add(CreateNewRange((div * 2) + 1, Tanque.Capacidad, Color.Green));
                    arcScaleComponent1.Value = (float)Tanque.Cantidad;
                    labelComponent1.Text = Tanque.Cantidad.ToString("N2") + " lts";
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de cancelar? Podría perder sus cambios.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                UnidadDeTrabajo UnidadNueva = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                DieselActual Tanque = UnidadNueva.GetObjectByKey<DieselActual>(rgTanques.EditValue);
                if (Tanque != null)
                {
                    GroupOperator go = new GroupOperator();
                    go.Operands.Add(new BinaryOperator("Final", 0));
                    go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
                    XPCollection<MedidorDiesel> Medidor = new XPCollection<MedidorDiesel>(UnidadNueva, go);
                    if (Medidor.Count > 0)
                    {
                        Medidor[0].Final = Convert.ToInt64(txtFinales.Text);
                        Medidor[0].Save();
                    }
                    else
                    {
                        MedidorDiesel MedidorDiesel = new MedidorDiesel(UnidadNueva);
                        MedidorDiesel.Inicial = Convert.ToInt64(txtIniciales.Text);
                        if(!string.IsNullOrEmpty(txtFinales.Text))
                            MedidorDiesel.Final = Convert.ToInt64(txtFinales.Text);
                        MedidorDiesel.Tanque = Tanque;
                        MedidorDiesel.Save();
                    }

                    UnidadNueva.CommitChanges();
                    XtraMessageBox.Show("Los datos se han guardado correctamente.");
                    this.Close();
                }

            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtIniciales.Text))
            {
                XtraMessageBox.Show("Debe de agregar los números iniciales del medidor.");
                txtIniciales.Focus();
                return false;
            }

            return true;
        }

        private void xfrmMedidores_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
