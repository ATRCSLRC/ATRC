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
        double Combustible = 0;
        XPView CombustibleUnidad;
        #region Eventos
        private void xfrmGastosPorUnidad_Load(object sender, EventArgs e)
        {
            UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteAl.DateTime = dteDel.DateTime = DateTime.Now;
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView Usuarios = new XPView(UnidadTrabajo, typeof(Unidad), "Oid;Nombre", go);
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
                UnidadTrabajo = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                GroupOperator go = new GroupOperator(GroupOperatorType.And);
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Unidad.Oid));
                go.Operands.Add(new BetweenOperator("Fecha", dteDel.DateTime.Date, dteAl.DateTime.Date));
                //go.Operands.Add(new ContainsOperator("Salidas", new BetweenOperator("Fecha", dteDel.DateTime.AddDays(-1), dteAl.DateTime.Date)));
                ////go.Operands.Add(new ContainsOperator("Salidas", new BinaryOperator("Fecha", dteDel.DateTime.AddDays(-1), BinaryOperatorType.GreaterOrEqual)));
                ////go.Operands.Add(new ContainsOperator("Salidas", new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual)));
                //go.Operands.Add(new ContainsOperator("Salidas", new BinaryOperator("Estado", 0)));
                //go.Operands.Add(new BinaryOperator("Oid", Unidad.Oid));
                Type typeSalida = System.Reflection.Assembly.Load("ALMACEN.BL").GetType("ALMACEN.BL.SalidaArticulo");
                XPView Salidas = new XPView(UnidadTrabajo, typeSalida, "Oid;Fecha;Cantidad;Factura.Precio", go);
                //Salidas.AddProperty("Oid", "Oid", true);
                //Salidas.AddProperty("Total", "Sum([Cantidad] * [Factura.Precio])");
                //Salidas.Criteria = go;
                ////XPCollection Unidades = new XPCollection(UnidadTrabajo, typeof(Unidad), new BinaryOperator("Oid", Unidad.Oid));
                ////XPCollection Salidas = ((Unidad)Unidades[0]).GetMemberValue("Salidas") as XPCollection;
                ////Salidas.Criteria = new BetweenOperator("Fecha", dteDel.DateTime.Date, dteAl.DateTime.Date);
                double Almacen = (from ViewRecord sP in Salidas select (Convert.ToDouble(sP["Cantidad"]) * Convert.ToDouble(sP["Factura.Precio"]))).Sum();

                Combustible = 0;
                if (Unidad.Combustible == Enums.Combustible.Diesel)
                {
                    GroupOperator goDiesel = new GroupOperator(GroupOperatorType.And);
                    goDiesel.Operands.Add(new BinaryOperator("Fecha", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                    goDiesel.Operands.Add(new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
                    goDiesel.Operands.Add(new BinaryOperator("Unidad.Oid", Unidad.Oid));
                    goDiesel.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                    CombustibleUnidad = new XPView(UnidadTrabajo, typeof(Diesel), "Oid;Fecha;Unidad.Nombre;Litros;UltimaRecarga.PrecioLitro", goDiesel);
                    Combustible = (from ViewRecord sP in CombustibleUnidad select (Convert.ToInt32(sP["Litros"]) * Convert.ToDouble(sP["UltimaRecarga.PrecioLitro"]))).Sum();
                }else
                {
                    GroupOperator goGasolina = new GroupOperator(GroupOperatorType.And);
                    goGasolina.Operands.Add(new BinaryOperator("Fecha", dteDel.DateTime.Date, BinaryOperatorType.GreaterOrEqual));
                    goGasolina.Operands.Add(new BinaryOperator("Fecha", dteAl.DateTime.Date, BinaryOperatorType.LessOrEqual));
                    goGasolina.Operands.Add(new BinaryOperator("Unidad.Oid", Unidad.Oid));
                    goGasolina.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                    CombustibleUnidad = new XPView(UnidadTrabajo, typeof(Gasolina), "Oid;Fecha;Unidad.Nombre;Litros;UltimaRecarga.PrecioLitro", goGasolina);
                    Combustible = (from ViewRecord sP in CombustibleUnidad select (Convert.ToInt32(sP["Litros"]) * Convert.ToDouble(sP["UltimaRecarga.PrecioLitro"]))).Sum();
                }

                //if (Salidas.Count > 0 )
                //{
                    Grafica.Series[0].Points.RemoveRange(0, Grafica.Series[0].Points.Count);
                    fypImprimir.ShowPopup();
                    Grafica.Series[0].Points.Add(new SeriesPoint("Combustible", Combustible));
                    Grafica.Series[0].Points.Add(new SeriesPoint("Almacen", Almacen));
                //}
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
                switch (e.Button.Caption)
                {
                    case "Imprimir gastos almacen":
                        ReportPrintTool repRadios = new ReportPrintTool(new REPORTES.Unidades.GastosPorUnidad(Unidad.Oid, dteDel.DateTime.Date, dteAl.DateTime.Date));
                        repRadios.ShowPreview();
                        break;
                    case "Imprimir gastos combustible":
                        if (CombustibleUnidad.Count > 0)
                        {
                            ReportPrintTool repCombustible = new ReportPrintTool(new REPORTES.Unidades.GastosDeCombustible(CombustibleUnidad, Combustible));
                            repCombustible.ShowPreview();
                        }else
                        {
                            XtraMessageBox.Show("No hay registros de combustible.");
                        }
                        break;
                } 
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
