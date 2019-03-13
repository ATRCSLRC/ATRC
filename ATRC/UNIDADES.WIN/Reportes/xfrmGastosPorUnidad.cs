using ATRCBASE.BL;
using ATRCBASE.WIN;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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

namespace UNIDADES.WIN.Reportes
{
    public partial class xfrmGastosPorUnidad : xfrmBase
    {
        public xfrmGastosPorUnidad()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo UnidadTrabajo;
        #region Eventos
        private void xfrmGastosPorUnidad_Load(object sender, EventArgs e)
        {
            UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            XPView Usuarios = new XPView(UnidadTrabajo, typeof(Unidad), "Oid;Nombre", null);
            lueUnidad.Properties.DataSource = Usuarios;
            lueUnidad.Properties.DisplayMember = "Nombre";
            lueUnidad.Properties.BestFit();
            Grafica.Series[0].Points.RemoveRange(0, Grafica.Series[0].Points.Count);
           
        }

        private void bbiBuscar_Click(object sender, EventArgs e)
        {
            if (lueUnidad.EditValue != null)
            {
                Unidad Unidad = ((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject());
                GroupOperator go = new GroupOperator(GroupOperatorType.And);
                go.Operands.Add(new ContainsOperator("Salidas", new BinaryOperator("Fecha", dteDel.DateTime.AddDays(-1), BinaryOperatorType.GreaterOrEqual)));
                go.Operands.Add(new ContainsOperator("Salidas", new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual)));
                go.Operands.Add(new BinaryOperator("Oid", Unidad.Oid));
                Type typeSalida = System.Reflection.Assembly.Load("ALMACEN.BL").GetType("ALMACEN.BL.SalidaArticulo");
                XPView Salidas = new XPView(UnidadTrabajo, typeof(Unidad));
                Salidas.AddProperty("Oid", "Oid", true);
                Salidas.AddProperty("Total", "[Salidas].Sum([Cantidad] * [Factura.Precio])");
                Salidas.Criteria = go;

                int Combustible = 0;
                if (Unidad.Combustible == Enums.Combustible.Diesel)
                {
                    GroupOperator goDiesel = new GroupOperator(GroupOperatorType.And);
                    goDiesel.Operands.Add(new BinaryOperator("Fecha", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                    goDiesel.Operands.Add(new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
                    goDiesel.Operands.Add(new BinaryOperator("Unidad.Oid", Unidad.Oid));
                    goDiesel.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                    XPView Diesel = new XPView(UnidadTrabajo, typeof(Diesel), "Oid;Litros", goDiesel);
                    Combustible = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();
                }

                if (Salidas.Count > 0)
                {
                    Grafica.Series[0].Points.RemoveRange(0, Grafica.Series[0].Points.Count);
                    fypImprimir.ShowPopup();
                    Grafica.Series[0].Points.Add(new SeriesPoint("Combustible", Combustible));
                    Grafica.Series[0].Points.Add(new SeriesPoint("Almacen", Salidas[0]["Total"]));
                }
            }else
            {
                XtraMessageBox.Show("Debe de seleccionar una unidad.");
                lueUnidad.Focus();
            }
        }

        private void bbiCancelar_Click(object sender, EventArgs e)
        {
            fypImprimir.HidePopup();
            Grafica.Series[0].Points.RemoveRange(0, Grafica.Series[0].Points.Count);
            lueUnidad.EditValue = null;
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
        }

        private void fypImprimir_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            if (lueUnidad.EditValue != null)
            {
                Unidad Unidad = ((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject());
                ReportPrintTool repRadios = new ReportPrintTool(new REPORTES.Unidades.GastosPorUnidad(Unidad.Oid));
                repRadios.ShowPreview();
            }
        }
        #endregion
        #region Metodos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                btnBuscar.PerformClick();
                return true;
            }
            if (keyData == Keys.F12)
            {
                btnCancelar.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
