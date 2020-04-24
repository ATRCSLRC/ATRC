using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = Utilerias.VisibilidadPermiso("RutasFijasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = Utilerias.VisibilidadPermiso("NuevaRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = Utilerias.VisibilidadPermiso("ModificarRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[3])).Visible = Utilerias.VisibilidadPermiso("EliminarRutasGenerar") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
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
                            foreach (Int32 ID in xfrmPlantilla.PlantillaRutas)
                            {
                                PlantillaRutas plantilla = Unidad.GetObjectByKey<PlantillaRutas>(ID);
                                if (plantilla != null)
                                {
                                    XPView PlantillaRutasExtras = new XPView(UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), typeof(PlantillaRutaFija), "Oid;Ruta;TipoRuta;Servicio;Turno;HoraEntrada;HoraSalida;ChoferEntrada;ChoferSalida;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios;ComentariosFacturacion", new BinaryOperator("PlantillaRutas", plantilla.Oid));
                                    foreach (ViewRecord viewRuta in PlantillaRutasExtras)
                                    {
                                        RutasGeneradas Ruta = new RutasGeneradas(Unidad);
                                        Ruta.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                                        Ruta.Ruta = viewRuta["Ruta"].ToString();
                                        Ruta.Servicio = viewRuta["Servicio"] == null ? null : Unidad.GetObjectByKey<Servicio>(Convert.ToInt32(viewRuta["Servicio"]));
                                        Ruta.Turno = viewRuta["Turno"] == null ? null : Unidad.GetObjectByKey<BL.Turno>(Convert.ToInt32(viewRuta["Turno"]));
                                        Ruta.FechaRuta = dteFecha.DateTime.Date;
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

                                        #region Historial
                                        HistorialRutaGenerada HistorialRutaGenerada = new HistorialRutaGenerada(Unidad);
                                        HistorialRutaGenerada.TipoRuta = (TipoRuta)viewRuta["TipoRuta"];
                                        HistorialRutaGenerada.Ruta = viewRuta["Ruta"].ToString();
                                        HistorialRutaGenerada.FechaRuta = dteFecha.DateTime.Date; 
                                        HistorialRutaGenerada.Servicio = viewRuta["Servicio"] == null ? null : Unidad.GetObjectByKey<Servicio>(Convert.ToInt32(viewRuta["Servicio"]));
                                        HistorialRutaGenerada.Turno = viewRuta["Turno"] == null ? null : Unidad.GetObjectByKey<BL.Turno>(Convert.ToInt32(viewRuta["Turno"]));
                                        HistorialRutaGenerada.EsRutaExtra = false;
                                        HistorialRutaGenerada.HoraEntrada = viewRuta["HoraEntrada"] == null ? null : (DateTime?)viewRuta["HoraEntrada"];
                                        HistorialRutaGenerada.HoraSalida = viewRuta["HoraSalida"] == null ? null : (DateTime?)viewRuta["HoraSalida"];
                                        HistorialRutaGenerada.RutaCompleta = (bool)viewRuta["RutaCompleta"];
                                        HistorialRutaGenerada.ChoferEntrada = viewRuta["ChoferEntrada"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferEntrada"]));
                                        HistorialRutaGenerada.PagarChoferEntrada = (bool)viewRuta["PagarChoferEntrada"];
                                        HistorialRutaGenerada.ChoferSalida = viewRuta["ChoferSalida"] == null ? null : Unidad.GetObjectByKey<Usuario>(Convert.ToInt32(viewRuta["ChoferSalida"]));
                                        HistorialRutaGenerada.PagarChoferSalida = (bool)viewRuta["PagarChoferSalida"];
                                        HistorialRutaGenerada.Comentarios = viewRuta["Comentarios"].ToString();
                                        HistorialRutaGenerada.ComentariosFacturacion = viewRuta["ComentariosFacturacion"] != null ? viewRuta["ComentariosFacturacion"].ToString() : "";
                                        HistorialRutaGenerada.UsuarioModificacion = ATRCBASE.BL.Utilerias.ObtenerUsuarioActual(Unidad);
                                        HistorialRutaGenerada.HorarioModificacion = DateTime.Now;
                                        HistorialRutaGenerada.Save();
                                        Ruta.Historial.Add(HistorialRutaGenerada);
                                        #endregion
                                        Ruta.Save();
                                        //Rutas.Add(Ruta);

                                    }
                                    Unidad.CommitChanges();
                                }
                            }
                        }
                        Loading.CloseWaitForm();
                        ((XPView)grdRutas.DataSource).Reload();
                        break;

                    case "Ruta nueva":
                        xfrmRutasFijas xfrmAgregar = new xfrmRutasFijas();
                        xfrmAgregar.EsPlantilla = false;
                        xfrmAgregar.EsModificacion = false;
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
                                Loading.CloseWaitForm();
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[0])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[1])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[2])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[5])).Visible = true;
                                ((PeekFormButton)(flpAcciones.OptionsButtonPanel.Buttons[4])).Visible = false;
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
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Empresa.Oid", lueEmpresa.EditValue));
            go.Operands.Add(new BinaryOperator("FechaRuta", dteFecha.DateTime.Date));
            Rutas = new XPView(Unidad, typeof(RutasGeneradas), "Oid;Ruta;TipoRuta;EsRutaExtra;Servicio.TipoUnidad;Turno.Descripcion;HoraEntrada;HoraSalida;ChoferEntrada.Nombre;ChoferSalida.Nombre;RutaCompleta;PagarChoferEntrada;PagarChoferSalida;Comentarios", go);
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
    }
}
