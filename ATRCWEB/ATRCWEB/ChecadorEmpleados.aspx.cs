using ATRCBASE.BL;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using static ATRCBASE.BL.Enums;

namespace ATRCWEB
{
    public partial class ChecadorEmpleados : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            bteNumEmpleado.Focus();
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Session["Entradas"] = new List<HistoricoChecadas>();
                Session["Salidas"] = new List<HistoricoChecadas>();
                //var camara = Cameras.DeclareDevice().Named("").WithDevicePath("").Memorize();
                //camara.Default.SavePicture(new PictureSize(640, 480), "Test2.jpg", 20);
            }
        }

        protected void Callback_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Parameter))
            {
                string[] valor = e.Parameter.Split('|');
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                TipoIdentificacion Tipo = TipoIdentificacion.Gafete;
                UsuarioChecador Usuario = null;
                if (!string.IsNullOrEmpty(valor[0]))
                {
                    if (valor[1] == "gafete")
                    {
                        Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(valor[0]), false);
                    }
                    else
                    {
                        Tipo = TipoIdentificacion.Manual;
                        Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(valor[0]), true);
                    }
                    if (Usuario != null)
                    {
                        if (Usuario.Notificaciones.Count <= 0)
                        {
                            Usuario.HistoricoChecadas.Filter = new NullOperator("HoraChecadaSalida");
                            if (Usuario.HistoricoChecadas.Count > 0)
                            {
                                HistoricoChecadas Checada = Usuario.HistoricoChecadas[Usuario.HistoricoChecadas.Count - 1];
                                if (Checada.HoraChecadaSalida == null)
                                    e.Result = ModificarChecada(Checada, Tipo);
                                else
                                {
                                    e.Result = CrearChecada(Unidad, Usuario, Tipo);
                                }
                            }
                            else
                            {
                                e.Result = CrearChecada(Unidad, Usuario, Tipo);
                            }
                        }
                        else
                        {
                            e.Result = "Favor de pasar con " + Usuario.Notificaciones[0].Responsable.Usuario.Nombre;
                        }
                    }
                    else
                    {
                        Session["imgfoto"] = null;
                        e.Result = "Usuario no registrado";
                    }
                }
                else
                {
                    Session["imgfoto"] = null;
                }
            }
        }

        protected void CallbackPanel_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            Control img = CallbackPanel.FindControl("bbimg");
            BootstrapBinaryImage bbi = (BootstrapBinaryImage)img;
            if (string.IsNullOrEmpty(e.Parameter))
            {

                bbi.Value = (byte[])Session["imgfoto"];
            }
            else
            {
                bbi.Value = null;
            }
        }

        protected void lstEntradas_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            lstEntradas.DataSource = Session["Entradas"];
            lstEntradas.DataBind();
        }

        protected void lstSalida_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            lstSalida.DataSource = Session["Salidas"];
            lstSalida.DataBind();
        }

        #endregion

        #region Metodo
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
        private string CrearChecada(UnidadDeTrabajo Unidad, UsuarioChecador Usuario, TipoIdentificacion Identificacion)
        {


            DateTime Dia = DateTime.Now;
            HistoricoChecadas Checada = new HistoricoChecadas(Unidad);
            Checada.FechaChecada = Dia.Date;
            Checada.HoraChecadaEntrada = Dia.AddTicks(-(Dia.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;
            Checada.HoraChecadaSalida = null;
            Checada.TipoIdentificacionEntrada = Identificacion;
            Checada.Usuario = Usuario;
            Checada.Save();
            Unidad.CommitChanges();
            Session["imgfoto"] = ObtenerFoto(Usuario.Usuario.Imagen == null ? "" : Usuario.Usuario.Imagen.Archivo);
            List<HistoricoChecadas> Entradas = (List<HistoricoChecadas>)Session["Entradas"];
            Entradas.Add(Checada);
            Session["Entradas"] = Entradas;
            return "Entrada registrada " + Usuario.Usuario.Nombre;
        }

        private string ModificarChecada(HistoricoChecadas Checada, TipoIdentificacion Identificacion)
        {
            DateTime Dia = DateTime.Now;
            Checada.HoraChecadaSalida = Dia.AddTicks(-(Dia.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;
            Checada.TipoIdentificacionSalida = Identificacion;
            Checada.Save();
            Checada.Session.CommitTransaction();
            Session["imgfoto"] = ObtenerFoto(Checada.Usuario.Usuario.Imagen == null ? "" : Checada.Usuario.Usuario.Imagen.Archivo);
            List<HistoricoChecadas> Entradas = (List<HistoricoChecadas>)Session["Salidas"];
            Entradas.Add(Checada);
            Session["Salidas"] = Entradas;
            return "Salida registrada " + Checada.Usuario.Usuario.Nombre;
        }
        #endregion

    }
}