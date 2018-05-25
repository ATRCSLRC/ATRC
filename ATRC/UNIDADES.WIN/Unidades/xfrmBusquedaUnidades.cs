﻿using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN
{
    public partial class xfrmBusquedaUnidades : xfrmBase
    {
        public xfrmBusquedaUnidades()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo unidad;
        private void xfrmBusquedaUnidades_Load(object sender, EventArgs e)
        {
            unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Utilerias.CargarLookupEdit(lueUnidad, typeof(Unidad), unidad, "Nombre", "Nombre", false);
        }

        private void lueUnidad_EditValueChanged(object sender, EventArgs e)
        {
            if (lueUnidad.EditValue != null)
            {
                Unidad UnidadCamion = (Unidad)lueUnidad.EditValue;
                List<Unidad> Unidades = new List<Unidad>();
                Unidades.Add(UnidadCamion);
                if (UnidadCamion.Imagen != null)
                {
                    if (!string.IsNullOrEmpty(UnidadCamion.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(UnidadCamion.Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        picFoto.EditValue = stream.ToArray();
                    }
                    else
                        picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                }
                else
                    picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                vGridControl1.DataSource = Unidades;
                fypEdicion.ShowPopup();
            }
            else
            {
                vGridControl1.DataSource = null;
                picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                fypEdicion.HidePopup();
            }
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            if(e.Button.Caption == "Modificar unidad")
            {
                xfrmUnidad xfrm = new xfrmUnidad();
                xfrm.Unidad = unidad;
                xfrm.esModificacion = true;
                xfrm.UnidadCamion = (Unidad)lueUnidad.EditValue;
                xfrm.ShowDialog();
                vGridControl1.Refresh();
                vGridControl1.RefreshDataSource();
            }
            else
            {
                ReportPrintTool repDetalleUnidad = new ReportPrintTool(new REPORTES.Unidades.DetalleDeUnidad(((Unidad)lueUnidad.EditValue).Oid));
                repDetalleUnidad.ShowPreview();
            }
        }
    }
}
