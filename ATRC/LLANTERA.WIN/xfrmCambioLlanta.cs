using ALMACEN.BL;
using ATRCBASE.BL;
using ATRCBASE.WIN;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using LLANTERA.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNIDADES.BL;

namespace LLANTERA.WIN
{
    public partial class xfrmCambioLlanta : xfrmBase
    {
        public xfrmCambioLlanta()
        {
            InitializeComponent();
        }
        UnidadDeTrabajo unidad;
        Unidad Unidad = null;
        private void xfrmCambioLlanta_Load(object sender, EventArgs e)
        {
            unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView Unidades = new XPView(unidad, typeof(UNIDADES.BL.Unidad), "Oid;Nombre;TipoUnidad", go);
            lueUnidad.Properties.DataSource = Unidades;
            picFoto.Properties.ContextMenu = new ContextMenu();
        }

        private void lueUnidad_EditValueChanged(object sender, EventArgs e)
        {
            ViewRecord vUnidad = lueUnidad.EditValue as ViewRecord;
            if(vUnidad != null)
            {
                GroupOperator go = new GroupOperator();
                go.Operands.Add(new BinaryOperator("EsUtilizado", false));
                go.Operands.Add(new BinaryOperator("Estado", Enums.EstadoSalida.Entregado));
                go.Operands.Add(new BinaryOperator("Articulo.TipoArticulo", Enums.TipoArticulo.Llantas));
                go.Operands.Add(new BinaryOperator("Unidad.Oid", Convert.ToInt32(vUnidad["Oid"])));
                XPView Llantas = new XPView(unidad, typeof(SalidaArticulo), "Oid,Factura.Serie;Factura.Medida;Factura.Marca.Nombre", go);

                switch (vUnidad["TipoUnidad"])
                {
                    case Enums.TipoUnidad.Camion:
                        picFoto.Image = LLANTERA.WIN.Properties.Resources.bus;
                        break;
                    case Enums.TipoUnidad.Automovil:
                        picFoto.Image = LLANTERA.WIN.Properties.Resources.car;
                        break;
                    case Enums.TipoUnidad.Maquinaria:
                        picFoto.Image = LLANTERA.WIN.Properties.Resources.f150;
                        break;
                    case Enums.TipoUnidad.Panel:
                        picFoto.Image = LLANTERA.WIN.Properties.Resources.panel;
                        break;
                }
                lueLlantaFrontalIzquierda.Properties.DataSource = Llantas;
                lueFrontalDerecho.Properties.DataSource = Llantas;
                lueTraseraInteriorChofer.Properties.DataSource = Llantas;
                lueTraseraInteriorEstribo.Properties.DataSource = Llantas;
                lueTraseroExteriorChofer.Properties.DataSource = Llantas;
                lueTraseroExteriorEstribo.Properties.DataSource = Llantas;

                Unidad = ((ViewRecord)lueUnidad.EditValue).GetObject() as Unidad;
                lblFrontalIzquierda.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaFrontalIzquierdaChofer");
                lblFrontalDerecha.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaFrontalDerechaEstribo");
                lblTraseraInteriorChofer.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraInteriorChofer");
                lblTraseraInteriorEstribo.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraInteriorEstribo");
                lblTraseraExteriorChofer.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraExteriorChofer");
                lblTraseraExteriorEstribo.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraExteriorEstribo");

                if (Unidad.TipoUnidad != Enums.TipoUnidad.Camion)
                {
                    lciTraseraInteriorChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciTraseraInteriorEstribo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciDetalleTraseraInteriorChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciDetalleTraseraInteriorEstribo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                else
                {
                    lciTraseraInteriorChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciTraseraInteriorEstribo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciDetalleTraseraInteriorChofer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lciDetalleTraseraInteriorEstribo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
            }
            else
            {
                picFoto.Image = null;
            }
            
        }

        private void lueLlantaFrontalIzquierda_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                ViewRecord vSalida = e.Value as ViewRecord;
                if (vSalida != null)
                    e.DisplayText = vSalida["Factura.Marca.Nombre"] + " " + vSalida["Factura.Serie"] + " " + vSalida["Factura.Medida"];
                else
                    e.DisplayText = "[Seleccioné]";
            }else
            {
                e.DisplayText = "[Seleccioné]";
            }
        }

        private void lueLlantaFrontalIzquierda_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueLlantaFrontalIzquierda);
        }

        private void lueFrontalDerecho_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueFrontalDerecho);
        }

        private void lueTraseraInteriorEstribo_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueTraseraInteriorEstribo);
        }

        private void lueTraseroExteriorChofer_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueTraseroExteriorChofer);
        }

        private void lueTraseroExteriorEstribo_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueTraseroExteriorEstribo);
        }

        private void lueTraseraInteriorChofer_EditValueChanged(object sender, EventArgs e)
        {
            AsignarLlanta(lueTraseraInteriorChofer);
        }

        private void AsignarLlanta(LookUpEdit lue)
        {
            if (lue.EditValue != null)
            {
                if (XtraMessageBox.Show("¿Desea asignar la llanta a esta posición?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ViewRecord vSalida = lue.EditValue as ViewRecord;
                    SalidaArticulo Salida = vSalida.GetObject() as SalidaArticulo;
                    Articulo Llanta = null;
                    string PosicionLlanta = string.Empty;
                    string Propiedad = string.Empty;
                    switch (lue.Name)
                    {
                        case "lueLlantaFrontalIzquierda":
                            Llanta = Unidad.GetMemberValue("LlantaFrontalIzquierdaChofer") as Articulo;
                            Unidad.SetMemberValue("LlantaFrontalIzquierdaChofer", Salida.Articulo);
                            PosicionLlanta = "Frontal izquierda";
                            Propiedad = "LlantaFrontalIzquierdaChofer";
                            break;
                        case "lueFrontalDerecho":
                            Llanta = Unidad.GetMemberValue("LlantaFrontalDerechaEstribo") as Articulo;
                            Unidad.SetMemberValue("LlantaFrontalDerechaEstribo", Salida.Articulo);
                            PosicionLlanta = "Frontal derecha";
                            Propiedad = "LlantaFrontalDerechaEstribo";
                            break;
                        case "lueTraseraInteriorChofer":
                            Llanta = Unidad.GetMemberValue("LlantaTraseraInteriorChofer") as Articulo;
                            Unidad.SetMemberValue("LlantaTraseraInteriorChofer", Salida.Articulo);
                            PosicionLlanta = "Trasera interior chofer";
                            Propiedad = "LlantaTraseraInteriorChofer";
                            break;
                        case "lueTraseraInteriorEstribo":
                            Llanta = Unidad.GetMemberValue("LlantaTraseraInteriorEstribo") as Articulo;
                            Unidad.SetMemberValue("LlantaTraseraInteriorEstribo", Salida.Articulo);
                            PosicionLlanta = "Trasera interior estribo";
                            Propiedad = "LlantaTraseraInteriorEstribo";
                            break;
                        case "lueTraseroExteriorChofer":
                            Llanta = Unidad.GetMemberValue("LlantaTraseraExteriorChofer") as Articulo;
                            Unidad.SetMemberValue("LlantaTraseraExteriorChofer", Salida.Articulo);
                            PosicionLlanta = "Trasera exterior chofer";
                            Propiedad = "LlantaTraseraExteriorChofer";
                            break;
                        case "lueTraseroExteriorEstribo":
                            Llanta = Unidad.GetMemberValue("LlantaTraseraExteriorEstribo") as Articulo;
                            Unidad.SetMemberValue("LlantaTraseraExteriorEstribo", Salida.Articulo);
                            PosicionLlanta = "Trasera exterior estribo";
                            Propiedad = "LlantaTraseraExteriorEstribo";
                            break;
                    }
                    Salida.EsUtilizado = true;
                    Unidad.Save();
                    if (Llanta != null)
                    {
                        XtraInputBoxArgs args = new XtraInputBoxArgs();
                        args.Caption = "¿Qué desea realizar con la llanta anterior?";
                        args.Prompt = "Registrarla como:";
                        ComboBoxEdit editor = new ComboBoxEdit();
                        editor.Properties.Items.Add(Enums.EstadoLlanta.Extra);
                        editor.Properties.Items.Add(Enums.EstadoLlanta.Merma);

                        args.Editor = editor;
                        args.DefaultResponse = Enums.EstadoLlanta.Extra;

                        var result = XtraInputBox.Show(args);
                        while (result == null)
                            result = XtraInputBox.Show(args);

                        if (result != null)
                        {
                            Llanta.EstadoLlanta = (Enums.EstadoLlanta)result;
                            if (Enums.EstadoLlanta.Extra == (Enums.EstadoLlanta)result)
                                Llanta.Facturas[0].Cantidad++;
                            Llanta.Save();
                        }
                    }

                    BitacoraCambiosDeLlanta.CrearRegistro(unidad, Unidad, PosicionLlanta, Llanta != null ? Llanta.Facturas[0] : null, ((Articulo)Unidad.GetMemberValue(Propiedad)).Facturas[0], Llanta != null ? Llanta.EstadoLlanta.ToString() : "");
                    unidad.CommitChanges();
                    ((XPView)lueFrontalDerecho.Properties.DataSource).Reload();
                    lue.EditValue = null;
                    lblFrontalIzquierda.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaFrontalIzquierdaChofer");
                    lblFrontalDerecha.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaFrontalDerechaEstribo");
                    lblTraseraInteriorChofer.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraInteriorChofer");
                    lblTraseraInteriorEstribo.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraInteriorEstribo");
                    lblTraseraExteriorChofer.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraExteriorChofer");
                    lblTraseraExteriorEstribo.Text = "<u><b>Llanta Actual:</b></u><br>" + ObtenerDetalleLlanta("LlantaTraseraExteriorEstribo");
                }
                else
                {
                    lue.EditValue = null;
                }
            }
            
        }

        private string ObtenerDetalleLlanta(string Propiedad)
        {
            Articulo articulo = Unidad.GetMemberValue(Propiedad) as Articulo;
            if (articulo != null)
                return articulo.Facturas[0].Marca.Nombre + " " + articulo.Facturas[0].Serie + " R-" + articulo.Facturas[0].Medida;
            else
                return string.Empty;
        }
    }
}
