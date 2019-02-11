using ATRCBASE.BL;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using static ATRCBASE.BL.Enums;

namespace ATRCWEB.WS
{
    /// <summary>
    /// Descripción breve de WS_Diesel
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WS_Diesel : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int InicioDeSesion(string Usuario, string Contrasena)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("NumEmpleado", Usuario));
            go.Operands.Add(new BinaryOperator("EsAdministrativo", true));
            go.Operands.Add(new BinaryOperator("ConstraseñaDesencriptada", Contrasena));
            Usuario UsuarioLogin = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (UsuarioLogin != null)
            {
                ATRCBASE.BL.Utilerias.UsuarioActual = UsuarioLogin;
                return 1;
            }
            else
                return 0;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Diesel> PedidosDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Diesel> ListDiesel = new List<Diesel>();
            XPView PedidosDiesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid;Unidad.Nombre;Empleado.Nombre;Llenado;CandadoActual;Litros", new BinaryOperator("Fecha", DateTime.Now.Date));
            PedidosDiesel.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Unidad.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord PedidoDiesel in PedidosDiesel)
            {
                Diesel Diesel = new Diesel();
                Diesel.ID = Convert.ToInt32(PedidoDiesel["Oid"]);
                Diesel.Unidad = PedidoDiesel["Unidad.Nombre"].ToString();
                Diesel.Empleado = PedidoDiesel["Empleado.Nombre"].ToString();
                Diesel.Llenado = Convert.ToBoolean(PedidoDiesel["LLenado"]);
                Diesel.Litros = Convert.ToInt32(PedidoDiesel["Litros"]);
                ListDiesel.Add(Diesel);
            }
            return ListDiesel;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Tanque> TanquesActuales()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Tanque> ListTanques = new List<Tanque>();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Enums.Combustible.Diesel));
            XPView Tanques = new XPView(Unidad, typeof(COMBUSTIBLE.BL.MedidorDiesel), "Oid;Tanque.Oid;Tanque.Descripcion", go);
            foreach (ViewRecord viewTanque in Tanques)
            {
                Tanque Tanque = new Tanque();
                Tanque.ID = Convert.ToInt32(viewTanque["Tanque.Oid"]);
                Tanque.Descripcion = viewTanque["Tanque.Descripcion"].ToString();
                ListTanques.Add(Tanque);
            }
            return ListTanques;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Tanque> TanquesDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Tanque> ListTanques = new List<Tanque>();
            XPView Tanques = new XPView(Unidad, typeof(COMBUSTIBLE.BL.DieselActual), "Oid;Oid;Descripcion;Cantidad", new BinaryOperator("TipoCombustible", Enums.Combustible.Diesel));
            foreach (ViewRecord viewTanque in Tanques)
            {
                Tanque Tanque = new Tanque();
                Tanque.ID = Convert.ToInt32(viewTanque["Oid"]);
                Tanque.Descripcion = viewTanque["Descripcion"].ToString();
                Tanque.Cantidad = Convert.ToInt32(viewTanque["Cantidad"]);
                ListTanques.Add(Tanque);
            }
            return ListTanques;
        }

        [WebMethod(EnableSession = true)]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DetalleDieselUnidad(int IDDiesel, Int32 Millas, int CandadoAnterior, int CandadoActual, int Litros, int IDTanque)
        {
            try
            {
                Session["OidAdministrador"] = 1;
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
                COMBUSTIBLE.BL.Diesel Diesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);

                if (Tanque != null)
                {
                    if (Tanque.Cantidad >= 0)
                    {
                        XPView UltimaRecarga = new XPView(Unidad, typeof(RecargaDiesel), "Oid", new BinaryOperator("Tanque", Tanque));
                        UltimaRecarga.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                        UltimaRecarga.TopReturnedRecords = 1;
                        if (UltimaRecarga.Count > 0)
                        {

                            Diesel.Millas = Millas;
                            Diesel.MillasRecorridas = Millas - Convert.ToInt64(Diesel.Unidad.Millas);
                            Diesel.Unidad.Millas = Millas.ToString();
                            Diesel.CandadoAnterior = CandadoAnterior;
                            Diesel.CandadoActual = CandadoActual;
                            Diesel.Litros = Litros;
                            Diesel.Llenado = true;
                            Diesel.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                            Tanque.Cantidad -= Litros;
                            Tanque.Save();
                            Diesel.Save();

                            Unidad.CommitChanges();
                            //Diesel.Session.CommitTransaction();
                            return "";
                        }
                        else
                        {
                            return "No hay diesel.";
                        }
                    }
                    else
                    {
                        return "No hay diesel.";
                    }
                }
                return "Ocurrio un problema.";
            }catch(Exception e)
            {
                return "No hay diesel.";
            }
        }

        [WebMethod(EnableSession = true)]
        public int GuardarTanques(int IDTanque, Int32 Inicial, Int32 Final)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
            XPView Medidores = new XPView(Unidad, typeof(MedidorDiesel), "Oid;Inicial", go);
            if(Medidores.Count > 0)
            {
                MedidorDiesel Medidor = Medidores[0].GetObject() as MedidorDiesel;
                Medidor.Inicial = Inicial;
                Medidor.Final = Final;
                Medidor.Tanque = Tanque;
                Medidor.Save();
                Unidad.CommitChanges();
            }
            else
            {
                MedidorDiesel Medidor = new MedidorDiesel(Unidad);
                Medidor.Inicial = Inicial;
                Medidor.Final = Final;
                Medidor.Tanque = Tanque;
                Medidor.Save();
                Unidad.CommitChanges();
            }
            return 0;
        }

        [WebMethod(EnableSession = true)]
        public int GuardarRecarga(int IDTanque, decimal Precio, int Cantidad)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            Tanque.Cantidad += Cantidad;
            RecargaDiesel recarga = new RecargaDiesel(Unidad);
            recarga.Tanque = Tanque;
            recarga.PrecioLitro = Convert.ToDouble(Precio);
            recarga.Cantidad = Cantidad;
            Tanque.Save();
            recarga.Save();
            Unidad.CommitChanges();
            return 0;
        }

        [WebMethod(EnableSession = true)]
        public List<RangosGrafica> RangosTanque(int IDTanque)
        {
            List<RangosGrafica> Rangos = new List<RangosGrafica>();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
            XPView Medidor = new XPView(Unidad, typeof(MedidorDiesel),"Oid;Inicial", go);
            int div = Tanque.Capacidad / 3;

            RangosGrafica rangoInicial = new RangosGrafica();
            rangoInicial.startValue = Tanque.Cantidad;
            rangoInicial.endValue = Tanque.Capacidad;
            Rangos.Add(rangoInicial);

            RangosGrafica PrimerRango = new RangosGrafica();
            PrimerRango.startValue = 0;
            PrimerRango.endValue = div;
            PrimerRango.color = "#FF0000";
            Rangos.Add(PrimerRango);

            RangosGrafica SegundoRango = new RangosGrafica();
            SegundoRango.startValue = div;
            SegundoRango.endValue = (div * 2);
            SegundoRango.color = "#E6E200";
            Rangos.Add(SegundoRango);

            RangosGrafica TercerRango = new RangosGrafica();
            TercerRango.startValue = (div * 2);
            TercerRango.endValue = Tanque.Capacidad;
            TercerRango.color = "#77DD77";
            Rangos.Add(TercerRango);

            if (Medidor.Count > 0)
            {
                RangosGrafica rangoFinal = new RangosGrafica();
                rangoFinal.startValue = Convert.ToInt32(Medidor[0]["Inicial"]);
                Rangos.Add(rangoFinal);
            }

            return Rangos;
        }

        [WebMethod(EnableSession = true)]
        public bool MismoCandado(int IDDiesel, string Candado)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            COMBUSTIBLE.BL.Diesel Diesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);
            XPView DieselAnterior = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid;CandadoActual", new BinaryOperator("Unidad.Oid", Diesel.Unidad.Oid));
            DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            string CandadoAnterior = string.Empty;
            if (DieselAnterior.Count > 1)
                CandadoAnterior = DieselAnterior[1]["CandadoActual"].ToString();

            if (string.IsNullOrEmpty(CandadoAnterior))
                return true;
            if (CandadoAnterior == Candado)
                return true;
            else
                return false;

        }

        [WebMethod(EnableSession = true)]
        public int GuardarProblemaCandado(int IDDiesel, string Problema)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            COMBUSTIBLE.BL.Diesel Diesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);
            DetallesCandados Candado = new DetallesCandados(Unidad);
            Candado.Empleado = Utilerias.ObtenerUsuarioActual(Unidad);
            Candado.Unidad = Diesel.Unidad;
            Candado.Problema = Problema;
            Candado.Save();
            Unidad.CommitChanges();

            return 0;
        }

        [WebMethod(EnableSession = true)]
        public string GuardarUnidadDiesel(int IDUnidad, int IDEmpleado)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UNIDADES.BL.Unidad UnidadCamion = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(IDUnidad);
            Usuario Usuario = Unidad.GetObjectByKey<Usuario>(IDEmpleado);

            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Unidad", UnidadCamion));
            go.Operands.Add(new BinaryOperator("Fecha", DateTime.Now.Date));
            XPView UnidadesConDiesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid", go);
            if (UnidadesConDiesel.Count > 0)
            {
                return "La unidad ya se encuentra registrada.";
            }
            else
            {
                COMBUSTIBLE.BL.Diesel Diesel = new COMBUSTIBLE.BL.Diesel(Unidad);
                Diesel.Empleado = Unidad.FindObject<Usuario>(new BinaryOperator("Oid", IDEmpleado));
                Diesel.Unidad = UnidadCamion;
                Diesel.Fecha = DateTime.Now.Date;
                Diesel.Save();
                Unidad.CommitChanges();
                return "La unidad se ha se registrado.";
            }
        }

        [WebMethod(EnableSession = true)]
        public List<Unidades> ObternerUnidadesDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BinaryOperator bo = new BinaryOperator("Combustible", Combustible.Diesel);
            List<Unidades> ListaUnidades = new List<Unidades>();
            XPView xpUnidades = new XPView(Unidad, typeof(UNIDADES.BL.Unidad));
            xpUnidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            xpUnidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            xpUnidades.Criteria = bo;
            foreach (ViewRecord viewUnidad in xpUnidades)
            {
                Unidades UnidadCamion = new Unidades();
                UnidadCamion.ID = Convert.ToInt32(viewUnidad["Oid"]);
                UnidadCamion.Nombre = viewUnidad["Nombre"].ToString();
                ListaUnidades.Add(UnidadCamion);
            }
            return ListaUnidades;
        }

        [WebMethod(EnableSession = true)]
        public List<Empleados> ObternerEmpleados()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            BinaryOperator bo = new BinaryOperator("Activo", true);
            List<Empleados> ListaEmpleados = new List<Empleados>();

            XPView xpEmpleados = new XPView(Unidad, typeof(Usuario));
            xpEmpleados.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            xpEmpleados.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            xpEmpleados.Criteria = bo;
            foreach (ViewRecord viewEmpleado in xpEmpleados)
            {
                Empleados Empleado = new Empleados();
                Empleado.ID = Convert.ToInt32(viewEmpleado["Oid"]);
                Empleado.Nombre = viewEmpleado["Nombre"].ToString();
                ListaEmpleados.Add(Empleado);
            }
            return ListaEmpleados;
        }

        public class Tanque
        {
            public int ID { set; get; }
            public string Descripcion { set; get; }
            public int Cantidad { set; get; }
            public int Capacidad { set; get; }
        }

        public class Diesel
        {
            public int ID { set; get; }
            public string Unidad { set; get; }
            public string Empleado { set; get; }
            public bool Llenado { set; get; }
            public int Litros { set; get; }
        }

        public class RangosGrafica
        {
            public Int64 startValue { set; get; }
            public int endValue { set; get; }
            public string color { set; get; }

        }

        public class Empleados
        {
            public int ID { set; get; }
            public string Nombre { set; get; }
        }

        public class Unidades
        {
            public int ID { set; get; }
            public string Nombre { set; get; }
        }
    }
}
