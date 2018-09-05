using ATRCBASE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECADOR.BL
{
    [NonPersistent]
    public static partial class Utilerias
    {
        public static UsuarioChecador ObtenerUsuarioChecador(UnidadDeTrabajo Unidad, int NumUsuario, bool esNumUsuario = true)
        {
            ATRCBASE.BL.Usuario Usuario = null;
            if (esNumUsuario)
                Usuario = Unidad.FindObject<ATRCBASE.BL.Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("NumEmpleado", NumUsuario, BinaryOperatorType.Equal));
            else
                Usuario = Unidad.FindObject<ATRCBASE.BL.Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("IDCard", NumUsuario, BinaryOperatorType.Equal));
            if (Usuario != null)
            {
                UsuarioChecador UsuarioChecador = Unidad.FindObject<UsuarioChecador>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Usuario", Usuario, BinaryOperatorType.Equal));
                if (UsuarioChecador == null)
                {
                    UnidadDeTrabajo unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    UsuarioChecador NuevoUsuario = new UsuarioChecador(unidad);
                    if (esNumUsuario)
                        NuevoUsuario.Usuario = unidad.FindObject<ATRCBASE.BL.Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("NumEmpleado", NumUsuario, BinaryOperatorType.Equal));
                    else
                        NuevoUsuario.Usuario = unidad.FindObject<ATRCBASE.BL.Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("IDCard", NumUsuario, BinaryOperatorType.Equal));
                    //NuevoUsuario.Usuario = unidad.FindObject<Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("NumEmpleado", NumUsuario, BinaryOperatorType.Equal));
                    unidad.CommitChanges();
                    return Unidad.FindObject<UsuarioChecador>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Usuario.Oid", Usuario.Oid, BinaryOperatorType.Equal));

                }
                else
                {
                    return UsuarioChecador;
                }
            }
            else
                return null;
        }

        public static UsuarioChecador ObtenerUsuarioChecadorPorID(UnidadDeTrabajo Unidad, int IdUsuario)
        {
            ATRCBASE.BL.Usuario Usuario = Unidad.FindObject<ATRCBASE.BL.Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Oid", IdUsuario, BinaryOperatorType.Equal));
            if (Usuario != null)
            {
                UsuarioChecador UsuarioChecador = Unidad.FindObject<UsuarioChecador>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Usuario", Usuario, BinaryOperatorType.Equal));
                if (UsuarioChecador == null)
                {
                    UnidadDeTrabajo unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                    UsuarioChecador NuevoUsuario = new UsuarioChecador(unidad);
                    NuevoUsuario.Usuario = unidad.FindObject<Usuario>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Oid", IdUsuario, BinaryOperatorType.Equal));
                    unidad.CommitChanges();
                    return Unidad.FindObject<UsuarioChecador>(PersistentCriteriaEvaluationBehavior.InTransaction, new BinaryOperator("Usuario.Oid", Usuario.Oid, BinaryOperatorType.Equal));

                }
                else
                {
                    return UsuarioChecador;
                }
            }
            else
                return null;
        }
        
        public static decimal CalcularHora(TimeSpan Hora)
        {
            int Horas = Hora.Hours;
            int min = Hora.Minutes;

            if (min == 01 || min == 02)
            {
                min = 0;
            }
            else
            {
                if (min == 03 || min == 04 || min == 05 || min == 06 || min == 07)
                {
                    min = 08;
                }
                else
                {
                    if (min == 8 || min == 9 || min == 10 || min == 11 || min == 12)
                    {
                        min = 16;
                    }
                    else
                    {

                        if (min == 13 || min == 14 || min == 15 || min == 16 || min == 17)
                        {
                            min = 25;
                        }
                        else
                        {
                            if (min == 18 || min == 19 || min == 20 || min == 21 || min == 22)
                            {
                                min = 33;
                            }
                            else
                            {
                                if (min == 23 || min == 24 || min == 25 || min == 26 || min == 27)
                                {
                                    min = 41;
                                }
                                else
                                {
                                    if (min == 28 || min == 29 || min == 30 || min == 31 || min == 32)
                                    {
                                        min = 50;
                                    }
                                    else
                                    {
                                        if (min == 33 || min == 34 || min == 35 || min == 36 || min == 37)
                                        {
                                            min = 58;
                                        }
                                        else
                                        {
                                            if (min == 38 || min == 39 || min == 40 || min == 41 || min == 42)
                                            {
                                                min = 66;
                                            }
                                            else
                                            {
                                                if (min == 43 || min == 44 || min == 45 || min == 46 || min == 47)
                                                {
                                                    min = 75;
                                                }
                                                else
                                                {
                                                    if (min == 48 || min == 49 || min == 50 || min == 51 || min == 52)
                                                    {
                                                        min = 83;
                                                    }
                                                    else
                                                    {
                                                        if (min == 53 || min == 54 || min == 55 || min == 56 || min == 57)
                                                        {
                                                            min = 91;
                                                        }
                                                        else
                                                        {
                                                            if (min == 58 || min == 59 || min == 60)
                                                            {
                                                                min = 100;
                                                            }

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (min == 100)
            {
                Horas = +1;
            }
            return min < 10 ? Convert.ToDecimal(Convert.ToDouble(".0" + min) + Horas) : Convert.ToDecimal(Horas + "." + min);
        }

        public static decimal HorasTrabajadas(UnidadDeTrabajo Unidad, UsuarioChecador usuario, DateTime FechaInicial, DateTime FechaFinal)
        {
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaInicial.Date, BinaryOperatorType.GreaterOrEqual));
            go.Operands.Add(new BinaryOperator("FechaChecada", FechaFinal.Date, BinaryOperatorType.LessOrEqual));
            usuario.HistoricoChecadas.Filter = go;
            decimal Horas = 0;
            foreach(HistoricoChecadas historico in usuario.HistoricoChecadas)
                
                if(historico.HoraChecadaCalculadaSalida > 0 & historico.HoraChecadaCalculadaEntrada > 0)
                    if ((historico.HoraChecadaCalculadaSalida > historico.HoraChecadaCalculadaEntrada))
                        Horas += (historico.HoraChecadaCalculadaSalida - historico.HoraChecadaCalculadaEntrada);
                    else
                        Horas += (historico.HoraChecadaCalculadaSalida - historico.HoraChecadaCalculadaEntrada) == 0 ? 0 : ((historico.HoraChecadaCalculadaSalida - historico.HoraChecadaCalculadaEntrada) +24);
            return Horas;
        }

        public static  void CrearChecada(DateTime FechaChecada, TimeSpan HoraChecadaEntrada, TimeSpan HoraChecadaSalida, bool EntradaVacia, bool SalidaVacia, string Motivo,UsuarioChecador Usuario, UnidadDeTrabajo Unidad)
        {
            HistoricoChecadas Checador = new HistoricoChecadas(Unidad);
            Checador.FechaChecada = FechaChecada.Date;
            Checador.HoraChecadaEntrada = HoraChecadaEntrada;
            Checador.HoraChecadaSalida = SalidaVacia ? (TimeSpan?)HoraChecadaSalida : null;
            Checador.Motivo = Motivo;
            Checador.TipoIdentificacionEntrada = EntradaVacia ? Enums.TipoIdentificacion.Manual : Enums.TipoIdentificacion.Ninguno;
            Checador.TipoIdentificacionSalida = SalidaVacia ? Enums.TipoIdentificacion.Manual : Enums.TipoIdentificacion.Ninguno;
            Checador.Usuario = Usuario;
            Usuario.HistoricoChecadas.Add(Checador);
            Checador.Save();
        }

    }
}
