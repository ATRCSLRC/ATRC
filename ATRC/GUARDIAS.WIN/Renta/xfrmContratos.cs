using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using GUARDIAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ATRCBASE.BL.Enums;

namespace GUARDIAS.WIN
{
    public partial class xfrmContratos : xfrmBase
    {
        public xfrmContratos()
        {
            InitializeComponent();
        }

        private void xfrmContratos_Load(object sender, EventArgs e)
        {
            cmbEstado.Properties.Items.AddRange(typeof(EstadoContrato).GetEnumValues());
            dteAl.DateTime = dteDe.DateTime = DateTime.Now;
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if(viewContrato != null)
            {
                ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.ContratoRenta(Convert.ToInt32(viewContrato["Oid"])));
                reprecibo.ShowPreview();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Contratos = new XPView(Unidad, typeof(ContratoRenta));
            Contratos.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("EstadoContrato", SortDirection.None, "[EstadoContrato]", false, true),
                  new ViewProperty("NumContrato", SortDirection.None, "[NumContrato]", false, true),
                  new ViewProperty("ADondeSeDirige", SortDirection.None, "[ADondeSeDirige]", false, true),
                  new ViewProperty("DiaSalida", SortDirection.None, "[DiaSalida]", false, true),
                  new ViewProperty("Cliente", SortDirection.None, "iif([Cliente] is null,[Responsable],[Cliente.Nombre])",false, true),
                  new ViewProperty("DiaRegreso", SortDirection.None, "[DiaRegreso]", false, true),
                  new ViewProperty("DiasRenta", SortDirection.None, "[DiasRenta]", false, true),
                  new ViewProperty("Costo", SortDirection.None, "[Costo]", false, true),
                  new ViewProperty("Anticipo", SortDirection.None, "[Anticipo]", false, true),
                  new ViewProperty("Descuento", SortDirection.None, "[Descuento]",false, true),
                  new ViewProperty("Recargos", SortDirection.None, "[Recargos]",false, true),
                  new ViewProperty("Total", SortDirection.None, "[Total]", false, true),
                  new ViewProperty("SubTotal", SortDirection.None, "[Total] - [Anticipo]", false, true)
                 });
            GroupOperator go = new GroupOperator();
            
            switch (rgTipoBusqueda.SelectedIndex)
            {
                case 0:
                    if(!string.IsNullOrEmpty(txtNumContrato.Text))
                        go.Operands.Add(new BinaryOperator("NumContrato", Convert.ToInt32(txtNumContrato.Text)));
                    break;
                case 1:
                    go.Operands.Add(new BinaryOperator("EstadoContrato", cmbEstado.EditValue));
                    break;
                case 2:
                    go.Operands.Add(new BinaryOperator("DiaSalida", dteDe.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                    go.Operands.Add(new BinaryOperator("DiaSalida", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
                    break;
            }
            Contratos.Criteria = go;
            grdContratos.DataSource = Contratos;
            if (Contratos.Count > 0)
                rpAcciones.Visible = true;
            else
                rpAcciones.Visible = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rgTipoBusqueda.SelectedIndex = 0;
            grdContratos.DataSource = null;
            rpAcciones.Visible = false;
            bbiGenerarContrato.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            rpgImprimir.Visible = Utilerias.VisibilidadPermiso("ReimprimirContrato") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false; 
        }

        private void rgTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.EditValue = null;
            dteDe.DateTime = dteAl.DateTime = DateTime.Now;
            txtNumContrato.Text = string.Empty;

            switch (rgTipoBusqueda.SelectedIndex)
            {
                case 0:
                    lciNumContrato.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciEstado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciDe.Visibility = lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 1:
                    lciNumContrato.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciEstado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciDe.Visibility = lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 2:
                    lciNumContrato.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciEstado.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciDe.Visibility = lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                if ((Enums.EstadoContrato)viewContrato["EstadoContrato"] != EstadoContrato.Cancelado & 
                    (Enums.EstadoContrato)viewContrato["EstadoContrato"] != EstadoContrato.Terminado)
                {
                    if (XtraMessageBox.Show("¿Desea cancelar el contrato?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        XtraInputBoxArgs args = new XtraInputBoxArgs();
                        args.Caption = "Cantidad a devolver por cancelación de renta.";
                        args.Prompt = "Cantidad:";
                        SpinEdit editor = new SpinEdit();
                        editor.Properties.DisplayFormat.FormatString = "c";
                        editor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        editor.Properties.EditFormat.FormatString = "c";
                        editor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        editor.Properties.EditMask = "c";
                        args.Editor = editor;
                        //args.DefaultResponse = viewUnidad["PrecioRenta"];
                        var result = XtraInputBox.Show(args);
                        if (result != null)
                        {
                            if (XtraMessageBox.Show("¿El monto ingresado es correcto?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                ContratoRenta Contrato = viewContrato.GetObject() as ContratoRenta;
                                if (!Contrato.Cancelado)
                                {
                                    Contrato.Cancelado = true;
                                    Contrato.EstadoContrato = EstadoContrato.Cancelado;
                                    Contrato.CantidadDevuelta = Convert.ToDecimal(result);
                                    Contrato.Save();
                                    Contrato.Session.CommitTransaction();
                                    ((XPView)grdContratos.DataSource).Reload();
                                    XtraMessageBox.Show("Se ha cancelado correctamente.");
                                }
                                else
                                {
                                    XtraMessageBox.Show("No es posible cancelar el contrato porque ya se encuentra cancelado.");
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Ocurrio un problema al ingresar la cantidad devolución.");
                        }
                    }
                }
            }
            ((XPView)grdContratos.DataSource).Reload();
        }

        private void bbiModificarContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                xfrmContrato xfrm = new xfrmContrato();
                xfrm.IDContrato = Convert.ToInt32(viewContrato["Oid"]);
                xfrm.Show();
            }
            ((XPView)grdContratos.DataSource).Reload();
        }

        private void bbiGenerarContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                ContratoRenta Contrato = viewContrato.GetObject() as ContratoRenta;
                Contrato.EstadoContrato = EstadoContrato.Creado;
                Contrato.EsApartado = false;
                Contrato.Session.CommitTransaction();
                ReportPrintTool repContrato = new ReportPrintTool(new REPORTES.Guardias.ContratoRenta(Convert.ToInt32(viewContrato["Oid"])));
                repContrato.ShowPreview();
            }
            ((XPView)grdContratos.DataSource).Reload();
        }

        private void grvContratos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                if((Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Apartado)
                {
                    bbiGenerarContrato.Visibility = Utilerias.VisibilidadPermiso("GenerarContrato");
                    //bbiGenerarContrato.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    rpgImprimir.Visible = false;
                }
                else
                {
                    bbiGenerarContrato.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    rpgImprimir.Visible = Utilerias.VisibilidadPermiso("ReimprimirContrato") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
                }

                if ((Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Cancelado ||
                    (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.EnProceso || (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Terminado)
                {
                    bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    bbiCancelar.Visibility = Utilerias.VisibilidadPermiso("CancelarContrato");
                }
            }
        }

        private void grvContratos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                if ((Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Apartado)
                {
                    bbiGenerarContrato.Visibility = Utilerias.VisibilidadPermiso("GenerarContrato");
                    rpgImprimir.Visible = false;
                }
                else
                {
                    bbiGenerarContrato.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    rpgImprimir.Visible = Utilerias.VisibilidadPermiso("ReimprimirContrato") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
                }

                if ((Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Cancelado ||
                    (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.EnProceso || (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Terminado)
                {
                    bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    bbiCancelar.Visibility = Utilerias.VisibilidadPermiso("CancelarContrato");
                }
            }
        }
    }
}
