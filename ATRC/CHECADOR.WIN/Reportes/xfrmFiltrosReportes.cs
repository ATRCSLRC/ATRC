using ATRCBASE.BL;
using ATRCBASE.WIN;
using CHECADOR.BL;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECADOR.WIN
{
    public partial class xfrmFiltrosReportes : xfrmBase
    {
        public xfrmFiltrosReportes()
        {
            InitializeComponent();
        }

        public bool Todos;
        public string Titulo;
        UnidadDeTrabajo UnidadConsulta;
        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Titulo != "Rutas fijas" & Titulo != "Rutas extras")
            {
                if (dteDel.DateTime.Date > dteAl.DateTime.Date)
                {
                    XtraMessageBox.Show("La primera fecha no debe ser mayor a segunda.");
                    return;
                }
                if (rgTipoBusqueda.SelectedIndex == 1 & string.IsNullOrEmpty(btnNumUsuario.Text))
                {
                    XtraMessageBox.Show("Debe de ingresar un número de empleado.");
                    return;
                }
            }

            if(Titulo == "Rutas del usuario" & string.IsNullOrEmpty(btnNumUsuario.Text))
            {
                XtraMessageBox.Show("Debe de ingresar un número de empleado.");
                return;
            }

            switch(Titulo)
            {
                case "Concentrado de nómina":
                    ReportPrintTool repHorasTrabajadas = new ReportPrintTool(new CHECADOR.WIN.Reportes.ConcentradoNomina(dteDel.DateTime, dteAl.DateTime));
                    repHorasTrabajadas.ShowPreview();
                    break;
                case "Horas trabajadas semanales":
                    if (rgTipoBusqueda.SelectedIndex == 0)
                    {
                        ReportPrintTool repHorasTrabajadasTodo = new ReportPrintTool(new CHECADOR.WIN.Reportes.HorasSemanalesTrabajadas(0, dteDel.DateTime, dteAl.DateTime));
                        repHorasTrabajadasTodo.ShowPreview();
                    }
                    else
                    {
                        ReportPrintTool repHorasTrabajadasUsuario = new ReportPrintTool(new CHECADOR.WIN.Reportes.HorasSemanalesTrabajadas(Convert.ToInt32(btnNumUsuario.Text), dteDel.DateTime, dteAl.DateTime));
                        repHorasTrabajadasUsuario.ShowPreview();
                    }
                    break;
                case "Total horas trabajadas semanales":
                    ReportPrintTool repTotalHoras = new ReportPrintTool(new REPORTES.Usuarios.Usuarios(dteDel.DateTime, dteAl.DateTime, Todos));
                    repTotalHoras.ShowPreview();
                    break;
                case "Rutas fijas":
                    ReportPrintTool repRutasFijas = new ReportPrintTool(new REPORTES.Rutas.ReporteRutasFijas(dteDel.DateTime.Date));
                    repRutasFijas.ShowPreview();
                    break;
                case "Rutas extras":
                    ReportPrintTool repRutasExtras = new ReportPrintTool(new REPORTES.Rutas.ReporteRutasExtras(dteDel.DateTime.Date));
                    repRutasExtras.ShowPreview();
                    break;
                case "Rutas a pagar por usuario":
                    string atrc = "AutoTransportes del Río Colorado S.A. de C.V.";
                    string green = "Servicios Administrativos Greenwood SAG S DE RL DE CV";
                    REPORTES.Rutas.RutasFijasUsuario repRutasOperGreen = new REPORTES.Rutas.RutasFijasUsuario(dteDel.DateTime.Date, dteAl.DateTime.Date, green, false);
                    repRutasOperGreen.CreateDocument();

                    REPORTES.Rutas.RutasFijasUsuario repRutasAdimGreen = new REPORTES.Rutas.RutasFijasUsuario(dteDel.DateTime.Date, dteAl.DateTime.Date, green, true);
                    repRutasAdimGreen.CreateDocument();
                    repRutasOperGreen.Pages.AddRange(repRutasAdimGreen.Pages);

                    REPORTES.Rutas.RutasFijasUsuario repRutasOperAtrc = new REPORTES.Rutas.RutasFijasUsuario(dteDel.DateTime.Date, dteAl.DateTime.Date, atrc, false);
                    repRutasOperAtrc.CreateDocument();
                    repRutasOperGreen.Pages.AddRange(repRutasOperAtrc.Pages);

                    REPORTES.Rutas.RutasFijasUsuario repRutasAdimAtrc = new REPORTES.Rutas.RutasFijasUsuario(dteDel.DateTime.Date, dteAl.DateTime.Date, atrc, true);
                    repRutasAdimAtrc.CreateDocument();
                    repRutasOperGreen.Pages.AddRange(repRutasAdimAtrc.Pages);
                    
                    
                    ReportPrintTool Rutas = new ReportPrintTool(repRutasOperGreen);
                    Rutas.ShowPreview();
                    break;
                case "Rutas del usuario":
                    ReportPrintTool repRutasDelUsuario = new ReportPrintTool(new REPORTES.Rutas.RutasPorUsuario(dteDel.DateTime.Date, dteAl.DateTime.Date, Convert.ToInt32(btnNumUsuario.Text)));
                    repRutasDelUsuario.ShowPreview();
                    break;
            }
            
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xfrmFiltrosReportes_Load(object sender, EventArgs e)
        {
            UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            this.Text = Titulo;
            dteDel.DateTime = dteAl.DateTime = DateTime.Now;
            if (Titulo != "Horas trabajadas semanales")
            {
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if(Titulo == "Rutas fijas" || Titulo == "Rutas extras")
            {
                lciHasta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            if(Titulo == "Rutas del usuario")
            {
                lciNumUsuario.Visibility = lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void rgTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgTipoBusqueda.SelectedIndex == 0)
            {
                btnNumUsuario.Text = string.Empty;
                txtNombre.Text = string.Empty;
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void btnNumUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(btnNumUsuario.Text))
                {
                    UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(btnNumUsuario.Text));
                    if (Usuario != null)
                    {
                        if (Usuario.Usuario != null)
                            txtNombre.Text = Usuario.Usuario.Nombre;
                    }
                    else
                    {
                        XtraMessageBox.Show("El usuario no se encuentra registrado.");
                        txtNombre.Text = string.Empty;
                    }
                }
                else
                {
                    txtNombre.Text = string.Empty;
                }
            }
        }

        private void btnNumUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnNumUsuario.Text))
            {
                UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, Convert.ToInt32(btnNumUsuario.Text));
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                        txtNombre.Text = Usuario.Usuario.Nombre;
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = string.Empty;
                }
            }
            else
            {
                txtNombre.Text = string.Empty;
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ATRCBASE.WIN.xfrmUsuariosGRD xfrm = new ATRCBASE.WIN.xfrmUsuariosGRD();
            xfrm.Unidad = UnidadConsulta;
            xfrm.ShowInTaskbar = false;
            xfrm.ShowDialog();
            if (xfrm.IDUsuario > 0)
            {
                UsuarioChecador Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UnidadConsulta, xfrm.IDUsuario);
                if (Usuario != null)
                {
                    if (Usuario.Usuario != null)
                    {
                        txtNombre.Text = Usuario.Usuario.Nombre;
                        btnNumUsuario.Text = Usuario.Usuario.NumEmpleado.ToString();
                    }
                }
                else
                {
                    XtraMessageBox.Show("El usuario no se encuentra registrado.");
                    txtNombre.Text = btnNumUsuario.Text = string.Empty;
                }
            }
            else
            {
                txtNombre.Text = btnNumUsuario.Text = string.Empty;
            }
        }
    }
}
