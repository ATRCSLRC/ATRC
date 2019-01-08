using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Checador.Scripts
{
    public class Metodos
    {

        public static string Checador(string Parameter)
        {
            try
            {

                if (!string.IsNullOrEmpty(Parameter))
                {
                    string[] valor = Parameter.Split('|');
                    using (SqlConnection sql = new SqlConnection("data source=192.168.0.123\\ATRCSERVER;user id=sa;password=@TRCSistemas;initial catalog=ATRCPRODUCCION;Persist Security Info=true"))
                    {

                        string Query = string.Empty;
                        int Tipo = 1;
                        if (!string.IsNullOrEmpty(valor[0]) & Int32.TryParse(valor[0], out int c))
                        {
                            if (valor[1] != "gafete")
                            {
                                Tipo = 2;
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
                                    return BuscarChecada(IDUsuario, Tipo, NumEmpleado, Nombre, sql);
                                else
                                    return UsuarioExiste(Convert.ToInt32(valor[0]), Tipo, sql);
                            }
                        }
                        else
                        {
                            return "Usuario no registrado";
                        }
                    }
                }
                //return "Usuario no registrado";
            }
            catch (Exception ex)
            {
                //Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
            return "Usuario no registrado";
        }

        private static string UsuarioExiste(int IDUsuario, int Tipo, SqlConnection sql)
        {
            string Query = string.Empty;
            int ID = 0;
            int NumEmpleado = 0;
            string Nombre = string.Empty;
            if (Tipo == 2)
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
                    reader.Close();
                }
                Usuario.Dispose();
            }
            if (ID <= 0)
                return "Usuario no registrado";
            else
                return UsuarioNuevo(ID, Tipo, NumEmpleado, Nombre, sql);
        }

        private static string UsuarioNuevo(int IDUsuario, int Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
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
                NuevoUsuario.Dispose();
            }

            using (SqlCommand NuevoUsuario = new SqlCommand("SELECT OID FROM ch_UsuarioChecador WHERE GCRecord IS NULL AND Usuario = @Usuario"))
            {

                DateTime HoraChecada = DateTime.Now;
                NuevoUsuario.Connection = sql;
                NuevoUsuario.CommandType = CommandType.Text;
                NuevoUsuario.Parameters.AddWithValue("@Usuario", IDUsuario);
                IDChecador = Convert.ToInt32(NuevoUsuario.ExecuteScalar());
                NuevoUsuario.Dispose();
            }
            if (IDChecador > 0)
            {
                return BuscarChecada(IDChecador, Tipo, NumEmpleado, Nombre, sql);
            }
            else
            {
                return "Usuario no registrado";
            }

        }

        private static string TieneNotificaciones(int IDUsuario, SqlConnection sql)
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
                {
                    if (reader.Read())
                        Nombre = reader.GetValue(0).ToString();

                    reader.Close();
                }
                Busqueda.Dispose();
                if (!string.IsNullOrEmpty(Nombre))
                    return "Favor de pasar con " + Nombre;
                else
                    return string.Empty;
            }
        }

        private static string BuscarChecada(int IDUsuario, int Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
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
                    Busqueda.Dispose();
                    if (IDChecador > 0)
                    {
                        return ModificarChecada(IDChecador, Tipo, NumEmpleado, Nombre, sql);
                    }
                    else
                    {
                        return NuevaChecada(IDUsuario, Tipo, NumEmpleado, Nombre, sql);
                    }
                }
            }
            else
            {
                return Notificacion;
            }
        }

        private static string ModificarChecada(int IDUsuario, int Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
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
                //List<string> Salidas = (List<string>)Session["Salidas"];
                //if (Salidas == null)
                //    Salidas = new List<string>();
                //Salidas.Add(NumEmpleado + " - " + Nombre + " Salida:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay);
                //Session["Salidas"] = Salidas;
                Update.Dispose();
                sql.Close();
                return "Salida registrada " + Nombre + "|" + NumEmpleado + " - " + Nombre + " Salida:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;
            }
        }

        private static string NuevaChecada(int IDUsuario, int Tipo, int NumEmpleado, string Nombre, SqlConnection sql)
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

                //List<string> Entradas = (List<string>)Session["Entradas"];
                //if (Entradas == null)
                //    Entradas = new List<string>();
                //Entradas.Add(NumEmpleado + " - " + Nombre + " Entrada:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay);
                //Session["Entradas"] = Entradas;
                insert.Dispose();
                sql.Close();
                return "Entrada registrada " + Nombre + "|"  + NumEmpleado + " - " + Nombre + " Entrada:" + Environment.NewLine + HoraChecada.ToShortDateString() + " " + HoraChecada.AddTicks(-(HoraChecada.Ticks % TimeSpan.TicksPerSecond)).TimeOfDay;

            }
        }
    }
}