using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ATRCBASE.BL.Enums;

namespace RUTAS.WIN
{
    public partial class xfrmGenerarRutasExtras : xfrmBase
    {
        public xfrmGenerarRutasExtras()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        XPCollection<RutasFijas> Rutas;
        private void xfrmGenerarRutasExtras_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Rutas = new XPCollection<RutasFijas>(Unidad,0);
            grdRutas.DataSource = Rutas;
            flpAcciones.ShowPopup();
            dteFecha.DateTime = DateTime.Now;
           
        }

        private void flpAcciones_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Rutas por plantilla":
                    xfrmPlantillasRutasExtrasGRD xfrmPlantilla = new xfrmPlantillasRutasExtrasGRD();
                    xfrmPlantilla.AsignarPlantilla = true;
                    xfrmPlantilla.ShowDialog();
                    Loading.ShowWaitForm();
                    PlantillaRutas plantilla = Unidad.GetObjectByKey<PlantillaRutas>(xfrmPlantilla.PlantillaRutas);
                    if (plantilla != null)
                    {
                        XPView PlantillaRutasExtras = new XPView(UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(PlantillaRutaExtra), "Oid;TipoRuta;TipoUnidad;HoraEntrada;HoraSalida;ChoferEntrada;ChoferSalida;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios", new BinaryOperator("PlantillaRutas", plantilla.Oid));
                        foreach (ViewRecord viewRuta in PlantillaRutasExtras)
                        {
                            RutasFijas Ruta = new RutasFijas(Unidad);
                            Ruta.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                            Ruta.TipoUnidad = (TipoUnidad)viewRuta["TipoUnidad"];
                            Ruta.Empresa = plantilla.Empresa;
                            Ruta.HoraEntrada = viewRuta["HoraEntrada"] == null ? null : (DateTime?)viewRuta["HoraEntrada"];
                            Ruta.HoraSalida = viewRuta["HoraSalida"] == null ? null : (DateTime?)viewRuta["HoraSalida"];
                            Ruta.ChoferEntrada = viewRuta["ChoferEntrada"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferEntrada"]));
                            Ruta.ChoferSalida = viewRuta["ChoferSalida"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferSalida"]));
                            Ruta.RutaCompleta = (bool)viewRuta["RutaCompleta"];
                            Ruta.PagarChoferEntrada = (bool)viewRuta["PagarChoferEntrada"];
                            Ruta.PagarChoferSalida = (bool)viewRuta["PagarChoferSalida"];
                            Ruta.Save();
                            Rutas.Add(Ruta);

                        }
                    }
                    Loading.CloseWaitForm();
                    break;

                case "Ruta nueva":
                    xfrmRutasExtras xfrmAgregar = new xfrmRutasExtras();
                    xfrmAgregar.EsPlantilla = false;
                    xfrmAgregar.EsModificacion = false;
                    xfrmAgregar.Unidad = Unidad;
                    xfrmAgregar.ShowDialog();
                    Rutas.Add(xfrmAgregar.RutasFijas);
                   
                    break;

                case "Modificar ruta":
                    RutasFijas RutaExtraModificar = grvRutas.GetFocusedRow() as RutasFijas;
                    if (RutaExtraModificar != null)
                    {
                        xfrmRutasExtras xfrmModificar = new xfrmRutasExtras();
                        xfrmModificar.EsPlantilla = false;
                        xfrmModificar.EsModificacion = true;
                        xfrmModificar.Unidad = Unidad;
                        xfrmModificar.RutasFijas = RutaExtraModificar;
                        xfrmModificar.ShowDialog();
                    }
                    break;

                case "Eliminar ruta":
                    RutasFijas RutaExtra = grvRutas.GetFocusedRow() as RutasFijas;
                    if (RutaExtra != null)
                    {
                        if (XtraMessageBox.Show("¿Está seguro de querer eliminar la ruta seleccionada ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Unidad.Delete(RutaExtra);
                        }
                    }
                    break;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Loading.ShowWaitForm();
                foreach(RutasFijas Ruta in Rutas)
                {
                    Ruta.FechaRuta = dteFecha.DateTime;
                    Ruta.Save();
                }
                Unidad.CommitChanges();
                Loading.CloseWaitForm();
                XtraMessageBox.Show("Se han guardado las rutas extras correctamente.");
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (Rutas.Count <= 0)
            {
                XtraMessageBox.Show("No hay rutas por guardar.");
                return false;
            }
            return true;
        }
    }
}
