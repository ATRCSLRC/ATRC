using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ATRCBASE.BL;
using GUARDIAS.BL;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace REPORTES.Guardias
{
    public partial class ReporteIndiciplina : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteIndiciplina(int ID)
        {
            InitializeComponent();

            XPView Reporte = new XPView(ATRCBASE.BL.UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(Reportes));
            Reporte.AddProperty("Oid", "Oid", true);
            Reporte.AddProperty("Empleado.Nombre", "Empleado.Nombre", true);
            Reporte.AddProperty("Empleado.NumEmpleado", "Empleado.NumEmpleado", true);
            Reporte.AddProperty("JefeDepartamento.Nombre", "JefeDepartamento.Nombre", true);
            Reporte.AddProperty("JefeDepartamento.NumEmpleado", "JefeDepartamento.NumEmpleado", true);
            Reporte.AddProperty("Usuario.Nombre", "Usuario.Nombre", true);
            Reporte.AddProperty("Usuario.NumEmpleado", "Usuario.NumEmpleado", true);
            Reporte.AddProperty("Guardia.Nombre", "Guardia.Nombre", true);
            Reporte.AddProperty("Guardia.NumEmpleado", "Guardia.NumEmpleado", true);
            Reporte.AddProperty("Departamento", "Departamento", true);
            Reporte.AddProperty("Motivo", "Motivo", true);
            Reporte.AddProperty("FechaAlta", "FechaAlta", true);
            Reporte.AddProperty("Folio", "Folio", true);
            Reporte.Criteria = new BinaryOperator("Oid", ID);
            this.DataSource = Reporte;

            DateTime Fecha = Convert.ToDateTime(Reporte[0]["FechaAlta"]);
            txtDetalle.Html = "<FONT FACE='tahoma'>En la empresa <b>Auto transportes del río colorado, S.A.de C.V. / Recursos profesionales integrados S.C.</b>, siendo <b>" + Fecha.ToLongDateString() + " a las " + Fecha.ToString("HH:mm") +" hrs</b>.</FONT>";
           
        }

    }
}
