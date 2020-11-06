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
    public partial class xfrmPedidosRecibidos : xfrmBase
    {
        public xfrmPedidosRecibidos()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        private void xfrmPedidosRecibidos_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator Go = new GroupOperator(GroupOperatorType.Or);
            Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Enviado));
            Go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoPedidoRutas.Revision));
            XPView Pedidos = new XPView(Unidad, typeof(RUTAS.BL.PedidoRutas));
            Pedidos.AddProperty("Oid", "Oid", true);
            Pedidos.AddProperty("Nombre", "Nombre", true);
            Pedidos.AddProperty("Estado", "Estado", true);
            Pedidos.AddProperty("Empresa", "Empresa.Nombre", true);
            Pedidos.AddProperty("FechaPedido", "Fecha", true);
            Pedidos.AddProperty("Fecha", "FechaAlta", true);
            Pedidos.AddProperty("Usuario", "UsuarioAlta", true);
            Pedidos.AddProperty("Rutas", "Rutas.Count()", false);
            Pedidos.Criteria = Go;
            grdPedidosRecibidos.DataSource = Pedidos;

        }

        private void grvPedidosRecibidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosRecibidos.GetFocusedRow() as ViewRecord;
            if(viewPedido != null)
            {
                rpAccion.Visible = true;

                Enums.EstadoPedidoRutas estado = (Enums.EstadoPedidoRutas)viewPedido["Estado"];
                if(estado == Enums.EstadoPedidoRutas.Enviado)
                {
                    bbiRevicion.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    bbiRechazado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }else
                {
                    bbiRevicion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bbiRechazado.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
            }else
            {
                rpAccion.Visible = false;
            }
        }

        private void ribeRutas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(grvPedidosRecibidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmRevisionPedido xfrm = new xfrmRevisionPedido();
                xfrm.Oid = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void ribeHistorial_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(grvPedidosRecibidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                xfrmHistorialPedido xfrm = new xfrmHistorialPedido();
                xfrm.OID = Convert.ToInt32(viewPedido["Oid"]);
                xfrm.ShowDialog();
            }
        }


        private void grvPedidosRecibidos_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(e.RowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                if (e.Column.Caption == "Rutas")
                {
                    if((Enums.EstadoPedidoRutas)viewPedido["Estado"] == Enums.EstadoPedidoRutas.Revision)
                        e.RepositoryItem = ribeRutas;
                    
                }

            }
        }

        private void bbiRevicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(grvPedidosRecibidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                BL.PedidoRutas Pedido = (BL.PedidoRutas)viewPedido.GetObject();
                Pedido.Detalle = "Se cambio el estado de " + Pedido.Estado + " a Revisión.";
                Pedido.Estado = Enums.EstadoPedidoRutas.Revision;
                Pedido.Save();
                Unidad.CommitChanges();
                ((XPView)grdPedidosRecibidos.DataSource).Reload();
                BL.Utilerias.EnviarCorreo(Pedido);

            }
        }

        private void bbiAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(grvPedidosRecibidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                BL.PedidoRutas Pedido = (BL.PedidoRutas)viewPedido.GetObject();
                Pedido.Detalle = "Se cambio el estado de " + Pedido.Estado + " a Aprobado.";
                Pedido.Estado = Enums.EstadoPedidoRutas.Aprobado;
                Pedido.Save();

                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("Empresa", Pedido.Empresa));
                go.Operands.Add(new BinaryOperator("FechaRuta", Pedido.Fecha.Date));
                XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid", go);

                int Orden = Rutas.Count + 1;
                foreach (RutasDePedido RutaPedido in Pedido.Rutas)
                {
                    RutasGeneradas Ruta = new RutasGeneradas(Unidad);
                    Ruta.TipoRuta = RutaPedido.TipoRuta;
                    Ruta.Ruta = RutaPedido.Ruta;
                    Ruta.Servicio = RutaPedido.Servicio;
                    Ruta.Turno = RutaPedido.Turno;
                    Ruta.FechaRuta = Pedido.Fecha.Date;
                    Ruta.EsRutaExtra = RutaPedido.EsRutaExtra;
                    Ruta.EsApoyo = RutaPedido.EsApoyo;
                    Ruta.Empresa = Pedido.Empresa;
                    Ruta.HoraEntrada = RutaPedido.HoraEntrada;
                    Ruta.HoraSalida = RutaPedido.HoraSalida;
                    Ruta.RutaCompleta = RutaPedido.RutaCompleta;
                    Ruta.Comentarios = RutaPedido.Comentarios;
                    Ruta.OrdenRutas = Orden;

                    #region Historial
                    HistorialRutaGenerada HistorialRutaGenerada = new HistorialRutaGenerada(Unidad);
                    HistorialRutaGenerada.TipoRuta = RutaPedido.TipoRuta;
                    HistorialRutaGenerada.Ruta = RutaPedido.Ruta;
                    HistorialRutaGenerada.FechaRuta = Pedido.Fecha.Date;
                    HistorialRutaGenerada.Servicio = RutaPedido.Servicio;
                    HistorialRutaGenerada.Turno = RutaPedido.Turno;
                    HistorialRutaGenerada.EsRutaExtra = RutaPedido.EsRutaExtra;
                    HistorialRutaGenerada.EsApoyo = RutaPedido.EsApoyo;
                    HistorialRutaGenerada.HoraEntrada = RutaPedido.HoraEntrada;
                    HistorialRutaGenerada.HoraSalida = RutaPedido.HoraSalida;
                    HistorialRutaGenerada.RutaCompleta = RutaPedido.RutaCompleta;
                    HistorialRutaGenerada.Comentarios = RutaPedido.Comentarios;
                    HistorialRutaGenerada.UsuarioModificacionClase = ATRCBASE.BL.Utilerias.ObtenerUsuarioActual(Unidad);
                    HistorialRutaGenerada.HorarioModificacion = DateTime.Now;
                    HistorialRutaGenerada.Save();
                    Ruta.Historial.Add(HistorialRutaGenerada);
                    #endregion
                    Ruta.Save();
                    Orden++;
                    //Rutas.Add(Ruta);

                }

                Unidad.CommitChanges();
                ((XPView)grdPedidosRecibidos.DataSource).Reload();
                BL.Utilerias.EnviarCorreo(Pedido);

            }
        }

        private void bbiRechazado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            ViewRecord viewPedido = grvPedidosRecibidos.GetRow(grvPedidosRecibidos.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Rechazar pedido'" + viewPedido["Nombre"] + "'";
                args.Prompt = "Motivo:";
                MemoEdit editor = new MemoEdit();
                args.Editor = editor;
                var result = XtraInputBox.Show(args);
                if (result != null)
                {
                    BL.PedidoRutas Pedido = (BL.PedidoRutas)viewPedido.GetObject();
                    Pedido.Detalle = "Se rechazo el pedido por " + result.ToString();
                    Pedido.Estado = Enums.EstadoPedidoRutas.Rechazado;
                    Pedido.Save();
                    Unidad.CommitChanges();
                    ((XPView)grdPedidosRecibidos.DataSource).Reload();
                    BL.Utilerias.EnviarCorreo(Pedido);
                }

            }
        }
    }
}
