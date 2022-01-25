using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
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
using static ATRCBASE.BL.Enums;

namespace RUTAS.WIN.PedidoRutas
{
    public partial class xfrmNuevaAclaracion : xfrmBase
    {
        public xfrmNuevaAclaracion()
        {
            InitializeComponent();
        }

        public int OIDPedido;
        UnidadDeTrabajo Unidad;
        RUTAS.BL.PedidoRutas Pedido;
        AclaracionesPedido Aclaracion;
        private void xfrmNuevaAclaracion_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            Pedido = Unidad.GetObjectByKey<RUTAS.BL.PedidoRutas>(OIDPedido);
            Aclaracion = new AclaracionesPedido(Unidad);
           // if (Pedido != null)
                XPView Rutas = new XPView(Unidad, typeof(RutasDePedido), "Oid;Ruta;Servicio.Descripcion;" +
                    "TipoRuta;Turno;Turno.Descripcion;HoraEntrada;HoraSalida;EsApoyo;EsRutaExtra;Servicio.EsMediaVuelta", new BinaryOperator("PedidoRutas", OIDPedido));
            grdRutas.DataSource = ConvertirALista(Rutas);
            Pedido.AclaracionActual = Aclaracion;
            replueServicio.DataSource = GetServiciosXP();
            replueTurno.DataSource = GetTurnosXP();

        }
        private  List<Servicio> GetServiciosXP()
        {
            List<Servicio> list = new List<Servicio>();
            XPCollection Servicios = new XPCollection(Unidad, typeof(Servicio));
            foreach(Servicio servi in Servicios)
                list.Add(servi);
            return list;
        }

        private List<BL.Turno> GetTurnosXP()
        {
            List<BL.Turno> list = new List<BL.Turno>();
            XPCollection Turnos = new XPCollection(Unidad, typeof(BL.Turno));
            foreach (BL.Turno turn in Turnos)
                list.Add(turn);
            return list;
        }

        private List<Rutas> ConvertirALista(XPView RutasXP)
        {
            List<Rutas> ListRutas = new List<Rutas>();
            foreach (ViewRecord viewRuta in RutasXP)
            {
                Rutas Ruta = new Rutas();
                Ruta.Oid = Convert.ToInt32(viewRuta["Oid"]);
                Ruta.Ruta = viewRuta["Ruta"].ToString();
                Ruta.Servicio = viewRuta["Servicio.Descripcion"].ToString();
                Ruta.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                Ruta.Turno = viewRuta["Turno"] !=  null ? viewRuta["Turno.Descripcion"].ToString() : string.Empty;
                Ruta.HoraEntrada = (Nullable<DateTime>)viewRuta["HoraEntrada"];
                Ruta.HoraSalida = (Nullable<DateTime>)viewRuta["HoraSalida"];
                Ruta.EsApoyo = Convert.ToBoolean(viewRuta["EsApoyo"]);
                Ruta.EsRutaExtra = Convert.ToBoolean(viewRuta["EsRutaExtra"]);
                Ruta.EsMediaVuelta = Convert.ToBoolean(viewRuta["Servicio.EsMediaVuelta"]);
                ListRutas.Add(Ruta);
            }

            return ListRutas;
        }


        private void grvRuta_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "TipoRuta")
            {
                ComboBoxEdit editor = (ComboBoxEdit)view.ActiveEditor;
                bool EsMediaVuelta = (bool)view.GetFocusedRowCellValue("EsMediaVuelta");

                editor.Properties.Items.Clear();
                if (EsMediaVuelta)
                {
                    editor.Properties.Items.Add(Enums.TipoRuta.Entrada);
                    editor.Properties.Items.Add(Enums.TipoRuta.Salida);
                }
                else
                {
                    editor.Properties.Items.Add(Enums.TipoRuta.Normal);
                }

            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿La información proporcionada es correcta?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                
                Aclaracion.Descripcion = memoDescripcion.Text;
                Aclaracion.Estado = Enums.EstadoAclaraciones.Creado_Rutas;
                Aclaracion.Pedido = Pedido;
                //Pedido.AclaracionActual = Aclaracion;
                Unidad.CommitChanges();
                this.Close();
            }
        }

        private void replueServicio_EditValueChanged(object sender, EventArgs e)
        {
            grvRuta.PostEditor();
            bool EsMediaVuelta = (bool)grvRuta.GetFocusedRowCellValue("EsMediaVuelta");
            if (EsMediaVuelta)
                grvRuta.SetFocusedRowCellValue("TipoRuta", Enums.TipoRuta.Entrada);
            else
                grvRuta.SetFocusedRowCellValue("TipoRuta", Enums.TipoRuta.Normal);
        }

        private void grvRuta_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            fypEdicion.ShowPopup();
        }

        private void grvRuta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            fypEdicion.ShowPopup();
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            Rutas Ruta = grvRuta.GetFocusedRow() as Rutas;
            if (Ruta != null)
            {
                //RutasDePedido Ruta = (RutasDePedido)viewRuta.GetObject();
                xfrmRutaDePedido xfrm = new xfrmRutaDePedido();
                xfrm.RutaActualizar = Ruta;
                xfrm.UnidadRuta = Unidad;

                xfrm.ShowDialog();
                ((XPView)grdRutas.DataSource).Reload();
            }
        }

        [NonPersistent]
        public class Rutas
        {
            public int Oid { get; set; }
            public string Servicio { get; set; }

            public bool EsMediaVuelta { get; set; }

            public DateTime FechaRuta { get; set; }

            public TipoRuta TipoRuta { get; set; }

            public string Turno { get; set; }

            public Nullable<DateTime> HoraEntrada { get; set; }

            public Nullable<DateTime> HoraSalida { get; set; }

            public bool EsRutaExtra { get; set; }

            public string Ruta { get; set; }

            public bool EsApoyo { get; set; }
        }
    }
}
