using ATRCBASE.WIN;
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
using static ATRCBASE.BL.Enums;

namespace UNIDADES.WIN.Reportes
{
    public partial class xfrmServicios : xfrmBase
    {
        public xfrmServicios()
        {
            InitializeComponent();
        }

        private void xfrmServicios_Load(object sender, EventArgs e)
        {
            dteDel.DateTime = dteAl.DateTime = DateTime.Now;
            rgServicios.SelectedIndex = 0;
        }

        private void bbiImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dteDel.DateTime.Date > dteAl.DateTime.Date)
            {
                XtraMessageBox.Show("La primera fecha no debe ser mayor a segunda.");
                return;
            }
            bool SonTodos = false;
            ServiciosUnidad Servicio = ServiciosUnidad.Compostura;
            switch(Convert.ToInt32(rgServicios.EditValue))
            {
                case 0:
                    Servicio = ServiciosUnidad.Compostura;
                    break;
                case 1:
                    Servicio = ServiciosUnidad.CambioAceite;
                    break;
                case 2:
                    Servicio = ServiciosUnidad.Lavado;
                    break;
                case 3:
                    Servicio = ServiciosUnidad.Otro;
                    break;
                case 4:
                    SonTodos = true;
                    break;
            }

            ReportPrintTool repHorasTrabajadas = new ReportPrintTool(new REPORTES.Unidades.Servicios(dteDel.DateTime, dteAl.DateTime, Servicio, SonTodos));
            repHorasTrabajadas.ShowPreview();
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
