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
    public partial class xfrmRutasFijas : xfrmBase
    {
        public xfrmRutasFijas()
        {
            InitializeComponent();
        }

        public PlantillaRutaFija PlantillaRutaExtraEditar;
        public PlantillaRutas PlantillaRuta;
        public RutasGeneradas RutasFijas;
        public UnidadDeTrabajo Unidad;
        public Empresas Empresa;
        public DateTime FechaRuta;
        public bool EsPlantilla;
        public bool EsModificacion;
        private void xfrmRutasExtras_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() => { txtRuta.Focus(); }));
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
            if (!EsPlantilla)
            {
                DisponibilidadEmpledo();
            }

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
            //if (cmbTipoRuta.EditValue == null)
            //{
            //    XtraMessageBox.Show("Debe seleccionar un tipo de ruta.");
            //    cmbTipoRuta.Focus();
            //    return false;
            //}

            //if (cmbTipoUnidad.EditValue == null)
            //{
            //    XtraMessageBox.Show("Debe seleccionar un tipo de unidad.");
            //    cmbTipoUnidad.Focus();
            //    return false;
            //}

            if (timeA.EditValue == null & timeDe.EditValue == null)
            {
                XtraMessageBox.Show("Debe agregar un horario.");
                return false;
            }


            //if ((TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Entrada || (TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Normal) 
            //{
            //    if (lueChofer.EditValue == null)
            //    {
            //        XtraMessageBox.Show("Debe seleccionar un chofer.");
            //        lueChofer.Focus();
            //        return false;
            //    }
            //}

            //if ((TipoRuta)cmbTipoRuta.EditValue == TipoRuta.Salida)
            //{
            //    if (lueChoferSalida.EditValue == null)
            //    {
            //        XtraMessageBox.Show("Debe seleccionar un chofer.");
            //        lueChoferSalida.Focus();
            //        return false;
            //    }
            //}

            return true;
        }

        private void Modificacion()
        {
            txtRuta.Text = PlantillaRutaExtraEditar.Ruta;
            cmbTipoRuta.EditValue = PlantillaRutaExtraEditar.TipoRuta;
            chkEsRutaExtra.Checked = PlantillaRutaExtraEditar.EsRutaExtra;
            //cmbTipoUnidad.EditValue = PlantillaRutaExtraEditar.TipoUnidad;
            timeDe.EditValue = PlantillaRutaExtraEditar.HoraEntrada;
            timeA.EditValue = PlantillaRutaExtraEditar.HoraSalida;
            chkRutaCompleta.EditValue = PlantillaRutaExtraEditar.RutaCompleta;
            lueChofer.EditValue = PlantillaRutaExtraEditar.ChoferEntrada == null ? -1 : PlantillaRutaExtraEditar.ChoferEntrada.Oid;
            lueChoferSalida.EditValue = PlantillaRutaExtraEditar.ChoferSalida == null ? -1 : PlantillaRutaExtraEditar.ChoferSalida.Oid;
            chkSePagaChofer.EditValue = PlantillaRutaExtraEditar.PagarChoferEntrada;
            chkSePagaChoferSalida.EditValue = PlantillaRutaExtraEditar.PagarChoferSalida;
            memoComentarios.Text = PlantillaRutaExtraEditar.Comentarios;
            memoComentarioFacturacion.Text = PlantillaRutaExtraEditar.ComentariosFacturacion;
            lueTurno.EditValue = PlantillaRutaExtraEditar.Turno == null ? -1 : PlantillaRutaExtraEditar.Turno.Oid;
            lueServicio.EditValue = PlantillaRutaExtraEditar.Servicio == null ? -1 : PlantillaRutaExtraEditar.Servicio.Oid;
        }

        private void ModificacionRuta()
        {
            txtRuta.Text = RutasFijas.Ruta;
            chkEsRutaExtra.Checked = RutasFijas.EsRutaExtra;
            lueServicio.EditValue = RutasFijas.Servicio == null ? -1 : RutasFijas.Servicio.Oid;
            cmbTipoRuta.EditValue = RutasFijas.TipoRuta;
            //cmbTipoUnidad.EditValue = RutasFijas.TipoUnidad;
            timeDe.EditValue = RutasFijas.HoraEntrada;
            timeA.EditValue = RutasFijas.HoraSalida;
            chkRutaCompleta.EditValue = RutasFijas.RutaCompleta;
            lueChofer.EditValue = RutasFijas.ChoferEntrada == null ? -1 : RutasFijas.ChoferEntrada.Oid;
            lueChoferSalida.EditValue = RutasFijas.ChoferSalida == null ? -1 : RutasFijas.ChoferSalida.Oid;
            chkSePagaChofer.EditValue = RutasFijas.PagarChoferEntrada;
            chkSePagaChoferSalida.EditValue = RutasFijas.PagarChoferSalida;
            memoComentarios.Text = RutasFijas.Comentarios;
            memoComentarioFacturacion.Text = RutasFijas.ComentariosFacturacion;
            lueTurno.EditValue = RutasFijas.Turno == null ? -1 : RutasFijas.Turno.Oid;
            
        }

        private void IniciarControles()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            
                
            timeA.EditValue = timeDe.EditValue = null;
            
            //cmbTipoUnidad.Properties.Items.AddRange(typeof(Enums.TipoUnidad).GetEnumValues());  
            XPView Usuarios = new XPView(Unidad, typeof(Usuario));
            Usuarios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("NomCompleto", SortDirection.None, "[Nombre]", false, true)
                 });
            Usuarios.Criteria = new BinaryOperator("Activo", true);

            XPView Servicios = new XPView(Unidad, typeof(Servicio));
            Servicios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Clave", SortDirection.None, "[Clave]", false, true),
                  new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", false, true),
                  new ViewProperty("EsMediaVuelta", SortDirection.None, "[EsMediaVuelta]", false, true)
                 });

            XPView Turnos = new XPView(Unidad, typeof(BL.Turno));
            Turnos.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", false, true)
                 });
            lueServicio.Properties.DataSource = Servicios;
            lueTurno.Properties.DataSource = Turnos;
            lueChofer.Properties.DataSource = lueChoferSalida.Properties.DataSource = Usuarios;
        }

        private void Guardar()
        {
            PlantillaRutaFija PlantillaRutaExtra;
            if (EsModificacion)
                PlantillaRutaExtra = PlantillaRutaExtraEditar;
            else
                PlantillaRutaExtra = new PlantillaRutaFija(PlantillaRuta.Session);
            PlantillaRutaExtra.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            PlantillaRutaExtra.Ruta = txtRuta.Text;
            PlantillaRutaExtra.Servicio = PlantillaRutaExtra.Session.GetObjectByKey<Servicio>(lueServicio.EditValue);
            PlantillaRutaExtra.Turno = PlantillaRutaExtra.Session.GetObjectByKey<BL.Turno>(lueTurno.EditValue);
            PlantillaRutaExtra.EsRutaExtra = chkEsRutaExtra.Checked;
            //PlantillaRutaExtra.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
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
            if (PlantillaRutaExtra.RutaCompleta & PlantillaRutaExtra.TipoRuta == Enums.TipoRuta.Normal)
            {
                PlantillaRutaExtra.ChoferSalida = PlantillaRutaExtra.ChoferEntrada;
                PlantillaRutaExtra.PagarChoferSalida = PlantillaRutaExtra.PagarChoferEntrada ? true : false;
            }
            PlantillaRutaExtra.Comentarios = memoComentarios.Text;
            PlantillaRutaExtra.ComentariosFacturacion = memoComentarioFacturacion.Text;
            PlantillaRutaExtra.Save();
            if (!EsModificacion)
                PlantillaRuta.PlantillasRutasFijas.Add(PlantillaRutaExtra);

        }

        private void GuardarRuta()
        {
            RutasGeneradas RutasFijasModificar;
            if (EsModificacion)
                RutasFijasModificar = RutasFijas;
            else
                RutasFijasModificar = new RutasGeneradas(Unidad);
            RutasFijasModificar.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            RutasFijasModificar.Ruta = txtRuta.Text;
            RutasFijasModificar.FechaRuta = FechaRuta;
            RutasFijasModificar.Servicio = RutasFijasModificar.Session.GetObjectByKey<Servicio>(lueServicio.EditValue);
            RutasFijasModificar.Turno = RutasFijasModificar.Session.GetObjectByKey<BL.Turno>(lueTurno.EditValue);
            RutasFijasModificar.EsRutaExtra = chkEsRutaExtra.Checked;
            //RutasFijasModificar.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
            if (timeDe.EditValue == null)
                RutasFijasModificar.HoraEntrada = null;
            else
                RutasFijasModificar.HoraEntrada = timeDe.Time;

            if (timeA.EditValue == null)
                RutasFijasModificar.HoraSalida = null;
            else
                RutasFijasModificar.HoraSalida = timeA.Time;
            RutasFijasModificar.Empresa = Empresa;//RutasFijasModificar.Session.GetObjectByKey<Empresas>(lueMaquiladora.EditValue);
            RutasFijasModificar.RutaCompleta = chkRutaCompleta.Checked;
            RutasFijasModificar.ChoferEntrada = RutasFijasModificar.Session.GetObjectByKey<Usuario>(lueChofer.EditValue);
            RutasFijasModificar.PagarChoferEntrada = chkSePagaChofer.Checked;
            if (!RutasFijasModificar.RutaCompleta || RutasFijasModificar.TipoRuta == Enums.TipoRuta.Salida)
            {
                RutasFijasModificar.ChoferSalida = RutasFijasModificar.Session.GetObjectByKey<Usuario>(lueChoferSalida.EditValue);
                RutasFijasModificar.PagarChoferSalida = chkSePagaChoferSalida.Checked;
            }
            if (RutasFijasModificar.RutaCompleta & RutasFijasModificar.TipoRuta == Enums.TipoRuta.Normal)
            {
                RutasFijasModificar.ChoferSalida = RutasFijasModificar.ChoferEntrada;
                RutasFijasModificar.PagarChoferSalida = RutasFijasModificar.PagarChoferEntrada ? true : false;
            }
            RutasFijasModificar.Comentarios = memoComentarios.Text;
            RutasFijasModificar.ComentariosFacturacion = memoComentarioFacturacion.Text;
            RutasFijasModificar.Save();
            RutasFijas = RutasFijasModificar;

            #region Historial
            HistorialRutaGenerada HistorialRutaGenerada = new HistorialRutaGenerada(RutasFijasModificar.Session);
            HistorialRutaGenerada.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            HistorialRutaGenerada.Ruta = txtRuta.Text;
            HistorialRutaGenerada.FechaRuta = FechaRuta;
            HistorialRutaGenerada.Servicio = HistorialRutaGenerada.Session.GetObjectByKey<Servicio>(lueServicio.EditValue);
            HistorialRutaGenerada.Turno = HistorialRutaGenerada.Session.GetObjectByKey<BL.Turno>(lueTurno.EditValue);
            HistorialRutaGenerada.EsRutaExtra = chkEsRutaExtra.Checked;
            //HistorialRutaGenerada.TipoUnidad = (Enums.TipoUnidad)cmbTipoUnidad.EditValue;
            if (timeDe.EditValue == null)
                HistorialRutaGenerada.HoraEntrada = null;
            else
                HistorialRutaGenerada.HoraEntrada = timeDe.Time;

            if (timeA.EditValue == null)
                HistorialRutaGenerada.HoraSalida = null;
            else
                HistorialRutaGenerada.HoraSalida = timeA.Time;
            HistorialRutaGenerada.RutaCompleta = chkRutaCompleta.Checked;
            HistorialRutaGenerada.ChoferEntrada = HistorialRutaGenerada.Session.GetObjectByKey<Usuario>(lueChofer.EditValue);
            HistorialRutaGenerada.PagarChoferEntrada = chkSePagaChofer.Checked;
            if (!HistorialRutaGenerada.RutaCompleta || HistorialRutaGenerada.TipoRuta == Enums.TipoRuta.Salida)
            {
                HistorialRutaGenerada.ChoferSalida = HistorialRutaGenerada.Session.GetObjectByKey<Usuario>(lueChoferSalida.EditValue);
                HistorialRutaGenerada.PagarChoferSalida = chkSePagaChoferSalida.Checked;
            }
            if (HistorialRutaGenerada.RutaCompleta & HistorialRutaGenerada.TipoRuta == Enums.TipoRuta.Normal)
            {
                HistorialRutaGenerada.ChoferSalida = HistorialRutaGenerada.ChoferEntrada;
                HistorialRutaGenerada.PagarChoferSalida = HistorialRutaGenerada.PagarChoferEntrada ? true : false;
            }
            HistorialRutaGenerada.Comentarios = memoComentarios.Text;
            HistorialRutaGenerada.ComentariosFacturacion = memoComentarioFacturacion.Text;
            HistorialRutaGenerada.UsuarioModificacion = ATRCBASE.BL.Utilerias.ObtenerUsuarioActual((UnidadDeTrabajo)RutasFijasModificar.Session);
            HistorialRutaGenerada.HorarioModificacion = DateTime.Now;
            HistorialRutaGenerada.Save();
            RutasFijas.Historial.Add(HistorialRutaGenerada);
            #endregion

            RutasFijasModificar.Session.CommitTransaction();
        }

        private void DisponibilidadEmpledo()
        {
            string Mensaje = string.Empty;
            if(chkRutaCompleta.Checked)
            {
                Mensaje = RutasDelEmpleado(lueChofer);
                if (!string.IsNullOrEmpty(Mensaje))
                {
                    XtraMessageBox.Show(Mensaje);
                }
            }
            else
            {

                Mensaje = RutasDelEmpleado(lueChofer);
                Mensaje += RutasDelEmpleado(lueChoferSalida);
                if (!string.IsNullOrEmpty(Mensaje))
                {
                    XtraMessageBox.Show(Mensaje);
                }
            }
        }

        private string RutasDelEmpleado(LookUpEdit Control)
        {
            UnidadDeTrabajo UnidadConsulta = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            goMain.Operands.Add(new BinaryOperator("FechaRuta", FechaRuta));
            if(RutasFijas != null)
                goMain.Operands.Add(new BinaryOperator("Oid", RutasFijas.Oid, BinaryOperatorType.NotEqual));
            GroupOperator goFechas = new GroupOperator(GroupOperatorType.Or);
            DateTime HoraEntradaAnterior = timeDe.Time;
            DateTime HoraEntradaSuperior = timeDe.Time;
            DateTime HoraSalidaAnterior = timeA.Time;
            DateTime HoraSalidaSuperior = timeA.Time;

            switch ((Enums.TipoRuta)cmbTipoRuta.EditValue)
            {
                case Enums.TipoRuta.Entrada:
                    goFechas.Operands.Add(new BetweenOperator("HoraEntrada", HoraEntradaAnterior.AddMinutes(-15), HoraEntradaSuperior.AddMinutes(15)));
                    goFechas.Operands.Add(new BetweenOperator("HoraSalida", HoraEntradaAnterior, HoraEntradaSuperior));
                    break;
                case Enums.TipoRuta.Salida:
                    goFechas.Operands.Add(new BetweenOperator("HoraEntrada", HoraSalidaAnterior.AddMinutes(-15), HoraSalidaSuperior.AddMinutes(15)));
                    goFechas.Operands.Add(new BetweenOperator("HoraSalida", HoraSalidaAnterior, HoraSalidaSuperior));
                    break;
                case Enums.TipoRuta.Normal:
                    goFechas.Operands.Add(new BetweenOperator("HoraEntrada", HoraSalidaAnterior.AddMinutes(-15), HoraSalidaSuperior.AddMinutes(15)));
                    goFechas.Operands.Add(new BetweenOperator("HoraSalida", HoraSalidaAnterior, HoraSalidaSuperior));
                    goFechas.Operands.Add(new BetweenOperator("HoraEntrada", HoraEntradaAnterior.AddMinutes(-15), HoraEntradaSuperior.AddMinutes(15)));
                    goFechas.Operands.Add(new BetweenOperator("HoraSalida", HoraEntradaAnterior, HoraEntradaSuperior));
                    break;
            }
                        
            GroupOperator goChofer = new GroupOperator(GroupOperatorType.Or);
            goChofer.Operands.Add(new BinaryOperator("ChoferEntrada", Control.EditValue));
            goChofer.Operands.Add(new BinaryOperator("ChoferSalida", Control.EditValue));

            goMain.Operands.Add(goFechas);
            goMain.Operands.Add(goChofer);
            XPView RutasGeneradas = new XPView(UnidadConsulta, typeof(RutasGeneradas), "Oid;Ruta;Empresa.Nombre;HoraEntrada;HoraSalida", goMain);
            if (RutasGeneradas.Count <= 0)
            {
                return string.Empty;
            }
            else if(RutasGeneradas.Count == 1)
            {
                return "El chofer " + Control.Text + " tiene otra ruta en el mismo horario: " + RutasGeneradas[0]["Ruta"] + " de la maquiladora " + RutasGeneradas[0]["Empresa.Nombre"] + ".";
            }
            else
            {
                return "El chofer " + Control.Text + " tiene " + RutasGeneradas.Count + "en el mismo horario.";
            }
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

        private void lueServicio_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void lueServicio_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                //DataRow row = lue.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Clave"] + " - " + row["Descripcion"];
            }
        }

        private void lueServicio_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {

                cmbTipoRuta.Properties.Items.Clear();
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                if(Convert.ToBoolean(row["EsMediaVuelta"]))
                {
                    cmbTipoRuta.Properties.Items.Add(Enums.TipoRuta.Entrada);
                    cmbTipoRuta.Properties.Items.Add(Enums.TipoRuta.Salida);
                }
                else
                {
                    cmbTipoRuta.Properties.Items.Add(Enums.TipoRuta.Normal);
                }
                cmbTipoRuta.SelectedIndex = 0;
                    
            }
        }
    }
}
