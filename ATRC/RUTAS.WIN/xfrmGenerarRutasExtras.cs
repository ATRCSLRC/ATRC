using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ExcelDataReader;
using RUTAS.BL;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        XPView Rutas;
        //XPCollection<RutasGeneradas> Rutas;
        private void xfrmGenerarRutasExtras_Load(object sender, EventArgs e)
        {
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = ATRCBASE.BL.Utilerias.VisibilidadPermiso("RutasFijasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = ATRCBASE.BL.Utilerias.VisibilidadPermiso("NuevaRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = ATRCBASE.BL.Utilerias.VisibilidadPermiso("ModificarRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[3])).Visible = ATRCBASE.BL.Utilerias.VisibilidadPermiso("EliminarRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            //Rutas = new XPCollection<RutasGeneradas>(Unidad,0);
            //grdRutas.DataSource = Rutas;
            flpAcciones.ShowPopup();
            dteFecha.DateTime = DateTime.Now;
            XPView Empresas = new XPView(Unidad, typeof(Empresas), "Oid;Clave;Nombre", null);
            lueEmpresa.Properties.DataSource = Empresas;

            
        }

        private void flpAcciones_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            if (lueEmpresa.EditValue != null)
            {
                ATRCBASE.BL.Configuraciones ConfiguracionActivarSeguridadModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ActivarSeguridadModificacion"));
                if (Convert.ToBoolean(ConfiguracionActivarSeguridadModificacion.Accion))
                {
                    ATRCBASE.BL.Configuraciones ConfiguracionDiasModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "DiasModificacion"));
                    if (dteFecha.DateTime.Date < DateTime.Now.Date.AddDays(-Convert.ToInt32(ConfiguracionDiasModificacion.Accion)) & e.Button.Caption != "Historial ruta" & e.Button.Caption != "Cancelar")
                    {
                        switch (e.Button.Caption)
                        {
                            case "Eliminar ruta":
                                if (((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible == true)
                                {
                                    
                                    if (XtraMessageBox.Show("Para realizar cualquier acción requiere permiso del administrador ¿Desea continuar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                    {
                                        ViewRecord ViewRutaExtra = grvRutas.GetFocusedRow() as ViewRecord;
                                        if (ViewRutaExtra != null)
                                        {
                                            xfrmCodigoSeguridad xfrm = new xfrmCodigoSeguridad();
                                            xfrm.Accion = e.Button.Caption;
                                            xfrm.Ruta = (RutasGeneradas)ViewRutaExtra.GetObject();
                                            xfrm.ShowDialog();
                                        }
                                        else
                                        {
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                break;
                            case "Ruta nueva":
                            case "Plantillas de rutas":
                            case "Historial ruta":
                                break;
                            default:
                                if (XtraMessageBox.Show("Para realizar cualquier acción requiere permiso del administrador ¿Desea continuar?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    ViewRecord ViewRutaExtra = grvRutas.GetFocusedRow() as ViewRecord;
                                    if (ViewRutaExtra != null)
                                    {
                                        xfrmCodigoSeguridad xfrm = new xfrmCodigoSeguridad();
                                        xfrm.Accion = e.Button.Caption;
                                        xfrm.Ruta = (RutasGeneradas)ViewRutaExtra.GetObject();
                                        xfrm.ShowDialog();
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    return;
                                }
                                break;
                        }
                    }
                    // ConfiguracionDiasModificacion.Accion;
                }



                switch (e.Button.Caption)
                {
                    case "Plantillas de rutas":
                        xfrmPlantillasRutasFijasGRD xfrmPlantilla = new xfrmPlantillasRutasFijasGRD();
                        xfrmPlantilla.AsignarPlantilla = true;
                        xfrmPlantilla.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                        xfrmPlantilla.ShowDialog();
                        Loading.ShowWaitForm();
                        if (xfrmPlantilla.PlantillaRutas != null)
                        {
                            int Orden = ((XPView)grdRutas.DataSource).Count + 1;
                            foreach (Int32 ID in xfrmPlantilla.PlantillaRutas)
                            {
                                PlantillaRutas plantilla = Unidad.GetObjectByKey<PlantillaRutas>(ID);
                                
                                if (plantilla != null)
                                {
                                    XPView PlantillaRutasExtras = new XPView(UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(PlantillaRutaFija), "Oid;Ruta;TipoRuta;EsRutaExtra;EsApoyo;Servicio;OrdenRutas;Turno;HoraEntrada;HoraSalida;ChoferEntrada;ChoferSalida;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios;ComentariosFacturacion", new BinaryOperator("PlantillaRutas", plantilla.Oid));
                                    PlantillaRutasExtras.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
                                    
                                    foreach (ViewRecord viewRuta in PlantillaRutasExtras)
                                    {
                                        RutasGeneradas Ruta = new RutasGeneradas(Unidad);
                                        Ruta.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                                        Ruta.Ruta = viewRuta["Ruta"].ToString();
                                        Ruta.Servicio = viewRuta["Servicio"] == null ? null : Unidad.GetObjectByKey<Servicio>(Convert.ToInt32(viewRuta["Servicio"]));
                                        Ruta.Turno = viewRuta["Turno"] == null ? null : Unidad.GetObjectByKey<BL.Turno>(Convert.ToInt32(viewRuta["Turno"]));
                                        Ruta.FechaRuta = dteFecha.DateTime.Date;
                                        Ruta.EsRutaExtra = (bool)viewRuta["EsRutaExtra"];
                                        Ruta.EsApoyo = viewRuta["EsApoyo"] == null ? false : (bool)viewRuta["EsApoyo"];
                                        //Ruta.TipoUnidad = (TipoUnidad)viewRuta["TipoUnidad"];
                                        Ruta.Empresa = plantilla.Empresa;
                                        Ruta.HoraEntrada = viewRuta["HoraEntrada"] == null ? null : (DateTime?)viewRuta["HoraEntrada"];
                                        Ruta.HoraSalida = viewRuta["HoraSalida"] == null ? null : (DateTime?)viewRuta["HoraSalida"];
                                        Ruta.ChoferEntrada = viewRuta["ChoferEntrada"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferEntrada"]));
                                        Ruta.ChoferSalida = viewRuta["ChoferSalida"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferSalida"]));
                                        Ruta.RutaCompleta = (bool)viewRuta["RutaCompleta"];
                                        Ruta.PagarChoferEntrada = (bool)viewRuta["PagarChoferEntrada"];
                                        Ruta.PagarChoferSalida = (bool)viewRuta["PagarChoferSalida"];
                                        Ruta.Comentarios = viewRuta["Comentarios"].ToString();
                                        Ruta.ComentariosFacturacion = viewRuta["ComentariosFacturacion"] != null ? viewRuta["ComentariosFacturacion"].ToString() : "";
                                        Ruta.OrdenRutas = Orden;

                                        #region Historial
                                        HistorialRutaGenerada HistorialRutaGenerada = new HistorialRutaGenerada(Unidad);
                                        HistorialRutaGenerada.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                                        HistorialRutaGenerada.Ruta = viewRuta["Ruta"].ToString();
                                        HistorialRutaGenerada.FechaRuta = dteFecha.DateTime.Date; 
                                        HistorialRutaGenerada.Servicio = viewRuta["Servicio"] == null ? null : Unidad.GetObjectByKey<Servicio>(Convert.ToInt32(viewRuta["Servicio"]));
                                        HistorialRutaGenerada.Turno = viewRuta["Turno"] == null ? null : Unidad.GetObjectByKey<BL.Turno>(Convert.ToInt32(viewRuta["Turno"]));
                                        HistorialRutaGenerada.EsRutaExtra = (bool)viewRuta["EsRutaExtra"];
                                        HistorialRutaGenerada.EsApoyo = viewRuta["EsApoyo"] == null ? false : (bool)viewRuta["EsApoyo"];
                                        HistorialRutaGenerada.HoraEntrada = viewRuta["HoraEntrada"] == null ? null : (DateTime?)viewRuta["HoraEntrada"];
                                        HistorialRutaGenerada.HoraSalida = viewRuta["HoraSalida"] == null ? null : (DateTime?)viewRuta["HoraSalida"];
                                        HistorialRutaGenerada.RutaCompleta = (bool)viewRuta["RutaCompleta"];
                                        HistorialRutaGenerada.ChoferEntrada = viewRuta["ChoferEntrada"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferEntrada"]));
                                        HistorialRutaGenerada.PagarChoferEntrada = (bool)viewRuta["PagarChoferEntrada"];
                                        HistorialRutaGenerada.ChoferSalida = viewRuta["ChoferSalida"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferSalida"]));
                                        HistorialRutaGenerada.PagarChoferSalida = (bool)viewRuta["PagarChoferSalida"];
                                        HistorialRutaGenerada.Comentarios = viewRuta["Comentarios"].ToString();
                                        HistorialRutaGenerada.ComentariosFacturacion = viewRuta["ComentariosFacturacion"] != null ? viewRuta["ComentariosFacturacion"].ToString() : "";
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
                                }
                            }
                        }
                        Loading.CloseWaitForm();
                        ((XPView)grdRutas.DataSource).Reload();
                        if (dteFecha.DateTime.Date >= new DateTime(2020, 07, 16))
                            Rutas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
                        break;

                    case "Ruta nueva":
                        xfrmRutasFijas xfrmAgregar = new xfrmRutasFijas();
                        xfrmAgregar.EsPlantilla = false;
                        xfrmAgregar.EsModificacion = false;
                        xfrmAgregar.Orden = ((XPView)grdRutas.DataSource).Count + 1;
                        xfrmAgregar.FechaRuta = dteFecha.DateTime.Date;
                        xfrmAgregar.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                        xfrmAgregar.Unidad = Unidad;
                        xfrmAgregar.ShowDialog();
                        ((XPView)grdRutas.DataSource).Reload();
                        //Rutas.Add(xfrmAgregar.RutasFijas);

                        break;

                    case "Modificar ruta":
                        ViewRecord ViewRutaExtraModificar = grvRutas.GetFocusedRow() as ViewRecord;
                        //RutasGeneradas RutaExtraModificar = grvRutas.GetFocusedRow() as RutasGeneradas;
                        if (ViewRutaExtraModificar != null)
                        {
                            xfrmRutasFijas xfrmModificar = new xfrmRutasFijas();
                            xfrmModificar.EsPlantilla = false;
                            xfrmModificar.EsModificacion = true;
                            xfrmModificar.FechaRuta = dteFecha.DateTime.Date;
                            xfrmModificar.Unidad = Unidad;
                            xfrmModificar.Empresa = Unidad.GetObjectByKey<Empresas>(lueEmpresa.EditValue);
                            xfrmModificar.RutasFijas = (RutasGeneradas)ViewRutaExtraModificar.GetObject();
                            xfrmModificar.ShowDialog();
                            ((XPView)grdRutas.DataSource).Reload();
                        }
                        break;

                    case "Eliminar ruta":
                        grvRutas.OptionsSelection.MultiSelect = true;
                        grvRutas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;


                        if (((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible == false)
                        {
                            if (XtraMessageBox.Show("¿Está seguro de querer eliminar la(s) ruta(s) seleccionada(s)?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                Loading.ShowWaitForm();
                                Int32[] selectedRowHandles = grvRutas.GetSelectedRows();
                                for (int i = 0; i < selectedRowHandles.Length; i++)
                                {
                                    int selectedRowHandle = selectedRowHandles[i];
                                    if (selectedRowHandle >= 0)
                                    {
                                        ViewRecord ViewRutaExtraEliminar = ((ViewRecord)grvRutas.GetRow(selectedRowHandle));
                                        //RutasGeneradas RutaExtra = grvRutas.GetFocusedRow() as RutasGeneradas;
                                        if (ViewRutaExtraEliminar != null)
                                        {
                                            //if (XtraMessageBox.Show("¿Está seguro de querer eliminar la ruta seleccionada ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                            //{
                                            Unidad.Delete((RutasGeneradas)ViewRutaExtraEliminar.GetObject());
                                            //Unidad.CommitChanges();
                                            //((XPView)grdRutas.DataSource).Reload();

                                            //}



                                        }
                                        //PlantillaRutas.Add(Convert.ToInt32(((ViewRecord)grvPlantillas.GetRow(selectedRowHandle))["Oid"]));
                                    }
                                }
                                Unidad.CommitChanges();
                               
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[5])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[4])).Visible = false;
                                ((XPView)grdRutas.DataSource).Reload();
                                int x = 1;
                                foreach (ViewRecord view in (XPView)grdRutas.DataSource)
                                {
                                    RutasGeneradas ruta = (RutasGeneradas)view.GetObject();
                                    ruta.OrdenRutas = x;
                                    ruta.Save();
                                    x++;
                                }
                                Unidad.CommitChanges();
                                Loading.CloseWaitForm();
                                ((XPView)grdRutas.DataSource).Reload();
                                grvRutas.OptionsSelection.MultiSelect = false;
                                grvRutas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                            }
                        }
                        else
                        {
                            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = false;
                            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = false;
                            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = false;
                            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[4])).Visible = true;
                            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[5])).Visible = false;
                        }

                        break;
                    case "Cancelar":
                        ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = true;
                        ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = true;
                        ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = true;
                        ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[4])).Visible = false;
                        ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[5])).Visible = true;
                        grvRutas.OptionsSelection.MultiSelect = false;
                        grvRutas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

                        break;
                    case "Historial ruta":
                        ViewRecord ViewRutaHistorial = grvRutas.GetFocusedRow() as ViewRecord;
                        //RutasGeneradas RutaExtraModificar = grvRutas.GetFocusedRow() as RutasGeneradas;
                        if (ViewRutaHistorial != null)
                        {
                            xfrmHistorialRutas xfrmHistorial = new xfrmHistorialRutas();
                            xfrmHistorial.Ruta = (RutasGeneradas)ViewRutaHistorial.GetObject();
                            xfrmHistorial.ShowDialog();
                        }

                        break;
                }
            }else
            {
                XtraMessageBox.Show("Debe seleccionar una empresa.");
            }
        }

        private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Loading.ShowWaitForm();
                //foreach(RutasGeneradas Ruta in Rutas)
                //{
                //    //Ruta.FechaRuta = dteFecha.DateTime;
                //    Ruta.Save();
                //}
                Unidad.CommitChanges();
                Loading.CloseWaitForm();
                XtraMessageBox.Show("Se han guardado las rutas correctamente.");
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            //if (Rutas.Count <= 0)
            //{
            //    XtraMessageBox.Show("No hay rutas por guardar.");
            //    return false;
            //}
            return true;
        }

        private void RutasGeneradas()
        {
            ATRCBASE.BL.Configuraciones ConfiguracionActivarSeguridadModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "ActivarSeguridadModificacion"));
            if (Convert.ToBoolean(ConfiguracionActivarSeguridadModificacion.Accion))
            {
                ATRCBASE.BL.Configuraciones ConfiguracionDiasModificacion = Unidad.FindObject<ATRCBASE.BL.Configuraciones>(new BinaryOperator("Propiedad", "DiasModificacion"));
                if (dteFecha.DateTime.Date < DateTime.Now.Date.AddDays(-Convert.ToInt32(ConfiguracionDiasModificacion.Accion)))
                {
                    XtraMessageBox.Show(String.Format("Las rutas de este día no se pueden modificar.\nSe requiere permiso del administrador."));
                }
            }
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresa.EditValue));
            go.Operands.Add(new BinaryOperator("FechaRuta", dteFecha.DateTime.Date));
            Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;Ruta;OrdenRutas;TipoRuta;EsRutaExtra;EsApoyo;Servicio.TipoUnidad;Turno.Descripcion;HoraEntrada;HoraSalida;ChoferEntrada.Nombre;ChoferSalida.Nombre;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios", go);

            if (dteFecha.DateTime.Date >= new DateTime(2020, 07, 16))
                Rutas.Sorting.Add(new SortProperty("OrdenRutas", DevExpress.Xpo.DB.SortingDirection.Ascending));
            grdRutas.DataSource = Rutas;
            
        }

        private void lueEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            RutasGeneradas();
        }

        private void dteFecha_EditValueChanged(object sender, EventArgs e)
        {
            RutasGeneradas();
        }

        private void lueEmpresa_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            if (lue.EditValue != null)
            {
                ViewRecord row = lue.GetSelectedDataRow() as ViewRecord;
                e.DisplayText = row["Clave"] + " - " + row["Nombre"];
            }
        }

        private void grdRutas_DragOver(object sender, DragEventArgs e)
        {
            if (dteFecha.DateTime.Date >= new DateTime(2020, 07, 16))
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
        }

        private void grdRutas_DragDrop(object sender, DragEventArgs e)
        {
            if (dteFecha.DateTime.Date >= new DateTime(2020, 07, 16))
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                int sourceRow = downHitInfo.RowHandle;
                int targetRow = hitInfo.RowHandle;
                MoveRow(sourceRow, targetRow);
            }
        }

        private void MoveRow(int sourceRow, int targetRow)
        {
                //if (sourceRow == targetRow || sourceRow == targetRow + 1) return;

                GridView view = grvRutas;
                RutasGeneradas row1 = ((ViewRecord)view.GetRow(targetRow)).GetObject() as RutasGeneradas;
                //RutasGeneradas row2 = ((ViewRecord)view.GetRow(targetRow + 1)).GetObject() as RutasGeneradas;
                RutasGeneradas dragRow = ((ViewRecord)view.GetRow(sourceRow)).GetObject() as RutasGeneradas;
                int val1 = row1.OrdenRutas;
                //if (row2 == null)
                //    dragRow.OrdenRutas = val1 + 1;
                //else
                //{
                //int val2 = row2.OrdenRutas;
                //dragRow.OrdenRutas = (val1 + val2) / 2;
                int val2 = dragRow.OrdenRutas;
                dragRow.OrdenRutas = val1;
                if (val2 < val1)
                {
                    val1--;
                    row1.OrdenRutas = val1;
                    val1--;
                    //row2.OrdenRutas = val1;
                    //val1--;
                    row1.Save();
                    while (val1 >= val2)
                    {
                        RutasGeneradas row = ((ViewRecord)view.GetRow(val1)).GetObject() as RutasGeneradas;
                        if (row == dragRow)
                            row = ((ViewRecord)view.GetRow(val1 + 1)).GetObject() as RutasGeneradas;
                        row.OrdenRutas = val1;
                        val1--;
                        row.Save();
                    }
                }
                else
                {

                    val1++;
                    row1.OrdenRutas = val1;
                    val1++;
                    //row2.OrdenRutas = val1;
                    //val1++;
                    row1.Save();
                    //row2.OrdenRutas = val2++;

                    while (val1 <= val2)
                    {
                        RutasGeneradas row = ((ViewRecord)view.GetRow(val1 - 2)).GetObject() as RutasGeneradas;
                        if (row == dragRow)
                            row = ((ViewRecord)view.GetRow(val1)).GetObject() as RutasGeneradas;
                        row.OrdenRutas = val1;
                        val1++;
                        row.Save();
                    }
                }
                //}

                dragRow.Save();
                dragRow.Session.CommitTransaction();
                ((XPView)grdRutas.DataSource).Reload();
                grvRutas.ClearSelection();
                grvRutas.FocusedRowHandle = dragRow.OrdenRutas - 1;
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
    }
}
