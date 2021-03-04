using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace RUTAS.WIN
{
    public partial class SeguimientoDeAclaraciones : xfrmBase
    {
        public SeguimientoDeAclaraciones()
        {
            InitializeComponent();
        }

        private void SeguimientoDeAclaraciones_Load(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            XPView Aclaraciones = new XPView(Unidad, typeof(AclaracionesPedido));
            Aclaraciones.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Oid", SortDirection.None, "[Oid]", true, true),
            new ViewProperty("Descripcion", SortDirection.None, "[Descripcion]", true, true),
            new ViewProperty("FechaAlta", SortDirection.None, "[FechaAlta]", true, true),
            new ViewProperty("UsuarioAlta", SortDirection.None, "[UsuarioAlta]", true, true),
            new ViewProperty("Pedido", SortDirection.None, "[Pedido]", true, true),
             new ViewProperty("Pedido.Oid", SortDirection.None, "[Pedido.Oid]", true, true),
            new ViewProperty("EmpresaNombre", SortDirection.None, "[Pedido.Empresa.Nombre]", true, true),
            new ViewProperty("Estado", SortDirection.Ascending, "[Estado]", true, true)});

            grdAclaraciones.DataSource = Aclaraciones;
        }

        private void grvAclaraciones_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Empresas" & e.ListSourceRowIndex >= 0)
            {
                object Pedido = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "Pedido");
                if(Pedido != null)
                {
                    e.DisplayText = grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "EmpresaNombre").ToString();
                }
                else
                {
                    UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    Usuario Usuario = Unidad.GetObjectByKey<Usuario>(grvAclaraciones.GetListSourceRowCellValue(e.ListSourceRowIndex, "UsuarioAlta"));
                    e.DisplayText = Usuario == null ? "" : Usuario.Empresa == null ? "" : Usuario.Empresa.Nombre;
                }

            }
        }

        private void ribeReporte_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord viewPedido = grvAclaraciones.GetRow(grvAclaraciones.FocusedRowHandle) as ViewRecord;
            if (viewPedido != null)
            {
                REPORTES.Rutas.AclaracionesPedido Rutas = new REPORTES.Rutas.AclaracionesPedido(Convert.ToInt32(viewPedido["Pedido.Oid"]), Convert.ToInt32(viewPedido["Oid"]));
                ReportPrintTool repRutas = new ReportPrintTool(Rutas);
                repRutas.ShowPreview();
            }
        }

        private void ribeAclaraciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                xfrmHistorialAclaraciones xfrm = new xfrmHistorialAclaraciones();
                xfrm.IDAclaracion = Convert.ToInt32(ViewAclaracion["Oid"]);
                xfrm.ShowDialog();
            }
        }

        private void bbiAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (XtraMessageBox.Show("¿Desea aprobar la aclaración?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                AclaracionesPedido Aclaracion = Unidad.GetObjectByKey<AclaracionesPedido>(Convert.ToInt32(ViewAclaracion["Oid"]));
                if(Aclaracion != null)
                {
                    Aclaracion.Estado = Enums.EstadoAclaraciones.Aprobada_Rutas;
                    Aclaracion.Motivo = "Se aprobo la aclaración.";
                    Aclaracion.Save();
                    Unidad.CommitChanges();
                    rpAcciones.Visible = false;
                    ((XPView)grdAclaraciones.DataSource).Reload();
                }
            }
        }

        private void bbiRechazar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Rechazar la aclaración";
                args.Prompt = "Motivo:";
                MemoEdit editor = new MemoEdit();
                args.Editor = editor;
                var result = XtraInputBox.Show(args);
                if (result != null)
                {
                    AclaracionesPedido Aclaracion = Unidad.GetObjectByKey<AclaracionesPedido>(Convert.ToInt32(ViewAclaracion["Oid"])); 
                    Aclaracion.Motivo = "Se rechazo por " + result.ToString();
                    Aclaracion.Estado = Enums.EstadoAclaraciones.Rechazada_Rutas;
                    Aclaracion.Save();
                    Unidad.CommitChanges();
                    rpAcciones.Visible = false;
                    ((XPView)grdAclaraciones.DataSource).Reload();
                    //BL.Utilerias.EnviarCorreo(Pedido);
                }

            }
        }

        private void grvAclaraciones_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                Enums.EstadoAclaraciones estado = (Enums.EstadoAclaraciones)ViewAclaracion["Estado"];
                switch (estado)
                {
                    case Enums.EstadoAclaraciones.Creado_Rutas:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bbiActualizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        rpAcciones.Visible = true;
                        break;
                    case Enums.EstadoAclaraciones.Revision_Rutas:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiActualizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        rpAcciones.Visible = true;
                        break;
                    //case Enums.EstadoAclaraciones.Actualizando:
                    //    bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //    bbiActualizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //    rpAcciones.Visible = true;
                    //    break;
                    case Enums.EstadoAclaraciones.Creado_Maquiladora:
                    case Enums.EstadoAclaraciones.Revision_Maquiladora:
                    case Enums.EstadoAclaraciones.Aprobada_Maquiladora:
                    case Enums.EstadoAclaraciones.Aprobada_Rutas:
                    case Enums.EstadoAclaraciones.Rechazada_Maquiladora:
                    case Enums.EstadoAclaraciones.Rechazada_Rutas:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiActualizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        rpAcciones.Visible = false;
                        break;

                }

            }
        }

        private void grvAclaraciones_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                Enums.EstadoAclaraciones estado = (Enums.EstadoAclaraciones)ViewAclaracion["Estado"];

                switch (estado)
                {
                    case Enums.EstadoAclaraciones.Creado_Maquiladora:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        rpAcciones.Visible = true;
                        break;
                    case Enums.EstadoAclaraciones.Revision_Rutas:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        rpAcciones.Visible = true;
                        break;
                    case Enums.EstadoAclaraciones.Creado_Rutas:
                    case Enums.EstadoAclaraciones.Revision_Maquiladora:
                    case Enums.EstadoAclaraciones.Aprobada_Maquiladora:
                    case Enums.EstadoAclaraciones.Aprobada_Rutas:
                    case Enums.EstadoAclaraciones.Rechazada_Maquiladora:
                    case Enums.EstadoAclaraciones.Rechazada_Rutas:
                        bbiAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRechazar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        bbiRevision.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        rpAcciones.Visible = false;
                        break;

                }

                //if (Enums.EstadoAclaraciones.Aprobada_Rutas != estado || Enums.EstadoAclaraciones.Rechazada_Rutas != estado ||
                //    Enums.EstadoAclaraciones.Aprobada_Maquiladora != estado || Enums.EstadoAclaraciones.Rechazada_Maquiladora != estado)
                //    rpAcciones.Visible = false;
                //else
                //    rpAcciones.Visible = true;

            }
        }

        private void bbiRevision_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (XtraMessageBox.Show("¿Desea aprobar la aclaración?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                AclaracionesPedido Aclaracion = Unidad.GetObjectByKey<AclaracionesPedido>(Convert.ToInt32(ViewAclaracion["Oid"]));
                if (Aclaracion != null)
                {
                    Aclaracion.Estado = Enums.EstadoAclaraciones.Revision_Rutas;
                    Aclaracion.Motivo = "Aclaración en revisión.";
                    Aclaracion.Save();
                    Unidad.CommitChanges();
                    rpAcciones.Visible = false;
                    ((XPView)grdAclaraciones.DataSource).Reload();
                }
            }
        }

        private void bbiActualizacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRecord ViewAclaracion = grvAclaraciones.GetFocusedRow() as ViewRecord;
            if (ViewAclaracion != null)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("PedidoRutas", ViewAclaracion["Oid"]));
                go.Operands.Add(new BinaryOperator("PorActualizar", true));
                XPView Rutas = new XPView(Unidad, typeof(RutasDePedido), "Oid", go);
                AclaracionesPedido Aclaracion = Unidad.GetObjectByKey<AclaracionesPedido>(Convert.ToInt16(ViewAclaracion["Oid"]));
                Aclaracion.Estado = Enums.EstadoAclaraciones.Cambios_Realizados;
                Aclaracion.Save();
                foreach (ViewRecord Ruta in Rutas)
                {
                    RutasDePedido RutaPedido = Unidad.GetObjectByKey<RutasDePedido>(Convert.ToInt16(Ruta["Oid"]));

                    RutasGeneradas RutaGenerada = Unidad.GetObjectByKey<RutasGeneradas>(RutaPedido.RutaGenerada);
                    RutaGenerada.TipoRuta = RutaPedido.TipoRuta;
                    RutaGenerada.Ruta = RutaPedido.Ruta;
                    RutaGenerada.Servicio = RutaPedido.Servicio;
                    RutaGenerada.Turno = RutaPedido.Turno;
                    RutaGenerada.FechaRuta = RutaPedido.FechaRuta.Date;
                    RutaGenerada.EsRutaExtra = RutaPedido.EsRutaExtra;
                    RutaGenerada.EsApoyo = RutaPedido.EsApoyo;
                    RutaGenerada.HoraEntrada = RutaPedido.HoraEntrada;
                    RutaGenerada.HoraSalida = RutaPedido.HoraSalida;
                    RutaGenerada.RutaCompleta = RutaPedido.RutaCompleta;
                    RutaGenerada.Comentarios = RutaPedido.Comentarios;
                    RutaGenerada.Save();
                }
                Unidad.CommitChanges();
                XtraMessageBox.Show("Se aplicaron los cambios correctamente.");
                ((XPView)grdAclaraciones.DataSource).Reload();

            }
        }
    }
    
}
