using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;
using static ATRCBASE.BL.Enums;
using REPORTES.Combustible;
using DevExpress.Xpo.DB;
using COMBUSTIBLE.BL;
using DevExpress.XtraEditors;

namespace COMBUSTIBLE.WIN
{
    public partial class xfrmFiltrosCombustible : xfrmBase
    {
        public xfrmFiltrosCombustible()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadControles;
        public ReporteCombustible ReporteCombustible;
        GroupOperator go = new GroupOperator();

        private void xfrmFiltrosCombustible_Load(object sender, EventArgs e)
        {
            dteDe.EditValue = dteA.EditValue = DateTime.Now;
            UnidadControles = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            rgTipoCombustible.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(Enums.Combustible.Diesel, "Diesel"));
            rgTipoCombustible.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(Enums.Combustible.Gasolina, "Gasolina"));
            go.Operands.Add(new BinaryOperator("Combustible", Combustible.Ninguno));
            rgTipoCombustible.SelectedIndex = 0;
            Diesel();
        }

        private void Diesel()
        {
            switch (ReporteCombustible)
            {
                case ReporteCombustible.Consumo:
                    
                    this.Text = "Consumo de unidad";
                    break;
                case ReporteCombustible.PedidoDiesel:
                    lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    this.Text = "Recargas de diesel";
                    break;
                case ReporteCombustible.UnidadDiesel:
                    lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    this.Text = "Unidades con diesel";
                    break;
                case ReporteCombustible.DetallesMedidores:
                    lciUnidad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    this.Text = "Detalles de medidores Diesel";
                    break;
            }
        }

        private void Gasolina()
        {
            switch (ReporteCombustible)
            {
                case ReporteCombustible.Consumo:
                    this.Text = "Consumo de unidad";
                    break;
                case ReporteCombustible.PedidoDiesel:
                    this.Text = "Recargas de gasolina";
                    break;
                case ReporteCombustible.UnidadDiesel:
                    this.Text = "Unidades con gasolina";
                    break;
                case ReporteCombustible.DetallesMedidores:
                    this.Text = "Detalles de medidores Gasolina";
                    break;
            }
        }

        private bool ValidarCampos()
        {
            if(rgTipoCombustible.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar este tipo de combustible.");
                rgTipoCombustible.Focus();
                return false;
            }

            if (ReporteCombustible == ReporteCombustible.Consumo)
            {
                if (lueUnidad.EditValue == null)
                {
                    XtraMessageBox.Show("Debe seleccionar una unidad.");
                    lueUnidad.Focus();
                    return false;
                }
            }
            return true;
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                if ((Enums.Combustible)rgTipoCombustible.EditValue == Combustible.Diesel)
                {
                    Diesel();
                    switch (ReporteCombustible)
                    {
                        case ReporteCombustible.Consumo:
                            ReportPrintTool repConsumo = new ReportPrintTool(new ConsumoDieselUnidad(dteDe.DateTime, dteA.DateTime, Convert.ToInt32(lueUnidad.EditValue), typeof(Diesel)));
                            repConsumo.ShowPreview();
                            break;
                        case ReporteCombustible.PedidoDiesel:
                            ReportPrintTool repPedidoDiesel = new ReportPrintTool(new REPORTES.Combustible.RecargaDiesel(dteDe.DateTime, dteA.DateTime, typeof(BL.RecargaDiesel), Combustible.Diesel));
                            repPedidoDiesel.ShowPreview();
                            break;
                        case ReporteCombustible.UnidadDiesel:
                            ReportPrintTool repUnidadDiesel = new ReportPrintTool(new UnidadesConDiesel(dteDe.DateTime, dteA.DateTime, typeof(Diesel)));
                            repUnidadDiesel.ShowPreview();
                            break;
                        case ReporteCombustible.DetallesMedidores:
                            ReportPrintTool repDetalles = new ReportPrintTool(new DetallesMedidoresCombustible(dteDe.DateTime, dteA.DateTime, Combustible.Diesel));
                            repDetalles.ShowPreview();
                            break;
                    }
                }
                else
                {
                    Gasolina();
                    switch (ReporteCombustible)
                    {
                        case ReporteCombustible.Consumo:
                            ReportPrintTool repConsumo = new ReportPrintTool(new ConsumoDieselUnidad(dteDe.DateTime, dteA.DateTime, Convert.ToInt32(lueUnidad.EditValue), typeof(Gasolina)));
                            repConsumo.ShowPreview();
                            break;
                        case ReporteCombustible.PedidoDiesel:
                            ReportPrintTool repPedidoDiesel = new ReportPrintTool(new REPORTES.Combustible.RecargaDiesel(dteDe.DateTime, dteA.DateTime, typeof(BL.RecargaDiesel), Combustible.Gasolina));
                            repPedidoDiesel.ShowPreview();
                            break;
                        case ReporteCombustible.UnidadDiesel:
                            ReportPrintTool repUnidadDiesel = new ReportPrintTool(new UnidadesConDiesel(dteDe.DateTime, dteA.DateTime, typeof(Gasolina)));
                            repUnidadDiesel.ShowPreview();
                            break;
                        case ReporteCombustible.DetallesMedidores:
                            ReportPrintTool repDetalles = new ReportPrintTool(new DetallesMedidoresCombustible(dteDe.DateTime, dteA.DateTime, Combustible.Gasolina));
                            repDetalles.ShowPreview();
                            break;
                    }
                }
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void rgTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupOperator goCombustible = new GroupOperator(GroupOperatorType.Or);
            if(rgTipoCombustible.SelectedIndex == 1)
            {
                goCombustible.Operands.Add(new BinaryOperator("Combustible", Combustible.Gasolina));
                goCombustible.Operands.Add(go);
                XPView Unidades = new XPView(UnidadControles, typeof(Unidad));
                Unidades.Properties.AddRange(new ViewProperty[] {
                      new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                      new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                     });
                Unidades.Sorting.Add(new SortProperty("Nombre", SortingDirection.Ascending));
                Unidades.Criteria = goCombustible;
                lueUnidad.Properties.DataSource = Unidades;
            }
            else
            {
                goCombustible.Operands.Add(new BinaryOperator("Combustible", Combustible.Diesel));
                goCombustible.Operands.Add(go);
                XPView Unidades = new XPView(UnidadControles, typeof(Unidad));
                Unidades.Properties.AddRange(new ViewProperty[] {
                      new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                      new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                     });
                Unidades.Sorting.Add(new SortProperty("Nombre", SortingDirection.Ascending));
                Unidades.Criteria = goCombustible;
                lueUnidad.Properties.DataSource = Unidades;
            }
        }
    }
}
