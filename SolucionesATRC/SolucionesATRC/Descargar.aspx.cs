using ATRCBASE.BL;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using RUTAS.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolucionesATRC
{
    public partial class Descargar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString.Count > 0)
                {
                    if (Request.QueryString.Count > 1)
                    {
                        string ID = ATRCBASE.BL.Utilerias.DesencriptarString(Request.Params[0]);
                        UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                        REPORTES.Rutas.AclaracionesPedido Rutas = new REPORTES.Rutas.AclaracionesPedido(Convert.ToInt32(ID));

                        using (MemoryStream ms = new MemoryStream())
                        {
                            Rutas.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = false });
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-disposition", "attachment;filename=Aclaracion" + ID + ".pdf");
                            Response.Buffer = true;
                            ms.WriteTo(Response.OutputStream);
                            Response.End();
                        }
                    }
                    else
                    {

                        string ID = ATRCBASE.BL.Utilerias.DesencriptarString(Request.Params[0]);
                        UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                        PedidoRutas Pedido = Unidad.GetObjectByKey<PedidoRutas>(Convert.ToInt32(ID));
                        REPORTES.Rutas.RutasDePedido Rutas = new REPORTES.Rutas.RutasDePedido(Pedido);

                        using (MemoryStream ms = new MemoryStream())
                        {
                            Rutas.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = false });
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-disposition", "attachment;filename=" + Pedido.Nombre.Trim() + ".pdf");
                            Response.Buffer = true;
                            ms.WriteTo(Response.OutputStream);
                            Response.End();
                        }
                    }
                }
                else
                {
                    if (Session["Descargar"] != null)
                    {
                        using (MemoryStream ms = new MemoryStream(Session["Descargar"] as byte[]))
                        {
                            Response.ContentType = "application/Excel";
                            Response.AddHeader("content-disposition", "attachment;filename=" + Session["NombreDocumentoRuta"] as string);
                            Response.Buffer = true;
                            ms.WriteTo(Response.OutputStream);
                            Response.End();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }
    }
}