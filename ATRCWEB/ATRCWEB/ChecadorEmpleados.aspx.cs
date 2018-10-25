using ATRCBASE.BL;
using CHECADOR.BL;
using DevExpress.Data.Filtering;
using DevExpress.Web.Bootstrap;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            Response.Cache.SetNoStore();
            bteNumEmpleado.Focus();
            if (!Page.IsCallback & !Page.IsPostBack)
            {
                Session["Entradas"] = new List<string>();
                Session["Salidas"] = new List<string>();
                //var camara = Cameras.DeclareDevice().Named("").WithDevicePath("").Memorize();
                //camara.Default.SavePicture(new PictureSize(640, 480), "Test2.jpg", 20);
            }
            //Session["OidAdministrador"] = 1;
           // ATRCBASE.BL.Utilerias.sessionID = Session.SessionID;
        }

        protected void Callback_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {

            try
            {

                if (!string.IsNullOrEmpty(e.Parameter))
                {
                    string[] valor = e.Parameter.Split('|');
                    using (SqlConnection sql = new SqlConnection("data source=192.168.0.123\\ATRCSERVER;user id=sa;password=@TRCSistemas;initial catalog=ATRCPRODUCCION;Persist Security Info=true"))
                    {

                        string Query = string.Empty;
                        TipoIdentificacion Tipo = TipoIdentificacion.Gafete;
                        if (!string.IsNullOrEmpty(valor[0]) & Int32.TryParse(valor[0], out int c))
                        {
                            if (valor[1] != "gafete")
                            {
                                Tipo = TipoIdentificacion.Manual;
                                Query = "SELECT ch_UsuarioChecador.OID,gen_Usuario.NumEmpleado,gen_Usuario.Nombre FROM gen_Usuario INNER JOIN " +
                                "ch_UsuarioChecador ON gen_Usuario.OID = ch_UsuarioChecador.Usuario WHERE gen_Usuario.GCRecord IS NULL AND gen_Usuario.NumEmpleado = @Usuario";
                            }
                            else
                            {
                                Query = "SELECT ch_UsuarioChecador.OID,gen_Usuario.NumEmpleado,gen_Usuario.Nombre FROM gen_Usuario INNER JOIN " +
                                "ch_UsuarioChecador ON gen_Usuario.OID = ch_UsuarioChecador.Usuario WHERE gen_Usuario.GCRecord IS NULL AND gen_Usuario.IDCard = @Usuario";
                            }

                            sql.Open();
                            using (SqlCommand SqlUsuario = new SqlCommand(Query))
                            {
                                SqlUsuario.Connection = sql;
                                SqlUsuario.CommandType = CommandType.Text;
                                SqlUsuario.Parameters.AddWithValue("@Usuario", Convert.ToInt32(valor[0]));
                                int IDUsuario = 0;
                                int NumEmpleado = 0;
                                string Nombre = string.Empty;
                                using (SqlDataReader reader = SqlUsuario.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        IDUsuario = Convert.ToInt32(reader.GetValue(0));
                                        NumEmpleado = Convert.ToInt32(reader.GetValue(1));
                                        Nombre = reader.GetValue(2).ToString();
                                    }
                                }
                                if (IDUsuario > 0)
                                    e.Result = BuscarChecada(IDUsuario, Tipo, NumEmpleado, Nombre, sql);
                                else
                                    e.Result = UsuarioExiste(Convert.ToInt32(valor[0]), Tipo, sql);
                            }
                            sql.Close();
                        }
                        else
                        {
                            e.Result = "Usuario no registrado";
                        }
                    }


                    //using (UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo())
                    //{
                    //    TipoIdentificacion Tipo = TipoIdentificacion.Gafete;
                    //    if (!string.IsNullOrEmpty(valor[0]) & Int32.TryParse(valor[0], out int c))
                    //    {
                    //        if (valor[1] == "gafete")
                    //        {
                    //            Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(valor[0]), false);
                    //        }
                    //        else
                    //        {
                    //            Tipo = TipoIdentificacion.Manual;
                    //            Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(UtileriasXPO.ObtenerNuevaUnidadDeTrabajo(), Convert.ToInt32(valor[0]), true);
                    //        }
                    //        if (Usuario != null)
                    //        {
                    //            if (Usuario.Notificaciones.Count <= 0)
                    //            {
                    //                Usuario.HistoricoChecadas.Filter = new NullOperator("HoraChecadaSalida");
                    //                //GroupOperator go = new GroupOperator();
                    //                //go.Operands.Add(new NullOperator("HoraChecadaSalida"));
                    //                //go.Operands.Add(new BinaryOperator("Usuario.Oid", Usuario.Oid ));
                    //                //XPView xp = new XPView(Unidad, typeof(HistoricoChecadas), "Oid;FechaChecada", go);
                    //                if (Usuario.HistoricoChecadas.Count > 0)
                    //                {
                    //                    HistoricoChecadas Checada = Usuario.HistoricoChecadas[Usuario.HistoricoChecadas.Count - 1];
                    //                    if (Checada.HoraChecadaSalida == null)
                    //                        e.Result = ModificarChecada(Checada, Tipo);
                    //                    else
                    //                    {
                    //                        e.Result = CrearChecada(Unidad, Usuario, Tipo);
                    //                    }
                    //                }
                    //                else
                    //                {
                    //                    e.Result = CrearChecada(Unidad, Usuario, Tipo);
                    //                }
                    //            }
                    //            else
                    //            {
                    //                e.Result = "Favor de pasar con " + Usuario.Notificaciones[0].Responsable.Usuario.Nombre;
                    //                //Session["imgfoto"] = null;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            //Session["imgfoto"] = null;
                    //            e.Result = "Usuario no registrado";
                    //        }
                    //    }
                    //    else
                    //    {
                    //        //Session["imgfoto"] = null;
                    //        e.Result = "Usuario no registrado";
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }

        }

        private string UsuarioExiste(int IDUsuario, TipoIdentificacion Tipo, SqlConnection sql)
        {
            string Query = string.Empty;
            int ID = 0;
            int NumEmpleado = 0;
            string Nombre = string.Empty;
            if (Tipo == TipoIdentificacion.Manual)
            {
                Query = "SELECT OID, NumEmpleado, Nombre FROM gen_Usuario WHERE GCRecord IS NULL AND NumEmpleado = @Usuario";
            }
            else
            {
                Query = "SELECT OID, NumEmpleado, Nombre FROM gen_Usuario WHERE GCRecord IS NULL AND IDCard = @Usuario";
            }

            using (SqlCommand Usuario = new SqlCommand(Query))
            {
                Usuario.Connection = sql;
                Usuario.CommandType = CommandType.Text;
                Usuario.Parameters.AddWithValue("@Usuario", IDUsuario);
                using (SqlDataReader reader = Usuario.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ID = Convert.ToInt32(reader.GetValue(0));
                        NumEmpleado = Convert.ToInt32(reader.GetValue(1));
                        Nombre = reader.GetValue(2).ToString();
                    }
                }
            }
            if (ID <= 0)
                return "Usuario no registrado";
            else
                return UsuarioNuevo(ID, Tipo, NumEmpleado, Nombre, sql);
        }


        private string UsuarioNuevo(int IDUsuario, TipoIdentificacion Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
        {
            int IDChecador = 0;
            using (SqlCommand NuevoUsuario = new SqlCommand("INSERT INTO ch_UsuarioChecador(FechaAlta,UsuarioAlta,Usuario,OptimisticLockField)" +
                    "VALUES (@FechaAlta,@UsuarioAlta,@Usuario,@OptimisticLockField)"))
            {

                DateTime HoraChecada = DateTime.Now;
                NuevoUsuario.Connection = sql;
                NuevoUsuario.CommandType = CommandType.Text;
                NuevoUsuario.Parameters.AddWithValue("@UsuarioAlta", 1);
                NuevoUsuario.Parameters.AddWithValue("@Usuario", IDUsuario);
                NuevoUsuario.Parameters.AddWithValue("@FechaAlta", HoraChecada);
                NuevoUsuario.Parameters.AddWithValue("@OptimisticLockField", 0);
                int recordsAffected = NuevoUsuario.ExecuteNonQuery();
            }

            using (SqlCommand NuevoUsuario = new SqlCommand("SELECT OID FROM ch_UsuarioChecador WHERE GCRecord IS NULL AND Usuario = @Usuario"))
            {

                DateTime HoraChecada = DateTime.Now;
                NuevoUsuario.Connection = sql;
                NuevoUsuario.CommandType = CommandType.Text;
                NuevoUsuario.Parameters.AddWithValue("@Usuario", IDUsuario);
                IDChecador = Convert.ToInt32(NuevoUsuario.ExecuteScalar());
            }
            if(IDChecador > 0)
            {
                return BuscarChecada(IDChecador, Tipo, NumEmpleado, Nombre, sql);
            }else
            {
                return "Usuario no registrado";
            }

        }
        private string TieneNotificaciones(int IDUsuario, SqlConnection sql)
        {
            string Nombre = string.Empty;
            using (SqlCommand Busqueda = new SqlCommand("SELECT gen_Usuario.Nombre FROM ch_Notificaciones " +// WHERE (Receptor = @Usuario) AND (GCRecord IS NULL)"))
            "INNER JOIN ch_UsuarioChecador ON ch_Notificaciones.Responsable = ch_UsuarioChecador.OID " +
            "INNER JOIN gen_Usuario ON ch_UsuarioChecador.Usuario = gen_Usuario.OID " +
            "WHERE (ch_Notificaciones.Receptor = @Usuario) AND (ch_Notificaciones.GCRecord IS NULL)"))
            //"WHERE (Usuario = @Usuario) AND " +
            //"(HoraChecadaSalida IS NULL) AND (GCRecord IS NULL)"))
            {
                Busqueda.Connection = sql;
                Busqueda.CommandType = CommandType.Text;
                Busqueda.Parameters.AddWithValue("@Usuario", IDUsuario);
                using (SqlDataReader reader = Busqueda.ExecuteReader())
                    if (reader.Read())
                        Nombre = reader.GetValue(0).ToString();

                if (!string.IsNullOrEmpty(Nombre))
                    return "Favor de pasar con " + Nombre;
                else
                    return string.Empty;
            }
        }

        private string BuscarChecada(int IDUsuario, TipoIdentificacion Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
        {
            string Notificacion = TieneNotificaciones(IDUsuario, sql);
            if (string.IsNullOrEmpty(Notificacion))
            {
                using (SqlCommand Busqueda = new SqlCommand("SELECT OID FROM Ch_HistoricoChecadas WHERE (Usuario = @Usuario) AND (HoraChecadaSalida IS NULL) AND (GCRecord IS NULL)"))
                {
                    Busqueda.Connection = sql;
                    Busqueda.CommandType = CommandType.Text;
                    Busqueda.Parameters.AddWithValue("@Usuario", IDUsuario);
                    int IDChecador = Convert.ToInt32(Busqueda.ExecuteScalar());
                    if (IDChecador > 0)
                    {
                        return ModificarChecada(IDChecador, Tipo, NumEmpleado, Nombre, sql);
                    }
                    else
                    {
                        return NuevaChecada(IDUsuario, Tipo, NumEmpleado, Nombre, sql);
                    }
                }
            }else
            {
                return Notificacion;
            }
        }

        private string ModificarChecada(int IDUsuario, TipoIdentificacion Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
        {
            using (SqlCommand Update = new SqlCommand("UPDATE Ch_HistoricoChecadas SET HoraChecadaSalida=@Salida, TipoIdentificacionSalida =@TipoIdentificacionSalida WHERE OID=@OID"))
            {
                DateTime HoraChecada = DateTime.Now;
                Update.Connection = sql;  
                Update.CommandType = CommandType.Text;
                Update.Parameters.AddWithValue("@OID", IDUsuario);
                Update.Parameters.AddWithValue("@Salida", Math.Round((HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay).TotalSeconds));
                Update.Parameters.AddWithValue("@TipoIdentificacionSalida", Tipo);
                int recordsAffected = Update.ExecuteNonQuery();
                List<string> Salidas = (List<string>)Session["Salidas"];
                if (Salidas == null)
                    Salidas = new List<string>();
                Salidas.Add(NumEmpleado + " - " + Nombre + " Salida:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay);
                Session["Salidas"] = Salidas;
                return "Salida registrada " + Nombre;
            }
        }

        private string NuevaChecada(int IDUsuario, TipoIdentificacion Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
        {
            using (SqlCommand insert = new SqlCommand("INSERT INTO Ch_HistoricoChecadas(FechaAlta,FechaChecada,HoraChecadaEntrada,TipoIdentificacionEntrada,Usuario,OptimisticLockField)" +
                    "VALUES (@FechaAlta,@FechaChecada,@HoraChecadaEntrada,@TipoIdentificacionEntrada,@Usuario,@OptimisticLockField)"))
            {

                DateTime HoraChecada = DateTime.Now;
                insert.Connection = sql;
                insert.CommandType = CommandType.Text;
                insert.Parameters.AddWithValue("@FechaChecada", HoraChecada.Date);
                insert.Parameters.AddWithValue("@HoraChecadaEntrada", Math.Round((HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay).TotalSeconds));
                insert.Parameters.AddWithValue("@TipoIdentificacionEntrada", Tipo);
                insert.Parameters.AddWithValue("@Usuario", IDUsuario);
                insert.Parameters.AddWithValue("@FechaAlta", HoraChecada);
                insert.Parameters.AddWithValue("@OptimisticLockField", 0);
                int recordsAffected = insert.ExecuteNonQuery();

                List<string> Entradas = (List<string>)Session["Entradas"];
                if (Entradas == null)
                    Entradas = new List<string>();
                Entradas.Add(NumEmpleado + " - " + Nombre + " Entrada:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay);
                Session["Entradas"] = Entradas;

                return "Entrada registrada " + Nombre;
                
            }
        }


        protected void CallbackPanel_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {
            //Control img = CallbackPanel.FindControl("bbimg");
            //BootstrapBinaryImage bbi = (BootstrapBinaryImage)img;
            //if (string.IsNullOrEmpty(e.Parameter))
            //{
            //    if (Session["imgfoto"] != null)
            //        bbi.Value = (byte[])Session["imgfoto"];
            //    else
            //        bbi.Value = null;
            //}
            //else
            //{
            //    bbi.Value = null;
            //}
           
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
        //private string CrearChecada(UnidadDeTrabajo Unidad, UsuarioChecador Usuario, TipoIdentificacion Identificacion)
        //{

        //    DateTime Dia = DateTime.Now;
        //    HistoricoChecadas Checada = new HistoricoChecadas(Unidad);
        //    Checada.FechaChecada = Dia.Date;
        //    Checada.HoraChecadaEntrada = Dia.AddTicks(-(Dia.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;
        //    Checada.HoraChecadaSalida = null;
        //    Checada.TipoIdentificacionEntrada = Identificacion;
        //    Checada.Usuario = Usuario;
        //    Checada.Save();
        //    Unidad.CommitChanges();
            
        //    //Session["imgfoto"] = Usuario.Usuario.Imagen == null ? null : Convert.FromBase64String(Usuario.Usuario.Imagen == null ? "" : string.IsNullOrEmpty(Usuario.Usuario.Imagen.Archivo) ? "" : Usuario.Usuario.Imagen.Archivo);// ObtenerFoto(Usuario.Usuario.Imagen == null ? "" : Usuario.Usuario.Imagen.Archivo);
        //    try
        //    {
        //        List<string> Entradas = (List<string>)Session["Entradas"];
        //        if (Entradas == null)
        //            Entradas = new List<string>();
        //        Entradas.Add(Checada.Usuario.Usuario.NumEmpleado.ToString() + " - " + Checada.Usuario.Usuario.Nombre + " Entrada:" + Environment.NewLine + Checada.FechaChecada.ToShortDateString() + " " + Checada.HoraChecadaEntrada);
        //        Session["Entradas"] = Entradas;
        //    }
        //    catch(Exception ex)
        //    {
        //        Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        //    }
        //    return "Entrada registrada " + Usuario.Usuario.Nombre;
        //}

        //private string ModificarChecada(HistoricoChecadas Checada, TipoIdentificacion Identificacion)
        //{
        //    DateTime Dia = DateTime.Now;
        //    Checada.HoraChecadaSalida = Dia.AddTicks(-(Dia.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;
        //    Checada.TipoIdentificacionSalida = Identificacion;
        //    Checada.Save();
        //    ((UnidadDeTrabajo)Checada.Session).CommitChanges();
        //    //Session["imgfoto"] = Checada.Usuario.Usuario.Imagen == null ? null : ObtenerFoto(Checada.Usuario.Usuario.Imagen == null ? "" : string.IsNullOrEmpty(Checada.Usuario.Usuario.Imagen.Archivo) ? "" : Checada.Usuario.Usuario.Imagen.Archivo);
            
        //    try
        //    {
        //        List<string> Salidas = (List<string>)Session["Salidas"];
        //        if (Salidas == null)
        //            Salidas = new List<string>();
        //        Salidas.Add(Checada.Usuario.Usuario.NumEmpleado.ToString() + " - " + Checada.Usuario.Usuario.Nombre + " Salida:" + Environment.NewLine + Checada.FechaChecada.ToShortDateString() + " " + Checada.HoraChecadaSalida);
        //        Session["Salidas"] = Salidas;
        //    }
        //    catch(Exception ex)
        //    {
        //        Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        //    }
        //    return "Salida registrada " + Checada.Usuario.Usuario.Nombre ;
        //}
        #endregion

        protected void CallbackLimpiar_Callback(object source, DevExpress.Web.CallbackEventArgs e)
        {
            Session["Entradas"] = new List<string>();
            Session["Salidas"] = new List<string>();
        }

        //[System.Web.Services.WebMethod]
        //public static string Checa(string Parameter)
        //{
        //    if (!string.IsNullOrEmpty(Parameter))
        //    {
        //        string[] valor = Parameter.Split('|');
        //        using (UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo())
        //        {
        //            TipoIdentificacion Tipo = TipoIdentificacion.Gafete;
        //            UsuarioChecador Usuario = null;
        //            if (!string.IsNullOrEmpty(valor[0]) & Int32.TryParse(valor[0], out int c))
        //            {
        //                if (valor[1] == "gafete")
        //                {
        //                    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(valor[0]), false);
        //                }
        //                else
        //                {
        //                    Tipo = TipoIdentificacion.Manual;
        //                    Usuario = CHECADOR.BL.Utilerias.ObtenerUsuarioChecador(Unidad, Convert.ToInt32(valor[0]), true);
        //                }
        //                if (Usuario != null)
        //                {
        //                    if (Usuario.Notificaciones.Count <= 0)
        //                    {
        //                        Usuario.HistoricoChecadas.Filter = new NullOperator("HoraChecadaSalida");
        //                        //GroupOperator go = new GroupOperator();
        //                        //go.Operands.Add(new NullOperator("HoraChecadaSalida"));
        //                        //go.Operands.Add(new BinaryOperator("Usuario.Oid", Usuario.Oid ));
        //                        //XPView xp = new XPView(Unidad, typeof(HistoricoChecadas), "Oid;FechaChecada", go);
        //                        if (Usuario.HistoricoChecadas.Count > 0)
        //                        {
        //                            HistoricoChecadas Checada = Usuario.HistoricoChecadas[Usuario.HistoricoChecadas.Count - 1];
        //                            if (Checada.HoraChecadaSalida == null)
        //                                return ModificarChecada(Checada, Tipo);
        //                            else
        //                            {
        //                                return CrearChecada(Unidad, Usuario, Tipo);
        //                            }
        //                        }
        //                        else
        //                        {
        //                            return CrearChecada(Unidad, Usuario, Tipo);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        return "Favor de pasar con " + Usuario.Notificaciones[0].Responsable.Usuario.Nombre;
        //                        //Session["imgfoto"] = null;
        //                    }
        //                }
        //                else
        //                {
        //                    //Session["imgfoto"] = null;
        //                    return "Usuario no registrado";
        //                }
        //            }
        //            else
        //            {
        //                //Session["imgfoto"] = null;
        //                return "Usuario no registrado";
        //            }
        //        }
        //    }
        //    return "";
        //}
        //protected void ASPxBinaryImage1_CustomCallback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        //{
        //    //if (string.IsNullOrEmpty(e.Parameter))
        //    //{

        //    //    ASPxBinaryImage1.Value = (byte[])Session["imgfoto"];
        //    //}
        //    //else
        //    //{
        //    //    ASPxBinaryImage1.Value = null;
        //    //}
        //}

        //protected void ASPxBinaryImage1_DataBinding(object sender, EventArgs e)
        //{
        //    ASPxBinaryImage1.Value = (byte[])Session["imgfoto"];
        //}
    }
}