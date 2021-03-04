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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUTAS.WIN.PedidoRutas
{
    public partial class xfrmRutaDePedido : xfrmBase
    {
        public xfrmRutaDePedido()
        {
            InitializeComponent();
        }

        public UnidadDeTrabajo UnidadRuta;
        public xfrmNuevaAclaracion.Rutas RutaActualizar;
        RutasDePedido Ruta;

        private void xfrmRutaDePedido_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Ruta = Unidad.GetObjectByKey<RutasDePedido>(RutaActualizar.Oid);
            BeginInvoke(new MethodInvoker(() => { txtRuta.Focus(); }));
            IniciarControles();
            ModificacionRuta();
        }

        private void lueServicio_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {

                cmbTipoRuta.Properties.Items.Clear();
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                if (Convert.ToBoolean(row["EsMediaVuelta"]))
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

        private void lueServicio_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                e.DisplayText = row["Clave"] + " - " + row["Descripcion"];
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

        private void cmbTipoRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums.TipoRuta)cmbTipoRuta.EditValue)
            {
                case Enums.TipoRuta.Entrada:
                    timeA.ReadOnly = true;
                    timeA.EditValue = null;
                    timeDe.ReadOnly = false;
                    break;

                case Enums.TipoRuta.Salida:
                    timeDe.ReadOnly = true;
                    timeDe.EditValue = null;
                    timeA.ReadOnly = false;
                    break;
                default:
                    timeA.ReadOnly = timeDe.ReadOnly = false;
                    break;
            }
        }

        private void IniciarControles()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();

            timeA.EditValue = timeDe.EditValue = null;
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
        }

        private void ModificacionRuta()
        {
            txtRuta.Text = Ruta.Ruta;
            chkEsRutaExtra.Checked = Ruta.EsRutaExtra;
            lueServicio.EditValue = Ruta.Servicio == null ? -1 : Ruta.Servicio.Oid;
            cmbTipoRuta.EditValue = Ruta.TipoRuta;
            chkApoyo.Checked = Ruta.EsApoyo;
            timeDe.EditValue = Ruta.HoraEntrada;
            timeA.EditValue = Ruta.HoraSalida;
            lueTurno.EditValue = Ruta.Turno == null ?
                -1 : Ruta.Turno.Oid;
        }

        private void GuardarRuta()
        {
            Ruta = UnidadRuta.GetObjectByKey<RutasDePedido>(RutaActualizar.Oid);
            Ruta.TipoRuta = (Enums.TipoRuta)cmbTipoRuta.EditValue;
            Ruta.Ruta = txtRuta.Text;
            Ruta.Servicio = Ruta.Session.GetObjectByKey<Servicio>(lueServicio.EditValue);
            Ruta.Turno = Ruta.Session.GetObjectByKey<BL.Turno>(lueTurno.EditValue);
            Ruta.EsRutaExtra = chkEsRutaExtra.Checked;
            Ruta.EsApoyo = chkApoyo.Checked;
            if (timeDe.EditValue == null)
                Ruta.HoraEntrada = null;
            else
                Ruta.HoraEntrada = timeDe.Time;

            if (timeA.EditValue == null)
                Ruta.HoraSalida = null;
            else
                Ruta.HoraSalida = timeA.Time;

            Ruta.Save();


            RutaActualizar.Ruta = Ruta.Ruta;
            RutaActualizar.Servicio = Ruta.Servicio.Descripcion;
            RutaActualizar.TipoRuta = Ruta.TipoRuta;
            RutaActualizar.Turno = Ruta.Turno.Descripcion;
            RutaActualizar.HoraEntrada = Ruta.HoraEntrada;
            RutaActualizar.HoraSalida = Ruta.HoraSalida;
            RutaActualizar.EsApoyo = Ruta.EsApoyo;
            RutaActualizar.EsRutaExtra = Ruta.EsRutaExtra;
            RutaActualizar.EsMediaVuelta = Ruta.Servicio.EsMediaVuelta;
        }

        private bool ValidarControles()
        {
            if (timeA.EditValue == null & timeDe.EditValue == null)
            {
                XtraMessageBox.Show("Debe agregar un horario.");
                return false;
            }

            return true;
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarControles())
            {
                GuardarRuta();
                XtraMessageBox.Show("Se modificó la ruta correctamente.");
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
    }
}
