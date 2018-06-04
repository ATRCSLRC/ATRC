﻿using DevExpress.Xpo;
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
            XPCollection Unidades = new XPCollection(Unidad, typeof(Unidad.BL.Unidad));
            grdUnidades.DataSource = Unidades;
            lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lblNombreUnidad.Text = string.Empty;
            cboTipoMoneda.Properties.Items.AddRange(typeof(Enums.TipoMoneda).GetEnumValues());
            cboTipoMoneda.SelectedIndex = 0;
            grvDetallesGastos.FocusedRowHandle = -1;
            grvDetallesGastos.ClearSelection();
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
            
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if(spnCantidad.Value <= 0)
            {
                XtraMessageBox.Show("Debe de agregar una cantidad.");
                spnCantidad.Focus();
                return;
            }

            if(Unidad != null)
            {
                if (XtraMessageBox.Show("¿La información proporcionada es correcta?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    GastosUnidad Gasto = new GastosUnidad(Unidad.Session);
                    Gasto.Fecha = DateTime.Now;
                    Gasto.Cantidad = spnCantidad.Value;
                    Gasto.TipoMoneda = (Enums.TipoMoneda)cboTipoMoneda.EditValue;
                    if ((Enums.TipoMoneda)cboTipoMoneda.EditValue == Enums.TipoMoneda.Pesos)
                        Unidad.TotalPesos += Gasto.Cantidad;
                    else
                        Unidad.TotalDolar += Gasto.Cantidad;
                    
                    Gasto.Comentarios = memoComentarios.Text;
                    Gasto.Save();
                    Unidad.Save();
                    Unidad.Gastos.Add(Gasto);
                    Unidad.Session.CommitTransaction();
                    spnCantidad.Value = 0;
                    memoComentarios.EditValue = string.Empty;
                    cboTipoMoneda.SelectedIndex = 0;
                    lblTotalDolar.Text = Unidad.TotalDolar.ToString("c");
                    lblTotalPesos.Text = Unidad.TotalPesos.ToString("c");
                    grdDetallesGastos.Refresh();
                    grdDetallesGastos.RefreshDataSource();
                }
            }
        }

        private void grvDetallesGastos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Unidad.CommitChanges();
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
            if (Unidad != null)
            {
                if (XtraMessageBox.Show("¿Desea elimanar el gasto seleccionado?", "Unidades", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    
                    if (Gasto.TipoMoneda == Enums.TipoMoneda.Pesos)
                        Gasto.Unidad.TotalPesos -= Gasto.Cantidad;
                    else
                        Gasto.Unidad.TotalDolar -= Gasto.Cantidad;
                    
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
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciBtnEliminarGasto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

        }

        private void grvUnidades_RowClick(object sender, RowClickEventArgs e)
        {
            Unidad.BL.Unidad Unidad = grvUnidades.GetFocusedRow() as Unidad.BL.Unidad;
            if (Unidad != null)
            {
                lciDetalleGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciAgregarCosto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciDetallesUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lblNombreUnidad.Text = Unidad.Nombre;
                spnCantidad.Value = 0;
                memoComentarios.EditValue = string.Empty;
                cboTipoMoneda.SelectedIndex = 0;
                memoComentarios.Properties.NullText = "Comentarios";
                grdDetallesGastos.DataSource = Unidad.Gastos;
                lblMarca.Text = Unidad.Marca;
                lblModelo.Text = Unidad.Modelo;
                lblTotalDolar.Text = Unidad.TotalDolar.ToString("c");
                lblTotalPesos.Text = Unidad.TotalPesos.ToString("c");
            }
        }
    }
}
