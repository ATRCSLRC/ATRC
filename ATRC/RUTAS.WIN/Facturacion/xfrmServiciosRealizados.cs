using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RUTAS.WIN
{
    public partial class xfrmServiciosRealizados : xfrmBase
    {
        public xfrmServiciosRealizados()
        {
            InitializeComponent();
        }

        UnidadDeTrabajo Unidad;
        XPCollection RutasAgrupadas;
        private void xfrmServiciosRealizados_Load(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            dteAl.DateTime = dteDe.DateTime = DateTime.Now;
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresas.Properties.DataSource = Empresas;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresas.EditValue));
            go.Operands.Add(new BetweenOperator("FechaRuta", dteDe.DateTime.Date, dteAl.DateTime.Date));
            XPView Rutas = new XPView(Unidad, typeof(RutasGeneradas));
            Rutas.Properties.AddRange(new ViewProperty[] {
            new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
            new ViewProperty("Ruta", SortDirection.None, "[Ruta]", false, true),
            new ViewProperty("FechaRuta", SortDirection.None, "[FechaRuta]", false, true),
            new ViewProperty("HoraEntrada", SortDirection.None, "[HoraEntrada]", false, true),
            new ViewProperty("HoraSalida", SortDirection.None, "[HoraSalida]", false, true),
            new ViewProperty("EsApoyo", SortDirection.None, "[EsApoyo]", false, true),
            new ViewProperty("Servicio", SortDirection.None, "[Servicio.Oid]", false, true),
            new ViewProperty("Servicio.Descripcion", SortDirection.None, "[Servicio.Descripcion]", false, true),
            new ViewProperty("EsRutaExtra", SortDirection.None, "[EsRutaExtra]", false, true),
            new ViewProperty("ComentariosFacturacion", SortDirection.None, "[ComentariosFacturacion]", false, true)
            });

            Rutas.Criteria = go;
            SortingCollection Orden = new SortingCollection();
            Orden.Add(new SortProperty("FechaRuta", DevExpress.Xpo.DB.SortingDirection.Ascending));
            Orden.Add(new SortProperty("EsRutaExtra", DevExpress.Xpo.DB.SortingDirection.Ascending));
            Orden.Add(new SortProperty("HoraEntrada", DevExpress.Xpo.DB.SortingDirection.Ascending));
            if (chkNombreRuta.Checked) Orden.Add(new SortProperty("Ruta", DevExpress.Xpo.DB.SortingDirection.Ascending));
            //Orden.Add(new SortProperty("Servicio.Descripcion", DevExpress.Xpo.DB.SortingDirection.Descending));

            Rutas.Sorting.Add(Orden);
            List<ViewRecord> Lista = new List<ViewRecord>();
            foreach(ViewRecord viewRuta in Rutas)
                Lista.Add(viewRuta);

            int x = Rutas.Count;
            RutasAgrupadas = new XPCollection(Unidad, typeof(RutasGeneradas), 0);
            int OrdenRutas = 0;
            while (x > 0)
            {
                List<ViewRecord> ListaActualizada = new List<ViewRecord>();
                ListaActualizada.AddRange(Lista);
                Agrupar(Lista, ListaActualizada, RutasAgrupadas, OrdenRutas);
                OrdenRutas++;
                Lista.Clear();
                Lista.AddRange(ListaActualizada);
                x = Lista.Count;

            }
                        
            grdRutas.DataSource = RutasAgrupadas;
            if(chkPorTurno.Checked)
                grvRutas.Columns[grvRutas.Columns.Count - 2].GroupIndex = 0;
            else
                grvRutas.Columns[grvRutas.Columns.Count - 2].GroupIndex = -1;
            if(RutasAgrupadas.Count > 0)
            {
                rpAcciones.Visible = true;
            }
        }

        private void Agrupar(List<ViewRecord> Actual, List<ViewRecord> Actualizada, XPCollection RutasAgrupadas, int Orden)
        {
            ViewRecord Ruta = Actual[0];
            RutasGeneradas RutaGenerada = Ruta.GetObject() as RutasGeneradas;
            RutaGenerada.Orden = Orden;
            
            RutaGenerada.TipoCambio = spinEdit1.Value;
            RutaGenerada.Comentarios = RutaGenerada.TipoRuta == Enums.TipoRuta.Normal ? RutaGenerada.HoraEntrada.Value.ToShortTimeString() + " a " + RutaGenerada.HoraSalida.Value.ToShortTimeString() : RutaGenerada.TipoRuta == Enums.TipoRuta.Entrada ? RutaGenerada.HoraEntrada.Value.ToShortTimeString() + " " + RutaGenerada.TipoRuta.ToString() : RutaGenerada.HoraSalida.Value.ToShortTimeString() + " " + RutaGenerada.TipoRuta.ToString();
            string NombresRuta = string.Empty;
            RutasAgrupadas.Add(RutaGenerada);
            Actualizada.Remove(Ruta);
            if (chkAgruparRutas.Checked)
            {
                foreach (ViewRecord viewRuta in Actual)
                {
                    if (viewRuta["Servicio"].ToString() == Ruta["Servicio"].ToString() & Convert.ToDateTime(viewRuta["FechaRuta"]) == Convert.ToDateTime(Ruta["FechaRuta"]) & Convert.ToDateTime(viewRuta["HoraEntrada"]).TimeOfDay == Convert.ToDateTime(Ruta["HoraEntrada"]).TimeOfDay
                        & Convert.ToDateTime(viewRuta["HoraSalida"]).TimeOfDay == Convert.ToDateTime(Ruta["HoraSalida"]).TimeOfDay & Convert.ToBoolean(viewRuta["EsRutaExtra"]) == Convert.ToBoolean(Ruta["EsRutaExtra"]) & (chkPorNombre.Checked & !Convert.ToBoolean(Ruta["EsRutaExtra"]) ? (viewRuta["Ruta"].ToString() == Ruta["Ruta"].ToString()) : true))
                    {

                        if (chkAgruparApoyos.Checked & Convert.ToBoolean(viewRuta["EsApoyo"]) & RutaGenerada.EsApoyo)
                        {
                            if (string.IsNullOrEmpty(NombresRuta))
                                NombresRuta = viewRuta["Ruta"].ToString().Replace("APOYO", "").TrimStart().TrimEnd() + " APOYO";
                            else
                            {
                                //string[] Nombres = NombresRuta.Split(',');
                                NombresRuta = NombresRuta.Replace("APOYO", "") + "," + viewRuta["Ruta"].ToString().Replace("APOYO", "").TrimStart().TrimEnd() + " APOYO";// + Nombres[1];
                            }
                            Actualizada.Remove(viewRuta);
                            RutaGenerada.Cantidad++;
                        }
                        else if (chkAgruparApoyos.Checked & (Convert.ToBoolean(viewRuta["EsApoyo"]) || RutaGenerada.EsApoyo))
                        {

                        } else if (chkSepararServiciosValle.Checked & RutaGenerada.Servicio.Descripcion.Contains("VALLE") & Convert.ToString(viewRuta["Servicio.Descripcion"]).Contains("VALLE"))
                        {
                            NombresRuta += " " + viewRuta["Ruta"].ToString() + ",";
                            Actualizada.Remove(viewRuta);
                            RutaGenerada.Cantidad++;
                            break;
                        }
                        else
                        {
                            NombresRuta += " " + viewRuta["Ruta"].ToString() + ",";
                            Actualizada.Remove(viewRuta);
                            RutaGenerada.Cantidad++;
                        }

                    }
                }
            }else
            {
                NombresRuta += " " + Ruta["Ruta"].ToString() + ",";
                Actualizada.Remove(Ruta);
                RutaGenerada.Cantidad++;
            }

            if(chkNombreRuta.Checked)
                RutaGenerada.Comentarios += " R:" + NombresRuta.TrimEnd(new char[] { ',',' '});

            if (chkTextoEntrada.Checked)
                RutaGenerada.Comentarios += " " + (RutaGenerada.TipoRuta == Enums.TipoRuta.Normal ? txtEntrada.Text + "-" : RutaGenerada.TipoRuta == Enums.TipoRuta.Entrada ? txtEntrada.Text : string.Empty);

            if (chkTextoSalida.Checked)
                RutaGenerada.Comentarios += RutaGenerada.TipoRuta == Enums.TipoRuta.Normal ? txtSalida.Text : RutaGenerada.TipoRuta == Enums.TipoRuta.Salida ? " " +txtSalida.Text : string.Empty;

            RutaGenerada.Comentarios += " " + RutaGenerada.ComentariosFacturacion;
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresas.EditValue));
            go.Operands.Add(new BinaryOperator("Servicio", RutaGenerada.Servicio));
            XPView Precios = new XPView(Unidad, typeof(PreciosServicios), "Oid;Precio", go);
            if (Precios.Count > 0)
                RutaGenerada.Precio = Convert.ToDecimal(Precios[0]["Precio"]);
            RutaGenerada.ImporteDolar = RutaGenerada.Precio * RutaGenerada.Cantidad;
            RutaGenerada.ImportePesos = (RutaGenerada.Precio * spinEdit1.Value) * RutaGenerada.Cantidad;
            RutaGenerada.Save();
        }

        private void chkTextoEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTextoEntrada.Checked)
                lciTextoEntrada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciTextoEntrada.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void chkTextoSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTextoSalida.Checked)
                lciTextoSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                lciTextoSalida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void bbiReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UnidadDeTrabajo UnidadGuardar = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            if (chkPorTurno.Checked)
            {
                for (int i = 0; i < grvRutas.RowCount; i++)
                {
                    int rowHandle = grvRutas.GetVisibleRowHandle(i);
                    if (grvRutas.IsGroupRow(rowHandle))
                    {
                        XPCollection Turnos = new XPCollection(Unidad, typeof(RutasGeneradas), 0);
                        int childCount = grvRutas.GetChildRowCount(rowHandle);
                        for (int j = 0; j < childCount; j++)
                        {
                            int childRowHandle = grvRutas.GetChildRowHandle(rowHandle, j);
                            Turnos.Add(grvRutas.GetRow(childRowHandle));
                        }

                        REPORTES.Rutas.ServiciosRealizadosEmpresa repServicios = new REPORTES.Rutas.ServiciosRealizadosEmpresa(Turnos, dteDe.DateTime, dteAl.DateTime, true);

                        
                        ReportesServiciosRealizados ReportesServicios = new ReportesServiciosRealizados(UnidadGuardar);
                        ReportesServicios.Fecha = DateTime.Now.Date;
                        ReportesServicios.Descripcion = "Semana del " + dteDe.DateTime.ToLongDateString() + " al " + dteAl.DateTime.ToLongDateString();
                        ReportesServicios.Empresa = UnidadGuardar.GetObjectByKey<Empresas>(lueEmpresas.EditValue);

                        MemoryStream stream = new MemoryStream();
                        repServicios.ExportToPdf(stream);
                        ReportesServicios.Archivo = Convert.ToBase64String(stream.ToArray());
                        ReportesServicios.Save();
                        UnidadGuardar.CommitChanges();

                        ReportPrintTool repServiciosRealizados = new ReportPrintTool(repServicios);
                        repServiciosRealizados.ShowPreview();
                    }
                }
            }else
            {
                XPCollection RutasReporte = new XPCollection(RutasAgrupadas.Session, typeof(RutasGeneradas), 0);
                for (int i = 0; i < grvRutas.RowCount; i++)
                {
                    int rowHandle = grvRutas.GetVisibleRowHandle(i);
                    RutasReporte.Add(grvRutas.GetRow(rowHandle));
                }
                    REPORTES.Rutas.ServiciosRealizadosEmpresa repServicios = new REPORTES.Rutas.ServiciosRealizadosEmpresa(RutasReporte, dteDe.DateTime, dteAl.DateTime);
                //UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                ReportesServiciosRealizados ReportesServicios = new ReportesServiciosRealizados(UnidadGuardar);
                ReportesServicios.Fecha = DateTime.Now.Date;
                ReportesServicios.Descripcion = "Semana del " + dteDe.DateTime.ToLongDateString() + " al " + dteAl.DateTime.ToLongDateString();
                ReportesServicios.Empresa = UnidadGuardar.GetObjectByKey<Empresas>(lueEmpresas.EditValue);
                
                MemoryStream stream = new MemoryStream();
                repServicios.ExportToPdf(stream);
                ReportesServicios.Archivo = Convert.ToBase64String(stream.ToArray());
                ReportesServicios.Save();
                UnidadGuardar.CommitChanges();

                ReportPrintTool repServiciosRealizados = new ReportPrintTool(repServicios);
                repServiciosRealizados.ShowPreview();
            }

        }

        private void grvRutas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            RutasGeneradas Ruta = grvRutas.GetFocusedRow() as RutasGeneradas;
            if (Ruta != null)
            {
                if (e.Column == colPrecio)
                {
                    Ruta.ImporteDolar = Ruta.Cantidad * Convert.ToDecimal(e.Value);
                    Ruta.ImportePesos = Ruta.Cantidad * (Convert.ToDecimal(e.Value) * Ruta.TipoCambio);
                }
            }
        }

        private void chkAgruparRutas_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAgruparRutas.Checked)
            {
                lciAgruparApoyos.Visibility = lciServiciosValle.Visibility = lciPorNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lciAgruparApoyos.Visibility = lciServiciosValle.Visibility = lciPorNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                chkAgruparApoyos.Checked = chkSepararServiciosValle.Checked = chkPorNombre.Checked = false;
            }
        }

        GridHitInfo downHitInfo = null;
        private void grvRutas_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow)
                downHitInfo = hitInfo;
        }

        private void grvRutas_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }

        private void grdRutas_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            if (downHitInfo != null)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle)
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void grdRutas_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int sourceRow = downHitInfo.RowHandle;
            int targetRow = hitInfo.RowHandle;
            MoveRow(sourceRow, targetRow);
        }

        private void MoveRow(int sourceRow, int targetRow)
        {
            if (sourceRow == targetRow || sourceRow == targetRow + 1) return;

            GridView view = grvRutas;
            RutasGeneradas row1 = view.GetRow(targetRow) as RutasGeneradas;
            RutasGeneradas row2 = view.GetRow(targetRow + 1) as RutasGeneradas;
            RutasGeneradas dragRow = view.GetRow(sourceRow) as RutasGeneradas;
            int val1 = row1.Orden;
            if (row2 == null)
                dragRow.Orden = val1 + 1;
            else
            {
                int val2 = row2.Orden;
                dragRow.Orden = (val1 + val2) / 2;
            }

            dragRow.Save();
        }

        private void grdRutas_Click(object sender, EventArgs e)
        {

        }

        private void lueEmpresas_EditValueChanged(object sender, EventArgs e)
        {
            if(lueEmpresas.EditValue != null)
            {
                UnidadDeTrabajo UnidadPlantilla = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                PlantillaServiciosRealizados Plantilla = UnidadPlantilla.FindObject<PlantillaServiciosRealizados>(new BinaryOperator("Empresa.Oid", lueEmpresas.EditValue));
                if(Plantilla != null)
                {
                    chkAgruparRutas.Checked = Plantilla.AgruparPorRutas;
                    chkAgruparApoyos.Checked = Plantilla.AgruparApoyos;
                    chkSepararServiciosValle.Checked = Plantilla.SepararServiciosValle;
                    chkPorNombre.Checked = Plantilla.SepararPorNombre;
                    chkNombreRuta.Checked = Plantilla.MostrarNombreRuta;
                    chkPorTurno.Checked = Plantilla.MostrarPorTurno;
                    chkTextoEntrada.Checked = Plantilla.MostrarTextoEntrada;
                    chkTextoSalida.Checked = Plantilla.MostrarTextoSalida;
                    txtEntrada.Text = Plantilla.TextoEntrada;
                    txtSalida.Text = Plantilla.TextoSalida;
                }
                else
                {
                    chkAgruparRutas.Checked = false;
                    chkAgruparApoyos.Checked = false;
                    chkSepararServiciosValle.Checked = false;
                    chkPorNombre.Checked = false;
                    chkNombreRuta.Checked = false;
                    chkPorTurno.Checked = false;
                    chkTextoEntrada.Checked = false;
                    chkTextoSalida.Checked = false;
                    txtEntrada.Text = string.Empty;
                    txtSalida.Text = string.Empty;
                }
            }
            
        }
    }
}
