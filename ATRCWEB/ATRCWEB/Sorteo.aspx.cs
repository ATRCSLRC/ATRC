using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ATRCWEB
{
    public partial class Sorteo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsCallback & !Page.IsCallback)
            {
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                Session["Session"] = Unidad;
                
                grdEmpleados.DataBind();
            }
        }

        protected void grdEmpleados_DataBinding(object sender, EventArgs e)
        {
            UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Session"];
            XPView Empleados = new XPView(Unidad, typeof(Usuario));
            Empleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            Empleados.Criteria = new BinaryOperator("Activo", true);
            grdEmpleados.DataSource = Empleados;
        }

        public byte[] ObtenerFoto(string Imagen)
        {
            if (!string.IsNullOrEmpty(Imagen))
            {
                byte[] image = Convert.FromBase64String(Imagen);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(image);
                Image returnImage = Image.FromStream(stream);
                return stream.ToArray();
            }
            return null;

        }

        protected void CallbackPanel_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            Control img = CallbackPanel.FindControl("imgFoto");
            BootstrapBinaryImage bbi = (BootstrapBinaryImage)img;
            Control lbl = CallbackPanel.FindControl("lblGanador");
            ASPxLabel bbiGanador = (ASPxLabel)lbl;
            if (!string.IsNullOrEmpty(e.Parameter))
            {
                UnidadDeTrabajo Unidad = (UnidadDeTrabajo)Session["Session"];
                Usuario Usuario = Unidad.FindObject<Usuario>(new BinaryOperator("NumEmpleado", Convert.ToInt32(e.Parameter)));
                if (Usuario != null)
                {
                    lblGanador.Text = Usuario.NumEmpleado.ToString() + " - " + Usuario.Nombre;
                    bbi.Value = ObtenerFoto(Usuario.Imagen == null ? null : Usuario.Imagen.Archivo);
                }
            }
            else
            {
                bbi.Value = null;
                lblGanador.Text = string.Empty;
            }
        }
    }
}