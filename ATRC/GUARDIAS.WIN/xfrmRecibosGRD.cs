﻿using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
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

namespace GUARDIAS.WIN
{
    public partial class xfrmRecibosGRD : xfrmBase
    {
        public xfrmRecibosGRD()
        {
            InitializeComponent();
        }

        private void xfrmRecibosGRD_Load(object sender, EventArgs e)
        {
            bbiModificar.Visibility = Utilerias.VisibilidadPermiso("ModificarRecibo");
            bbiReimprimir.Visibility = Utilerias.VisibilidadPermiso("ImprimirRecibo");
            dteA.DateTime = dteDe.DateTime = DateTime.Now;
        }

        private void rgTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rgTipoBusqueda.SelectedIndex == 0)
            {
                lciDe.Visibility = lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                dteA.DateTime = dteDe.DateTime = DateTime.Now;
                lciFolio.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }else
            {
                lciDe.Visibility = lciA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                spnFolio.EditValue = null;
                lciFolio.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            if(rgTipoBusqueda.SelectedIndex == 0)
            {
                go.Operands.Add(new BinaryOperator("Folio", spnFolio.EditValue));
            }else
            {
                go.Operands.Add(new BinaryOperator("Fecha", dteDe.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                go.Operands.Add(new BinaryOperator("Fecha", dteA.DateTime.Date.AddDays(1), BinaryOperatorType.LessOrEqual));
            }

            XPView ViewRecibo = new XPView(Unidad, typeof(Recibos), "Oid;Emisor;TipoCambio;Precio;Concepto;Fecha;Folio", go);
            grdRecibos.DataSource = ViewRecibo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rgTipoBusqueda.SelectedIndex = 0;
            grdRecibos.DataSource = null;
        }

        private void bbiModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewRecibo = grvRecibos.GetFocusedRow() as ViewRecord;
            if (viewRecibo != null)
            {
                xfrmRecibos xfrm = new xfrmRecibos();
                xfrm.EsModificacion = true;
                xfrm.Recibo = viewRecibo.GetObject() as Recibos;
                xfrm.Show();
                ((XPView)grdRecibos.DataSource).Reload();
            }
        }

        private void bbiReimprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewRecibo = grvRecibos.GetFocusedRow() as ViewRecord;
            if (viewRecibo != null)
            {
                ReportPrintTool reprecibo = new ReportPrintTool(new REPORTES.Guardias.RecibosPago(Convert.ToInt32(viewRecibo["Oid"])));
                reprecibo.ShowPreview();
            }
        }

        private void bbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
