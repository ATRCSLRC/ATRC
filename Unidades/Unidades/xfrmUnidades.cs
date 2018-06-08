using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class xfrmUnidades : RibbonForm
    {
        public xfrmUnidades()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo Unidad;
        private void xfrmUnidades_Load(object sender, EventArgs e)
        {
            btnAcciones.Text = Utilerias.UsuarioActual.Nombre;
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            flpNuevo.ShowPopup();
            XPCollection Unidades = new XPCollection(Unidad, typeof(Unidad.BL.Unidad), true);
            grdUnidades.DataSource = Unidades;
            lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lblNombreUnidad.Text = string.Empty;
            cboTipoMoneda.Properties.Items.AddRange(typeof(Enums.TipoMoneda).GetEnumValues());
            cboFormaPago.Properties.Items.AddRange(typeof(Enums.FormaPago).GetEnumValues());
            cboConcepto.Properties.Items.AddRange(typeof(Enums.ConceptoGasto).GetEnumValues());
            cboTipoMoneda.SelectedIndex = 0;
            cboFormaPago.SelectedIndex = 0;
            cboConcepto.SelectedIndex = 1;
            dteFecha.DateTime = DateTime.Now;
        }

        private void btnNuevaUnidad_Click(object sender, EventArgs e)
        {
            xfrmUnidad xfrm = new xfrmUnidad();
            xfrm.ShowInTaskbar = false;
            xfrm.esModificacion = false;
            xfrm.ShowDialog();
            (grdUnidades.DataSource as XPCollection).Reload();
        }

        private void grvUnidades_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (Unidad == null)
            {
                lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                //lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lblNombreUnidad.Text = string.Empty;
            }
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            AgregarGasto();
        }

        private void grvDetallesGastos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Unidad.CommitChanges();
            if (e.Column == colCantidad || e.Column == colTipoCambio || e.Column == colTipoMoneda)
            {
                GastosUnidad Gasto = grvDetallesGastos.GetFocusedRow() as GastosUnidad;
                lblTotalDolar.Text = Gasto.Unidad.TotalDolar.ToString("c");
                lblTotalPesos.Text = Gasto.Unidad.TotalPesos.ToString("c");
            }

        }

        private void btnAcciones_Click(object sender, EventArgs e)
        {
            flpAcciones.ShowBeakForm();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            xfrmUsuariosGRD xfrm = new xfrmUsuariosGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            xfrmUnidadGRD xfrm = new xfrmUnidadGRD();
            xfrm.Unidad = Unidad;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            (grdUnidades.DataSource as XPCollection).Reload();
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            GastosUnidad Gasto = grvDetallesGastos.GetFocusedRow() as GastosUnidad;
            if (Gasto != null)
            {
                if(grvDetallesGastos.FocusedRowHandle == 0 & Gasto.ConceptoDeGasto == Enums.ConceptoGasto.CompraUnidad)
                {
                    XtraMessageBox.Show("El gasto de compra de unidad no se puede eliminar.");
                    return;
                }

                if (XtraMessageBox.Show("¿Desea eliminar el gasto seleccionado?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Gasto.Unidad.Save();
                    
                    lblTotalDolar.Text = Gasto.Unidad.TotalDolar.ToString("c");
                    lblTotalPesos.Text = Gasto.Unidad.TotalPesos.ToString("c");
                    Gasto.Unidad.Gastos.Remove(Gasto);
                    Gasto.Session.CommitTransaction();
                    grdDetallesGastos.Refresh();
                    grdDetallesGastos.RefreshDataSource();
                    
                }
            }
        }

        private void grvDetallesGastos_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            GastosUnidad Gasto = grvDetallesGastos.GetFocusedRow() as GastosUnidad;
            if (Gasto != null)
            {
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                //lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                //lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

        }

        private void grvUnidades_RowClick(object sender, RowClickEventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (Unidad != null)
            {
                lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                //lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lblNombreUnidad.Text = Unidad.Nombre;
                spnCantidad.Value = 0;
                memoComentarios.EditValue = string.Empty;
                cboTipoMoneda.SelectedIndex = 0;
                memoComentarios.Properties.NullText = "Comentarios";
                grdDetallesGastos.DataSource = Unidad.Gastos;
                lblTipoUnidad.Text = Unidad.TipoUnidad.ToString();
                lblDetallesUnidad.Text = string.Format("Motor {0}, {1} cilindros, {2} ", Unidad.Motor, Unidad.Cilindros, Unidad.Transmision);

                lblTotalDolar.Text = Unidad.TotalDolar.ToString("c");
                lblTotalPesos.Text = Unidad.TotalPesos.ToString("c");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (Unidad != null)
            {
                xfrmTotales xfrm = new xfrmTotales();
                xfrm.Unidad = Unidad;
                xfrm.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                AgregarGasto();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AgregarGasto()
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (spnCantidad.Value <= 0)
            {
                XtraMessageBox.Show("Debe de agregar una cantidad.");
                spnCantidad.Focus();
                return;
            }
            if (spnTipoCambio.Value <= 0)
            {
                XtraMessageBox.Show("Debe de agregar el tipo de cambio.");
                spnTipoCambio.Focus();
                return;
            }

            if (Unidad != null)
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    GastosUnidad Gasto = new GastosUnidad(Unidad.Session);
                    Gasto.Fecha = dteFecha.DateTime;
                    Gasto.FormaDePago = (Enums.FormaPago)cboFormaPago.EditValue;
                    Gasto.ConceptoDeGasto = (Enums.ConceptoGasto)cboConcepto.EditValue;
                    Gasto.TipoCambio = spnTipoCambio.Value;
                    Gasto.LugarCompra = txtLugar.Text;
                    Gasto.Cantidad = spnCantidad.Value;
                    Gasto.TipoMoneda = (Enums.TipoMoneda)cboTipoMoneda.EditValue;

                    Gasto.Comentarios = memoComentarios.Text;
                    Gasto.Save();
                    Unidad.Save();
                    Unidad.Gastos.Add(Gasto);
                    Unidad.Session.CommitTransaction();

                    dteFecha.DateTime = DateTime.Now;
                    cboTipoMoneda.SelectedIndex = 0;
                    cboFormaPago.SelectedIndex = 0;
                    cboConcepto.SelectedIndex = 1;
                    spnTipoCambio.Value = 0;
                    spnCantidad.Value = 0;
                    memoComentarios.Text = txtLugar.Text = string.Empty;
                    lblTotalDolar.Text = Unidad.TotalDolar.ToString("c");
                    lblTotalPesos.Text = Unidad.TotalPesos.ToString("c");
                    grdDetallesGastos.Refresh();
                    grdDetallesGastos.RefreshDataSource();
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar una unidad.");
            }
        }
    }
}
