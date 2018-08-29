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

        public bool EsConcentrado;
        public string Titulo;
        UnidadDeTrabajo UnidadConsulta;
        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dteDel.DateTime.Date > dteAl.DateTime.Date)
            {
                XtraMessageBox.Show("La primera fecha no debe ser mayor a segunda.");
                return;
            }
            if(rgTipoBusqueda.SelectedIndex == 1 & string.IsNullOrEmpty(btnNumUsuario.Text))
            {
                XtraMessageBox.Show("Debe de ingresar un número de empleado.");
                return;
            }

            if (EsConcentrado)
            {
                ReportPrintTool repHorasTrabajadas = new ReportPrintTool(new CHECADOR.WIN.Reportes.ConcentradoNomina(dteDel.DateTime, dteAl.DateTime));
                //repHorasTrabajadas.PrintDialog();
                repHorasTrabajadas.ShowPreview();
            }
            else
            {
                if (rgTipoBusqueda.SelectedIndex == 0)
                {
                    ReportPrintTool repHorasTrabajadas = new ReportPrintTool(new CHECADOR.WIN.Reportes.HorasSemanalesTrabajadas(0, dteDel.DateTime, dteAl.DateTime));
                    repHorasTrabajadas.ShowPreview();
                }
                else
                {
                    ReportPrintTool repHorasTrabajadas = new ReportPrintTool(new CHECADOR.WIN.Reportes.HorasSemanalesTrabajadas(Convert.ToInt32(btnNumUsuario.Text) , dteDel.DateTime, dteAl.DateTime));
                    repHorasTrabajadas.ShowPreview();
                }
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
            if (EsConcentrado)
            {
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNumUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciTipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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
