using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace UNIDADES.WIN
{
    public partial class xfrmBusquedaUnidades : xfrmBase
    {
        public xfrmBusquedaUnidades()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo unidad;
        private void xfrmBusquedaUnidades_Load(object sender, EventArgs e)
        {
            ((DevExpress.Utils.PeekFormButton)fypEdicion.OptionsButtonPanel.Buttons[0]).Visible = Utilerias.VisibilidadPermiso("DetallesUnidad") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((DevExpress.Utils.PeekFormButton)fypEdicion.OptionsButtonPanel.Buttons[1]).Visible = Utilerias.VisibilidadPermiso("ModificarUnidad") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((DevExpress.Utils.PeekFormButton)fypEdicion.OptionsButtonPanel.Buttons[2]).Visible = Utilerias.VisibilidadPermiso("EstadoUnidad") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            ((DevExpress.Utils.PeekFormButton)fypEdicion.OptionsButtonPanel.Buttons[3]).Visible = Utilerias.VisibilidadPermiso("EliminarUnidad") == DevExpress.XtraBars.BarItemVisibility.Always ? true : false;
            unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));

            GroupOperator goSeccion = new GroupOperator(GroupOperatorType.Or);
            goSeccion.Operands.Add(new BinaryOperator("EsSeccion", false));
            goSeccion.Operands.Add(new NullOperator("EsSeccion"));

            goMain.Operands.Add(go);
            goMain.Operands.Add(goSeccion);
            XPView Unidades = new XPView(unidad, typeof(Unidad), "Oid;Nombre", goMain);
            Unidades.Sorting.Add(new SortingCollection(new SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            lueUnidad.Properties.DataSource = Unidades;
        }

        private void lueUnidad_EditValueChanged(object sender, EventArgs e)
        {
            if (lueUnidad.EditValue != null)
            {
                Unidad UnidadCamion = (Unidad)((ViewRecord)lueUnidad.EditValue).GetObject();
                List<Unidad> Unidades = new List<Unidad>();
                Unidades.Add(UnidadCamion);
                vGridControl1.DataSource = Unidades;
                fypEdicion.ShowPopup();
                CargarImagen(UnidadCamion);
                

            }
            else
            {
                vGridControl1.DataSource = null;
                picFoto.BackgroundImage = UNIDADES.WIN.Properties.Resources.car;
                fypEdicion.HidePopup();
            }
        }

        private void fypEdicion_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {

            switch (e.Button.Caption)
            {
                case "Modificar":
                    xfrmUnidad xfrm = new xfrmUnidad();
                    xfrm.Unidad = unidad;
                    xfrm.esModificacion = true;
                    xfrm.UnidadCamion = (Unidad)((ViewRecord)lueUnidad.EditValue).GetObject();
                    xfrm.ShowDialog();
                    vGridControl1.Refresh();
                    vGridControl1.RefreshDataSource();
                    CargarImagen((Unidad)((ViewRecord)lueUnidad.EditValue).GetObject());
                    break;
                case "Eliminar":
                    Unidad Unidad = (Unidad)((ViewRecord)lueUnidad.EditValue).GetObject();
                    if (Unidad != null)
                    {
                        if (XtraMessageBox.Show("¿Está seguro de querer eliminar la unidad '" + Unidad.Nombre + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Unidad.Delete();
                            Unidad.Session.CommitTransaction();
                            (lueUnidad.Properties.DataSource as XPView).Reload();
                            vGridControl1.DataSource = null;
                            picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                            fypEdicion.HidePopup();
                        }
                    }
                    break;
                case "Detalle de unidad":
                    ReportPrintTool repDetalleUnidad = new ReportPrintTool(new REPORTES.Unidades.DetalleDeUnidad(Convert.ToInt32(((ViewRecord)lueUnidad.EditValue)["Oid"])));
                    repDetalleUnidad.ShowPreview();
                    break;
                case "Estado":
                    Unidad UnidadCamion = (Unidad)((ViewRecord)lueUnidad.EditValue).GetObject();
                    XtraInputBoxArgs args = new XtraInputBoxArgs();
                    args.Caption = "Unidad " + UnidadCamion.Nombre;
                    args.Prompt = "Estado:";
                    ComboBoxEdit editor = new ComboBoxEdit();
                    editor.Properties.Items.Add(Enums.EstadoUnidad.Vendido);
                    editor.Properties.Items.Add(Enums.EstadoUnidad.FueraServicio);
                    editor.Properties.Items.Add(Enums.EstadoUnidad.Taller);
                    args.Editor = editor;
                    var result = XtraInputBox.Show(args);
                    if (result != null)
                    {
                        UnidadCamion.EstadoUnidad = (Enums.EstadoUnidad)result;
                        UnidadCamion.UltimoEstado = DateTime.Now;
                        UnidadCamion.Save();
                        UnidadCamion.Session.CommitTransaction();
                        (lueUnidad.Properties.DataSource as XPView).Reload();
                        vGridControl1.DataSource = null;
                        picFoto.EditValue = null;
                        picFoto.BackgroundImage = UNIDADES.WIN.Properties.Resources.car;
                        fypEdicion.HidePopup();
                    }
                    break;
            }

        }

        private void CargarImagen(Unidad UnidadCamion)
        {
            if (UnidadCamion.EstadoUnidad == Enums.EstadoUnidad.Taller)
            {
                picFoto.EditValue = UNIDADES.WIN.Properties.Resources.Taller;
                if (UnidadCamion.Imagen != null)
                {
                    if (!string.IsNullOrEmpty(UnidadCamion.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(UnidadCamion.Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        picFoto.BackgroundImage = returnImage;
                    }
                    else
                    {
                        picFoto.BackgroundImage = UNIDADES.WIN.Properties.Resources.car;
                    }
                }
                else
                {
                    picFoto.BackgroundImage = UNIDADES.WIN.Properties.Resources.car;
                }
            }
            else
            {
                if (UnidadCamion.Imagen != null)
                {
                    if (!string.IsNullOrEmpty(UnidadCamion.Imagen.Archivo))
                    {
                        byte[] image = Convert.FromBase64String(UnidadCamion.Imagen.Archivo);
                        MemoryStream stream = new MemoryStream(image);
                        Image returnImage = Image.FromStream(stream);
                        picFoto.EditValue = returnImage;
                        picFoto.BackgroundImage = null;
                    }
                    else
                    {
                        picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                        picFoto.BackgroundImage = null;
                    }
                }
                else
                {
                    picFoto.EditValue = UNIDADES.WIN.Properties.Resources.car;
                    picFoto.BackgroundImage = null;
                }
            }
        }

        private void fypEdicion_Showing(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            fypEdicion.OwnerControl.FindForm().TopMost = false;
        }

        private void fypEdicion_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
           // fypEdicion.OwnerControl.FindForm().b();
        }
    }
}
