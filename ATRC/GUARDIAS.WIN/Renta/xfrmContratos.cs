using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Drawing;
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
            bbiEntregarUnidad.Visibility = Utilerias.VisibilidadPermiso("CambioHorarioEntrega");
            bbiRecibirUnidad.Visibility = Utilerias.VisibilidadPermiso("CambioHorarioRecibir");
            rpgHorario.Visible = bbiEntregarUnidad.Visibility == DevExpress.XtraBars.BarItemVisibility.Always ||
                bbiRecibirUnidad.Visibility == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
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
                  new ViewProperty("Unidad.Nombre", SortDirection.None, "[Unidad.Nombre]", false, true),
                  new ViewProperty("ADondeSeDirige", SortDirection.None, "[ADondeSeDirige]", false, true),
                  new ViewProperty("DiaSalida", SortDirection.None, "[DiaSalida]", false, true),
                  new ViewProperty("Cliente", SortDirection.None, "iif([Cliente] is null,[Responsable],[Cliente.Nombre])",false, true),
                  new ViewProperty("DiaRegreso", SortDirection.None, "[DiaRegreso]", false, true),
                  new ViewProperty("DiasRenta", SortDirection.None, "[DiasRenta]", false, true),
                  new ViewProperty("Costo", SortDirection.None, "[Costo]", false, true),
                  new ViewProperty("Anticipo", SortDirection.None, "[Anticipo]", false, true),
                  new ViewProperty("Descuento", SortDirection.None, "[Descuento]",false, true),
                  new ViewProperty("Recargos", SortDirection.None, "[Recargos]",false, true),
                  new ViewProperty("Total", SortDirection.None, "[Total] + [Recargos]", false, true),
                  new ViewProperty("Abono", SortDirection.None, "[Abono]", false, true),
                  new ViewProperty("SubTotal", SortDirection.None, "[Subtotal]", false, true)
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
            if (go.Operands.Count > 0)
            {
                Contratos.Criteria = go;
                grdContratos.DataSource = Contratos;
                if (Contratos.Count > 0)
                    rpAcciones.Visible = true;
                else
                    rpAcciones.Visible = false;
            }

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
                                    Contrato.Comentarios = "Cancelado";
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
            if (XtraMessageBox.Show("¿Esta seguro de querer generar el contrato?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
                if (viewContrato != null)
                {
                    ContratoRenta Contrato = viewContrato.GetObject() as ContratoRenta;
                    Contrato.EstadoContrato = EstadoContrato.Creado;
                    Contrato.NumContrato = NumContrato((UnidadDeTrabajo)Contrato.Session);
                    Contrato.EsApartado = false;
                    Contrato.Session.CommitTransaction();


                    REPORTES.Guardias.ContratoRenta RepContrato = new REPORTES.Guardias.ContratoRenta(Contrato.Oid);
                    RepContrato.CreateDocument();

                    REPORTES.Guardias.ContratoRenta RepContratoCopia = new REPORTES.Guardias.ContratoRenta(Contrato.Oid);
                    RepContratoCopia.CreateDocument();
                    RepContrato.Pages.AddRange(RepContratoCopia.Pages);

                    REPORTES.Guardias.ClausulasRenta RepClausulas = new REPORTES.Guardias.ClausulasRenta();
                    RepClausulas.CreateDocument();
                    RepContrato.Pages.AddRange(RepClausulas.Pages);

                    REPORTES.Guardias.Pagare RepPagare = new REPORTES.Guardias.Pagare(Contrato.NumContrato.ToString());
                    RepPagare.CreateDocument();
                    RepContrato.Pages.AddRange(RepPagare.Pages);

                    RepContrato.Pages[0].AssignWatermark(new Watermark());
                    RepContrato.Pages[2].AssignWatermark(new Watermark());
                    RepContrato.Pages[3].AssignWatermark(new Watermark());

                    ReportPrintTool repContrato = new ReportPrintTool(RepContrato);
                    repContrato.ShowPreview();

                }
            ((XPView)grdContratos.DataSource).Reload();
            }
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
                    (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.EnViaje || (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Terminado)
                {
                    bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    bbiCancelar.Visibility = Utilerias.VisibilidadPermiso("CancelarContrato");
                }

                if ((Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Terminado)
                {
                    if (Convert.ToDecimal(viewContrato["Recargos"]) == 0)
                    {
                        bbiGenerarRecargos.Caption = "Generar recargos";

                    }else
                    {
                        bbiGenerarRecargos.Caption = "Quitar recargos";
                    }
                    rpgDescuentos.Visible = true;

                }else
                {
                    rpgDescuentos.Visible = false;
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
                    (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.EnViaje || (Enums.EstadoContrato)viewContrato["EstadoContrato"] == Enums.EstadoContrato.Terminado)
                {
                    bbiCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    bbiCancelar.Visibility = Utilerias.VisibilidadPermiso("CancelarContrato");
                }
            }
        }

        private void bbiImprimirContratos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportPrintTool repContratos = new ReportPrintTool(new REPORTES.Guardias.ListadoContratos(((XPView)grdContratos.DataSource).Criteria));
            repContratos.ShowPreview();
            
        }

        public int NumContrato(UnidadDeTrabajo Unidad)
        {
            XPView Usuarios = new XPView(Unidad, typeof(ContratoRenta));

            Usuarios.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("NumContrato", SortDirection.Descending, "[NumContrato]", true, true)});
            Usuarios.SelectDeleted = true;
            if (Usuarios.Count <= 0)
                return 2702;
            else
            {
                if (Convert.ToInt32(Usuarios[0]["NumContrato"]) == 0)
                    return 2702;
                return (Convert.ToInt32(Usuarios[0]["NumContrato"]) + 1);
            }
        }

        private void bbiEntregarUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                xfrmCambioHorario xfrm = new xfrmCambioHorario();
                xfrm.IDContrato = Convert.ToInt32(viewContrato["Oid"]);
                xfrm.EsSalida = true;
                xfrm.Show();
            }
            ((XPView)grdContratos.DataSource).Reload();
        }

        private void bbiRecibirUnidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                xfrmCambioHorario xfrm = new xfrmCambioHorario();
                xfrm.IDContrato = Convert.ToInt32(viewContrato["Oid"]);
                xfrm.EsSalida = false;
                xfrm.Show();
            }
            ((XPView)grdContratos.DataSource).Reload();
        }

        private void bbiGenerarRecargos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                ContratoRenta Contrato = viewContrato.GetObject() as ContratoRenta;
                if(Contrato.Recargos == 0)
                {
                    Tuple<decimal, string> X = Calcular(Contrato);
                    Contrato.Recargos = X.Item1;
                }
                else
                {
                    Contrato.Recargos = 0;
                }
                Contrato.Save();
                Contrato.Session.CommitTransaction();
                XtraMessageBox.Show("Se realizarón modificaciones en los recargos.");
                ((XPView)grdContratos.DataSource).Reload();
            }
        }

        private void bbiDescuentosContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewContrato = grvContratos.GetFocusedRow() as ViewRecord;
            if (viewContrato != null)
            {
                if (XtraMessageBox.Show("¿Esta seguro de querer hacer un descuento en los recargos?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    XtraInputBoxArgs args = new XtraInputBoxArgs();
                    args.Caption = "Cantidad a descontar en los recargos.";
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
                            if (Contrato.Recargos > 0 & Convert.ToDecimal(result) <= Contrato.Recargos)
                            {
                                Contrato.Recargos = Contrato.Recargos - Convert.ToDecimal(result);
                                Contrato.Save();
                                Contrato.Session.CommitTransaction();
                                ((XPView)grdContratos.DataSource).Reload();
                                XtraMessageBox.Show("Se ha cancelado correctamente.");
                            }
                            else
                            {
                                XtraMessageBox.Show("No es posible hacer descuentos al contrato.");
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

        private Tuple<decimal, string> Calcular(ContratoRenta Contrato)
        {
            var f = Contrato.DiaSalidaOriginal.Add(Contrato.HoraSalidaOriginal);
            var Entrega = Contrato.DiaRegresoOriginal.Add(Contrato.HoraRegresoOriginal);
            decimal Horas = (Entrega - f).Hours;
            decimal Dias = (Entrega - f).Days;
            decimal HoraDias = (Horas / 24) + (Dias);
            decimal DiasExtra = 0;
            decimal ExtraDia = 0;
            int MediosDiasTarde = 0;
            decimal HorasTardes = 0;
            string Comentarios = string.Empty;

            if (HoraDias >= Contrato.DiasRenta)
            {

                if ((HoraDias - Contrato.DiasRenta) >= 1)
                {
                    DiasExtra = (Dias - Contrato.DiasRenta);
                    ExtraDia = Contrato.Costo * DiasExtra;
                }
                else if (Contrato.DiasRenta.ToString().Contains(".5"))
                {
                    Horas -= 12;
                }

                if (Horas >= 19 & Horas <= 24)
                {
                    DiasExtra += 1;
                    ExtraDia += DiasExtra * Contrato.Costo;
                    Horas -= 24;
                }


                if (Horas >= 7 & Horas <= 18)
                {
                    MediosDiasTarde = 1;
                    ExtraDia += Contrato.Costo / 2;
                    Horas -= 12;
                }

                if (Horas >= 1 & Horas <= 6 & Horas >= Contrato.TiempoTolerancia)
                {
                    ExtraDia += Horas * Contrato.CostoTolerancia;
                    HorasTardes = Horas;
                }

                string EntregaTarde = string.Empty;

                if (DiasExtra > 0)
                    EntregaTarde += DiasExtra.ToString("n1") + " día(s)";
                if (MediosDiasTarde > 0)
                    EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? " medio día " : " y medio";
                if (HorasTardes > 0)
                    EntregaTarde += string.IsNullOrEmpty(EntregaTarde) ? HorasTardes + " hora(s) " : " con " + HorasTardes + " hora(s) ";

                if (!string.IsNullOrEmpty(EntregaTarde))
                    Comentarios = "La unidad se entrego " + EntregaTarde + " tarde.";
            }
            return new Tuple<decimal, string>(ExtraDia, Comentarios);
        }
    }
}
