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

namespace GUARDIAS.WIN
{
    public partial class xfrmNuevoReporte : xfrmBase
    {
        public xfrmNuevoReporte()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo Unidad;
        public Reportes ReporteModificacion;
        private void xfrmNuevoReporte_Load(object sender, EventArgs e)
        {
            IniciarControles();
        }

        private void IniciarControles()
        {
            UnidadDeTrabajo UnidadControles = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BinaryOperator bo = new BinaryOperator("Activo", true);

            XPView Empleados = new XPView(UnidadControles, typeof(Usuario));
            Empleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            Empleados.Criteria = bo;
            lueEmpleado.Properties.DataSource = Empleados;
            lueEmpleado.Properties.DisplayMember = "Nombre";
            lueEmpleado.Properties.BestFit();

            XPView JefeDepartamento = new XPView(UnidadControles, typeof(Usuario));
            JefeDepartamento.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true),
                 });
            GroupOperator go = new GroupOperator();
            go.Operands.Add(bo);
            go.Operands.Add(new BinaryOperator("EsAdministrativo", true));
            JefeDepartamento.Criteria = go;
            lueDepartamento.Properties.DataSource = JefeDepartamento;
            lueDepartamento.Properties.DisplayMember = "Nombre";
            lueDepartamento.Properties.BestFit();

            XPView Guardias = new XPView(UnidadControles, typeof(Usuario));
            Guardias.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            GroupOperator goGuardia = new GroupOperator();
            goGuardia.Operands.Add(bo);
            goGuardia.Operands.Add(new BinaryOperator("Puesto", 10));
            Guardias.Criteria = goGuardia;
            lueGuardia.Properties.DataSource = Guardias;
            lueGuardia.Properties.DisplayMember = "Nombre";
            lueGuardia.Properties.BestFit();

            if (ReporteModificacion != null)
            {
                lueDepartamento.Enabled = false;
                lueEmpleado.Enabled = false;
                lueGuardia.Enabled = false;
                lueDepartamento.ReadOnly = true;
                lueEmpleado.ReadOnly = true;
                lueGuardia.ReadOnly = true;
                lueEmpleado.EditValue = ReporteModificacion.Empleado.Oid;
                lueGuardia.EditValue = ReporteModificacion.Guardia.Oid;
                lueDepartamento.EditValue = ReporteModificacion.JefeDepartamento.Oid;
                memoMotivo.Text = ReporteModificacion.Motivo;

            }
        }

        private bool ValidarControles()
        {
            if (lueEmpleado.EditValue == null)
            {
                XtraMessageBox.Show("Debe de seleccionar un empleado.");
                lueEmpleado.Focus();
                return false;
            }

            if (lueDepartamento.EditValue == null)
            {
                XtraMessageBox.Show("Debe de seleccionar un jefe de departamento.");
                lueDepartamento.Focus();
                return false;
            }

            if (lueGuardia.EditValue == null)
            {
                XtraMessageBox.Show("Debe de seleccionar un guardia.");
                lueGuardia.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(memoMotivo.Text))
            {
                XtraMessageBox.Show("Debe agregar el motivo del reporte.");
                memoMotivo.Focus();
                return false;
            }

            return true;
        }
        
        private void LimpiarControles()
        {
            lueDepartamento.EditValue = null;
            lueEmpleado.EditValue = null;
            lueGuardia.EditValue = null;
            memoMotivo.Text = string.Empty;
            lueEmpleado.Focus();
        }

        public int Folio(UnidadDeTrabajo Unidad, string Departamento)
        {

            XPView Reportes = new XPView(Unidad, typeof(Reportes));

            Reportes.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Folio", SortDirection.Descending, "[Folio]", true, true)});
            Reportes.Criteria = new BinaryOperator("Departamento", Departamento);
            Reportes.SelectDeleted = true;
            if (Reportes.Count > 0)
                return Convert.ToInt32(Reportes[0]["Folio"]) + 1;
            else
            {
                switch (Departamento)
                {
                    case "R":
                        return 149;
                    case "RH":
                        return 6;
                    case "T":
                        return 741;
                    case "S":
                        return 1540;
                    case "I":
                        return 110;
                    case "A":
                        return 5;
                }
            }
            return 0;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarControles())
            {
                if (ReporteModificacion != null)
                {
                    ReporteModificacion.Motivo = memoMotivo.Text;
                    ReporteModificacion.Save();
                    ReporteModificacion.Session.CommitTransaction();
                    ReportPrintTool repReporte = new ReportPrintTool(new REPORTES.Guardias.ReporteIndiciplina(ReporteModificacion.Oid));
                    repReporte.ShowPreviewDialog();
                    XtraMessageBox.Show("Se ha modificado elreporte correctamente.");
                    this.Close();
                }
                else
                {
                    Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Reportes Reporte = new Reportes(Unidad);
                    Reporte.Empleado = Unidad.GetObjectByKey<Usuario>(lueEmpleado.EditValue);
                    Reporte.JefeDepartamento = Unidad.GetObjectByKey<Usuario>(lueDepartamento.EditValue);
                    Reporte.Guardia = Unidad.GetObjectByKey<Usuario>(lueGuardia.EditValue);
                    Reporte.Usuario = Utilerias.ObtenerUsuarioActual(Unidad);
                    Reporte.Motivo = memoMotivo.Text;
                    switch (Reporte.JefeDepartamento.Puesto.Oid)
                    {
                        case 7://Rutas
                        case 14:
                            Reporte.Departamento = "R";
                            Reporte.Folio = Folio(Unidad, "R");
                            break;
                        case 8://Recursos humanos
                            Reporte.Departamento = "RH";
                            Reporte.Folio = Folio(Unidad, "RH");
                            break;
                        case 6://Taller
                        case 23:
                        case 20:
                            Reporte.Departamento = "T";
                            Reporte.Folio = Folio(Unidad, "T");
                            break;
                        case 15://Seguridad
                        case 24:
                        case 10:
                            Reporte.Departamento = "S";
                            Reporte.Folio = Folio(Unidad, "S");
                            break;
                        case 17://Informatica
                        case 18:
                            Reporte.Departamento = "I";
                            Reporte.Folio = Folio(Unidad, "I");
                            break;
                        case 1://Administracion
                        case 2:
                        case 5:
                        case 11:
                        case 22:
                        case 21:
                            Reporte.Departamento = "A";
                            Reporte.Folio = Folio(Unidad, "A");
                            break;

                    }
                    Reporte.Save();
                    Unidad.CommitChanges();
                    ReportPrintTool repReporte = new ReportPrintTool(new REPORTES.Guardias.ReporteIndiciplina(Reporte.Oid));
                    repReporte.ShowPreviewDialog();
                    XtraMessageBox.Show("El reporte se ha creado correctamente.");
                }
                
                
                LimpiarControles();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xfrmNuevoReporte_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
