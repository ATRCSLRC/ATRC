using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace REPORTES.Unidades
{
    public partial class DatosCambioAceite : DevExpress.XtraReports.UI.XtraReport
    {
        public DatosCambioAceite(UNIDADES.BL.Servicios Servicio)
        {
            InitializeComponent();
            lblFecha.Text = Servicio.Fecha.ToShortDateString();
            lblUnidad.Text = Servicio.Unidad.Nombre;
            if(Servicio.Unidad.TipoUnidad == ATRCBASE.BL.Enums.TipoUnidad.Automovil || Servicio.Unidad.TipoUnidad == ATRCBASE.BL.Enums.TipoUnidad.Panel
                || Servicio.Unidad.TipoUnidad == ATRCBASE.BL.Enums.TipoUnidad.Micro & Servicio.Unidad.Combustible == ATRCBASE.BL.Enums.Combustible.Gasolina)
            {
                lblFechaPro.Text = Servicio.Fecha.AddMonths(3).ToShortDateString();
                lblMillas.Text = (Convert.ToInt32(Servicio.Millas) + 5000).ToString();
            }else
            {
                lblFechaPro.Text = Servicio.Fecha.AddMonths(6).ToShortDateString();
                lblMillas.Visible = lblMillasTitulo.Visible = false;
            }
        }

    }
}
