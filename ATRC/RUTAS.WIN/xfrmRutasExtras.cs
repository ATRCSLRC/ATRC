using ATRCBASE.BL;
using ATRCBASE.WIN;
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
    public partial class xfrmRutasExtras : xfrmBase
    {
        public xfrmRutasExtras()
        {
            InitializeComponent();
        }

        public PlantillaRutaExtra PlantillaRutaExtraEditar;
        public PlantillaRutas PlantillaRuta;
        public RutasFijas RutasFijas;
        public UnidadDeTrabajo Unidad;
        public bool EsPlantilla;
        public bool EsModificacion;
        private void xfrmRutasExtras_Load(object sender, EventArgs e)
        {
            IniciarControles();
            if(EsModificacion)
            {
                if (EsPlantilla)
                    Modificacion();
                else
                    ModificacionRuta();
            }
        }

        private void chkRutaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkRutaCompleta.Checked)
            {
                lciChoferSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciSePagaSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }else
            {
                lciChoferSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciSePagaSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarControles())
            {
                if (EsPlantilla)
                    Guardar();
                else
                    GuardarRuta();
                XtraMessageBox.Show("Se agregó la ruta correctamente.");
                this.Close();
            }
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de querer salir? Podría perder sus cambios.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool ValidarControles()
        {
            if (cmbTipoRuta.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un tipo de ruta.");
                cmbTipoRuta.Focus();
                return false;
            }

            if (cmbTipoUnidad.EditValue == null)
            {
                XtraMessageBox.Show("Debe seleccionar un tipo de unidad.");
                cmbTipoUnidad.Focus();
                return false;
            }

            if (timeA.EditValue == null & timeDe.EditValue == null)
            {
                XtraMessageBox.Show("Debe agregar un horario.");
                return false;
            }

            if (!EsPlantilla)
            {
                if (lueMaquiladora.EditValue == null)
                {
                    XtraMessageBox.Show("Debe seleccionar una maquiladora.");
                    lueMaquiladora.Focus();
                    return false;
                }
            }

            if ((TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Entrada || (TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Normal) 
            {
                if (lueChofer.EditValue == null)
                {
                    XtraMessageBox.Show("Debe seleccionar un chofer.");
                    lueChofer.Focus();
                    return false;
                }
            }

            if ((TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Salida)
            {
                if (lueChoferSalida.EditValue == null)
                {
                    XtraMessageBox.Show("Debe seleccionar un chofer.");
                    lueChoferSalida.Focus();
                    return false;
                }
            }

            return true;
        }

        private void Modificacion()
        {
            cmbTipoRuta.EditValue = PlantillaRutaExtraEditar.TipoRuta;
            cmbTipoUnidad.EditValue = PlantillaRutaExtraEditar.TipoUnidad;
            timeDe.EditValue = PlantillaRutaExtraEditar.HoraEntrada;
            timeA.EditValue = PlantillaRutaExtraEditar.HoraSalida;
            chkRutaCompleta.EditValue = PlantillaRutaExtraEditar.RutaCompleta;
            lueChofer.EditValue = PlantillaRutaExtraEditar.ChoferEntrada == null ? -1 : PlantillaRutaExtraEditar.ChoferEntrada.Oid;
            lueChoferSalida.EditValue = PlantillaRutaExtraEditar.ChoferSalida == null ? -1 : PlantillaRutaExtraEditar.ChoferSalida.Oid;
            chkSePagaChofer.EditValue = PlantillaRutaExtraEditar.PagarChoferEntrada;
            chkSePagaChoferSalida.EditValue = PlantillaRutaExtraEditar.PagarChoferSalida;
            //memoObservacion.Text = PlantillaRutaExtraEditar.Comentarios;
        }

        private void ModificacionRuta()
        {
            cmbTipoRuta.EditValue = RutasFijas.TipoRuta;
            //cmbTipoUnidad.EditValue = RutasFijas.TipoUnidad;
            timeDe.EditValue = RutasFijas.HoraEntrada;
            timeA.EditValue = RutasFijas.HoraSalida;
            chkRutaCompleta.EditValue = RutasFijas.RutaCompleta;
            lueChofer.EditValue = RutasFijas.ChoferEntrada == null ? -1 : RutasFijas.ChoferEntrada.Oid;
            lueChoferSalida.EditValue = RutasFijas.ChoferSalida == null ? -1 : RutasFijas.ChoferSalida.Oid;
            chkSePagaChofer.EditValue = RutasFijas.PagarChoferEntrada;
            chkSePagaChoferSalida.EditValue = RutasFijas.PagarChoferSalida;
            //memoObservacion.Text = RutasFijas.Comentarios;
        }

        private void IniciarControles()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            if (EsPlantilla)
            {
                lciMaquiladora.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }else
            {
                XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Nombre", null);
                lueMaquiladora.Properties.DataSource = Empresas;
            }
                
            timeA.EditValue = timeDe.EditValue = null;
            cmbTipoRuta.Properties.Items.AddRange(typeof(Enums.TipoRuta).GetEnumValues());
            cmbTipoUnidad.Properties.Items.AddRange(typeof(Enums.TipoUnidad).GetEnumValues());
            XPView Usuarios = new XPView(Unidad, typeof(Usuario));
            Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "Concat(ToStr([NumEmpleado]), ' - ', [Nombre])", false, true)
                 });
            lueChofer.Properties.DataSource = lueChoferSalida.Properties.DataSource = Usuarios;
        }

        private void Guardar()
        {
            PlantillaRutaExtra PlantillaRutaExtra;
            if (EsModificacion)
                PlantillaRutaExtra = PlantillaRutaExtraEditar;
            else
                PlantillaRutaExtra = new PlantillaRutaExtra(PlantillaRuta.Session);
            PlantillaRutaExtra.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            PlantillaRutaExtra.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
            if (timeDe.EditValue == null)
                PlantillaRutaExtra.HoraEntrada = null;
            else
                PlantillaRutaExtra.HoraEntrada = timeDe.Time;

            if (timeA.EditValue == null)
                PlantillaRutaExtra.HoraSalida = null;
            else
                PlantillaRutaExtra.HoraSalida = timeA.Time;
            PlantillaRutaExtra.RutaCompleta = chkRutaCompleta.Checked;
            PlantillaRutaExtra.ChoferEntrada = PlantillaRutaExtra.Session.GetObjectByKey<Usuario>(lueChofer.EditValue);
            PlantillaRutaExtra.PagarChoferEntrada = chkSePagaChofer.Checked;
            if(!PlantillaRutaExtra.RutaCompleta || PlantillaRutaExtra.TipoRuta == Enums.TipoRuta.Salida)
            {
                PlantillaRutaExtra.ChoferSalida = PlantillaRutaExtra.Session.GetObjectByKey<Usuario>(lueChoferSalida.EditValue);
                PlantillaRutaExtra.PagarChoferSalida = chkSePagaChoferSalida.Checked;
            }
            if (PlantillaRutaExtra.RutaCompleta & PlantillaRutaExtra.TipoRuta != Enums.TipoRuta.Salida)
            {
                PlantillaRutaExtra.ChoferSalida = PlantillaRutaExtra.ChoferEntrada;
                PlantillaRutaExtra.PagarChoferSalida = PlantillaRutaExtra.PagarChoferEntrada ? true : false;
            }
            //PlantillaRutaExtra.Comentarios = memoObservacion.Text;
            PlantillaRutaExtra.Save();
            if (!EsModificacion)
                PlantillaRuta.PlantillasRutasExtras.Add(PlantillaRutaExtra);

        }

        private void GuardarRuta()
        {
            RutasFijas RutasFijasModificar;
            if (EsModificacion)
                RutasFijasModificar = RutasFijas;
            else
                RutasFijasModificar = new RutasFijas(Unidad);
            RutasFijasModificar.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            //RutasFijasModificar.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
            if (timeDe.EditValue == null)
                RutasFijasModificar.HoraEntrada = null;
            else
                RutasFijasModificar.HoraEntrada = timeDe.Time;

            if (timeA.EditValue == null)
                RutasFijasModificar.HoraSalida = null;
            else
                RutasFijasModificar.HoraSalida = timeA.Time;
            RutasFijasModificar.Empresa = RutasFijasModificar.Session.GetObjectByKey<Empresas>(lueMaquiladora.EditValue);
            RutasFijasModificar.RutaCompleta = chkRutaCompleta.Checked;
            RutasFijasModificar.ChoferEntrada = RutasFijasModificar.Session.GetObjectByKey<Usuario>(lueChofer.EditValue);
            RutasFijasModificar.PagarChoferEntrada = chkSePagaChofer.Checked;
            if (!RutasFijasModificar.RutaCompleta || RutasFijasModificar.TipoRuta == Enums.TipoRuta.Salida)
            {
                RutasFijasModificar.ChoferSalida = RutasFijasModificar.Session.GetObjectByKey<Usuario>(lueChoferSalida.EditValue);
                RutasFijasModificar.PagarChoferSalida = chkSePagaChoferSalida.Checked;
            }
            if (RutasFijasModificar.RutaCompleta & RutasFijasModificar.TipoRuta != Enums.TipoRuta.Salida)
            {
                RutasFijasModificar.ChoferSalida = RutasFijasModificar.ChoferEntrada;
                RutasFijasModificar.PagarChoferSalida = RutasFijasModificar.PagarChoferEntrada ? true : false;
            }
            //RutasFijasModificar.Comentarios = memoObservacion.Text;
            RutasFijasModificar.Save();
            RutasFijas = RutasFijasModificar;
        }

        private void cmbTipoRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums.TipoRuta)cmbTipoRuta.EditValue)
            {
                case Enums.TipoRuta.Entrada:
                    timeA.ReadOnly = true;
                    timeA.EditValue = null;
                    timeDe.ReadOnly = false;
                    lueChoferSalida.EditValue = null;
                    chkRutaCompleta.Checked = true;
                    chkRutaCompleta.ReadOnly = true;
                    lciChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciSePaga.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciChoferSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciSePagaSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case Enums.TipoRuta.Salida:
                    timeDe.ReadOnly = true;
                    timeDe.EditValue = null;
                    timeA.ReadOnly = false;
                    lueChofer.EditValue = null;
                    chkRutaCompleta.Checked = true;
                    chkRutaCompleta.ReadOnly = true;
                    lciChoferSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciSePagaSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciSePaga.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                default:
                    timeA.ReadOnly = timeDe.ReadOnly = false;
                    chkRutaCompleta.Checked = true;
                    chkRutaCompleta.ReadOnly = false;
                    lciChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciSePaga.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciChoferSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciSePagaSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
            }

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
