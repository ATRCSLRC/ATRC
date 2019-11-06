using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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

            DataSource();
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


            //Cargar imagenes 
            DevExpress.Utils.ImageCollection images = new DevExpress.Utils.ImageCollection();
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Azul);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Amarillo);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Verde);
            images.AddImage((Bitmap)global::Unidades.Properties.Resources.Flag_Rojo);
            //Configuracion columna de estado

            RepositoryItemImageComboBox imageCombo_Estado = grdUnidades.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            //imageCombo_Estado.SelectedIndexChanged += new EventHandler(imageComboBoxEdit_SelectedIndexChanged);
            imageCombo_Estado.SmallImages = images;
            imageCombo_Estado.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            imageCombo_Estado.Buttons[0].Appearance.BackColor = Color.White;
            imageCombo_Estado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            imageCombo_Estado.LookAndFeel.UseDefaultLookAndFeel = false;
            imageCombo_Estado.LookAndFeel.SkinName = "Office 2016 Colorful";
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Translado", Enums.Estado.Translado, 0));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Detallado", Enums.Estado.Detallado, 1));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Preparado", Enums.Estado.Preparado, 2));
            imageCombo_Estado.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Vendido", Enums.Estado.Vendido, 3)); 

            imageCombo_Estado.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            imageCombo_Estado.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.imageCombo_Estado_EditValueChanging);
            grvUnidades.Columns["Estado"].ColumnEdit = imageCombo_Estado;




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
            }
            else
            {
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

        }

        private void grvUnidades_RowClick(object sender, RowClickEventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (Unidad != null)
            {
                
                if (Unidad.Estado == Enums.Estado.Vendido)
                {
                    colConceptoGasto.Visible = false;
                    colLugar.Visible = false;
                    lciLugar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciConceptoGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Unidad.Gastos.Criteria = null;
                    Unidad.Gastos.Criteria = new BinaryOperator("TipoTransaccion", Enums.TipoTransaccion.Pago);
                    grdDetallesGastos.DataSource = Unidad.Gastos;
                    lblDatosComprador.Text = Unidad.DetalleVenta == null ? "" : Unidad.DetalleVenta.Comprador + "<br>" +
                        Unidad.DetalleVenta.Destino + "<br>" + Unidad.DetalleVenta.Direccion + ", " + Unidad.DetalleVenta.Tel + "<br>" +
                        Unidad.DetalleVenta.CorreoElectronico + "<br> Se vendio el día " + DateTime.Now;
                    lblTotalVenta.Text = Unidad.DetalleVenta.PrecioUnidad.ToString("c") + " " + Unidad.DetalleVenta.TipoMoneda.ToString();
                    lcgTotalPesos.Text = "Total abono en pesos";
                    lcgTotalDolar.Text = "Total abono en dolar";
                    btnAgregarGasto.ToolTip = "Agregar nuevo abono (F5)";
                    lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    flpDetalle.ShowPopup();
                }
                else
                {
                    colLugar.Visible = true;
                    colConceptoGasto.Visible = true;
                    colConceptoGasto.VisibleIndex = 5;
                    lcgTotalPesos.Text = "Total pesos";
                    lcgTotalDolar.Text = "Total dolar";
                    btnAgregarGasto.ToolTip = "Agregar nuevo costo (F5)";
                    lciLugar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciConceptoGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    Unidad.Gastos.Criteria = null;
                    Unidad.Gastos.Criteria = new BinaryOperator("TipoTransaccion", Enums.TipoTransaccion.Gasto);
                    grdDetallesGastos.DataSource = Unidad.Gastos;
                    lciCalcular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    flpDetalle.HidePopup();
                }
                lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lblNombreUnidad.Text = Unidad.Nombre;
                spnCantidad.Value = 0;
                memoComentarios.EditValue = string.Empty;
                cboTipoMoneda.SelectedIndex = 0;
                memoComentarios.Properties.NullText = "Comentarios";
                
                lblTipoUnidad.Text = Unidad.TipoUnidad.ToString();
                lblDetallesUnidad.Text = string.Format("Motor {0}, {1} cilindros, {2} ", Unidad.Motor, Unidad.Cilindros, Unidad.Transmision);

                lblTotalDolar.Text = Unidad.TotalDolar.ToString("c");
                lblTotalPesos.Text = Unidad.TotalPesos.ToString("c");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            Unidad.BL.Unidad UnidadCamion = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (UnidadCamion != null)
            {
                if (UnidadCamion.DetalleVenta.TipoMoneda == Enums.TipoMoneda.Dolares)
                {
                    if (UnidadCamion.DetalleVenta.PrecioUnidad == UnidadCamion.TotalDolar)
                    {
                        if (XtraMessageBox.Show("¿Desea marcar como pagado la unidad?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            UnidadCamion.DetalleVenta.Pagado = true;
                            UnidadCamion.Save();
                            UnidadCamion.Session.CommitTransaction();
                            XtraMessageBox.Show("La unidad fue marcada como pagada.");
                            (grdUnidades.DataSource as XPCollection).Reload();
                        }
                    }
                    else
                        XtraMessageBox.Show("La suma de lo abonos no concuerda con el costo de la unidad.");
                }
                  else
                {
                    if (UnidadCamion.DetalleVenta.PrecioUnidad == UnidadCamion.TotalPesos)
                    {
                        if (XtraMessageBox.Show("¿Desea marcar como pagado la unidad?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            UnidadCamion.DetalleVenta.Pagado = true;
                            UnidadCamion.Save();
                            UnidadCamion.Session.CommitTransaction();
                            XtraMessageBox.Show("La unidad fue marcada como pagada.");
                            (grdUnidades.DataSource as XPCollection).Reload();
                        }
                    }
                    else
                        XtraMessageBox.Show("La suma de lo abonos no concuerda con el costo de la unidad.");
                }
                
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
                    if (Unidad.Estado != Enums.Estado.Vendido)
                    {
                        Gasto.ConceptoDeGasto = (Enums.ConceptoGasto)cboConcepto.EditValue;
                        Gasto.LugarCompra = txtLugar.Text;
                        Gasto.TipoTransaccion = Enums.TipoTransaccion.Gasto;
                    }else
                    {
                        Gasto.TipoTransaccion = Enums.TipoTransaccion.Pago;
                        lblFaltanteDolar.Text = lblFaltesPesos.Text = string.Empty;
                        spnTipoCambioFaltante.Value = 0;
                    }

                    Gasto.Fecha = dteFecha.DateTime;
                    Gasto.FormaDePago = (Enums.FormaPago)cboFormaPago.EditValue;
                    Gasto.TipoCambio = spnTipoCambio.Value;
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

        private void imageCombo_Estado_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Unidad.BL.Unidad UnidadCamion = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (UnidadCamion != null)
            {

                if ((Enums.Estado)e.OldValue == Enums.Estado.Vendido)
                {
                    XtraMessageBox.Show("La unidad se encuentra vendida, no se puede cambiar el estado.");
                    UnidadCamion.Estado = (Enums.Estado)e.OldValue;
                    e.Cancel = true;
                }
                else
                {
                    if ((Enums.Estado)e.NewValue == Enums.Estado.Vendido)
                    {
                        UnidadCamion.Estado = Enums.Estado.Vendido;
                        xfrmDetalleVenta xfrm = new xfrmDetalleVenta();
                        xfrm.UnidadCamion = UnidadCamion;
                        xfrm.Unidad = Unidad;
                        xfrm.ShowInTaskbar = false;
                        xfrm.ShowDialog();
                        if (xfrm.DialogResult == DialogResult.Cancel)
                        {
                            UnidadCamion.Estado = (Enums.Estado)e.OldValue;
                            e.Cancel = true;
                        }
                        DataSource();
                        //(grdUnidades.DataSource as XPCollection).Reload();
                    }
                    else
                    {
                        UnidadCamion.Estado = (Enums.Estado)e.NewValue;
                        UnidadCamion.Save();
                        UnidadCamion.Session.CommitTransaction();
                        XtraMessageBox.Show("Se ha actualizo el estado correctamente.");
                        //(grdUnidades.DataSource as XPCollection).Reload();
                    }
                }
            }
        }

        private void spnTipoCambioFaltante_EditValueChanged(object sender, EventArgs e)
        {
            Unidad.BL.Unidad UnidadCamion = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (UnidadCamion != null)
            {
                if (spnTipoCambioFaltante.Value > 0)
                {
                    if (UnidadCamion.DetalleVenta.TipoMoneda == Enums.TipoMoneda.Dolares)
                    {
                        lblFaltanteDolar.Text = (UnidadCamion.DetalleVenta.PrecioUnidad - UnidadCamion.TotalDolar).ToString("c") + " Dolares";
                        lblFaltesPesos.Text = ((UnidadCamion.DetalleVenta.PrecioUnidad - UnidadCamion.TotalDolar) * spnTipoCambioFaltante.Value).ToString("c") + " Pesos";
                    }
                    else
                    {
                        lblFaltanteDolar.Text = (UnidadCamion.DetalleVenta.PrecioUnidad - UnidadCamion.TotalPesos).ToString("c") + " Pesos";
                        lblFaltesPesos.Text = ((UnidadCamion.DetalleVenta.PrecioUnidad - UnidadCamion.TotalPesos) / spnTipoCambioFaltante.Value).ToString("c") + " Dolares";
                    }
                }

            }
        }

        private void DataSource()
        {
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("Estado", Enums.Estado.Preparado));
            go.Operands.Add(new BinaryOperator("Estado", Enums.Estado.Translado));
            go.Operands.Add(new BinaryOperator("Estado", Enums.Estado.Detallado));

            GroupOperator goDetalle = new GroupOperator(GroupOperatorType.And);
            goDetalle.Operands.Add(new BinaryOperator("DetalleVenta.EsCredito", true));
            goDetalle.Operands.Add(new BinaryOperator("DetalleVenta.Pagado", false));

            go.Operands.Add(goDetalle);
            XPCollection Unidades = new XPCollection(Unidad, typeof(Unidad.BL.Unidad), go);
            Unidades.Sorting = new SortingCollection(new SortProperty("UnidadDescripcion", DevExpress.Xpo.DB.SortingDirection.Ascending));

            grdUnidades.DataSource = Unidades;
        }
    }
}
