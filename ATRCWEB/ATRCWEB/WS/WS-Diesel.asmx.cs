using ATRCBASE.BL;
using COMBUSTIBLE.BL;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using REPORTES.Unidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using static ATRCBASE.BL.Enums;
using static ATRCWEB.WS.WS_Diesel;

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
            go.Operands.Add(new BinaryOperator("AccesoSistema", true));
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

        #region Diesel
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Diesel> PedidosDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Diesel> ListDiesel = new List<Diesel>();
            XPView PedidosDiesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel));
            PedidosDiesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Unidad.Nombre", SortDirection.None, "[Unidad.Nombre]", false, true),
                  new ViewProperty("Empleado.Nombre", SortDirection.None, "[Empleado.Nombre]", false, true),
                  new ViewProperty("Llenado", SortDirection.None, "[Llenado]", false, true),
                  new ViewProperty("Millas", SortDirection.None, "[Unidad.Millas]", false, true),
                  //new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true),
                  new ViewProperty("Tanque1", SortDirection.None, "iif([UltimaRecarga.Tanque.Oid] == 1, [Litros], 0)", false, true),
                  new ViewProperty("Tanque2", SortDirection.None, "iif([UltimaRecarga.Tanque.Oid] == 2, [Litros], 0)", false, true)
                 });
            PedidosDiesel.Criteria = new BinaryOperator("Fecha", DateTime.Now.Date);
            PedidosDiesel.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Unidad.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord PedidoDiesel in PedidosDiesel)
            {
                Diesel Diesel = new Diesel();
                Diesel.ID = Convert.ToInt32(PedidoDiesel["Oid"]);
                Diesel.Unidad = PedidoDiesel["Unidad.Nombre"].ToString();
                Diesel.Empleado = PedidoDiesel["Empleado.Nombre"].ToString();
                Diesel.Llenado = Convert.ToBoolean(PedidoDiesel["LLenado"]);
                Diesel.Millas = Convert.ToInt32(PedidoDiesel["Millas"]);
                Diesel.Tanque1 = Convert.ToInt32(PedidoDiesel["Tanque1"]);
                Diesel.Tanque2 = Convert.ToInt32(PedidoDiesel["Tanque2"]);
                ListDiesel.Add(Diesel);
            }
            return ListDiesel;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MedidorTanques> MedidoresDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<MedidorTanques> ListaMedidor = new List<MedidorTanques>();
            XPView Medidores = new XPView(Unidad, typeof(COMBUSTIBLE.BL.MedidorDiesel));
            Medidores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Tanque.Descripcion]", false, true),
                  new ViewProperty("Inicial", SortDirection.None, "[Inicial]", false, true),
                  new ViewProperty("Final", SortDirection.None, "[Final]", false, true),
                  new ViewProperty("Total", SortDirection.None, "([Final] - [Inicial])", false, true)
                 });
            Medidores.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending)));
            Medidores.Criteria = new BinaryOperator("Tanque.TipoCombustible", 2);
            int cont = 1;
            foreach (ViewRecord viewMedidor in Medidores)
            {

                XPView Diesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel));
                Diesel.Criteria = new BinaryOperator("MedidorDiesel.Oid", viewMedidor["Oid"]);
                Diesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });

                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                MedidorTanques Medidor = new MedidorTanques();
                Medidor.Fecha = Convert.ToDateTime(viewMedidor["Fecha"]).ToShortDateString();
                Medidor.Nombre = viewMedidor["Nombre"].ToString();
                Medidor.Inicial = viewMedidor["Inicial"].ToString();
                Medidor.Final = viewMedidor["Final"].ToString();
                Medidor.TotalMedidor = viewMedidor["Total"].ToString();
                Medidor.TotalTanque = TotalTanque.ToString();
                Medidor.Diferencia = (Convert.ToInt32(viewMedidor["Total"]) - TotalTanque).ToString();
                ListaMedidor.Add(Medidor);
                cont++;
                if (cont == 10)
                    break;
            }
            return ListaMedidor;
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
                    //if (Tanque.Cantidad >= 0)
                    //{
                    XPView UltimaRecarga = new XPView(Diesel.Session, typeof(RecargaDiesel));
                    UltimaRecarga.Properties.Add(new ViewProperty("Oid", SortDirection.Descending, "Oid", false, true));
                    UltimaRecarga.Criteria = new BinaryOperator("Tanque", Tanque);
                    UltimaRecarga.TopReturnedRecords = 1;
                    if (UltimaRecarga.Count > 0)
                    {
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Final", 0));
                        go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                        XPView Medidor = new XPView(Diesel.Session, typeof(MedidorDiesel), "Oid", go);
                        Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));

                        if (!MismoCandado(IDDiesel, CandadoAnterior.ToString()))
                        {
                            UnidadDeTrabajo UnidadDieselCandado = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                            COMBUSTIBLE.BL.Diesel DieselCandado = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);
                            GroupOperator goCandado = new GroupOperator(GroupOperatorType.And);
                            goCandado.Operands.Add(new BinaryOperator("Unidad.Oid", Diesel.Unidad.Oid));
                            goCandado.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
                            XPView DieselAnterior = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid;CandadoActual", goCandado);
                            DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
                            string CandadoAnteriorCandado = string.Empty;
                            if (DieselAnterior.Count > 1)
                                CandadoAnteriorCandado = DieselAnterior[0]["CandadoActual"].ToString();


                            GuardarProblemaCandado(IDDiesel, "Ingreso: " + CandadoAnterior + ", deberia: " + CandadoAnteriorCandado);
                        }

                        Diesel.Millas = Millas;
                        Diesel.MillasRecorridas = Millas - Convert.ToInt64(Diesel.Unidad.Millas);
                        Diesel.Unidad.Millas = Millas.ToString();
                        Diesel.CandadoAnterior = CandadoAnterior;
                        Diesel.CandadoActual = CandadoActual;
                        Diesel.Litros = Litros;
                        Diesel.Llenado = true;
                        Diesel.MedidorDiesel = (Medidor[0].GetObject()) as MedidorDiesel;
                        Diesel.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Tanque.Cantidad -= Litros;
                        Tanque.Save();
                        Diesel.Save();

                        Unidad.CommitChanges();
                        
                        return "";
                    }
                    else
                    {
                        return "No hay diesel.";
                    }
                    //}
                    //else
                    //{
                    //    return "No hay diesel.";
                    //}
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
                XPView Diesel = new XPView(Unidad, Tanque.TipoCombustible == Enums.Combustible.Diesel ? typeof(COMBUSTIBLE.BL.Diesel) : typeof(COMBUSTIBLE.BL.Gasolina));
                if (Tanque.TipoCombustible == Enums.Combustible.Diesel)
                    Diesel.Criteria = new BinaryOperator("MedidorDiesel.Oid", Medidor.Oid);
                Diesel.Properties.AddRange(new ViewProperty[] {
                        new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                        new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                        });
                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                Medidor.Inicial = Inicial;
                Medidor.Final = Final;
                //Medidor.Tanque = Tanque;
                Medidor.LitrosCapturados = TotalTanque;
                Medidor.LitrosEnTanque = Convert.ToInt32(Tanque.Cantidad);
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
        public int GuardarRecarga(int IDTanque, decimal Precio, int Cantidad, string Factura, string Proveedor,string Lectura)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            Tanque.Cantidad += Cantidad;
            RecargaDiesel recarga = new RecargaDiesel(Unidad);
            recarga.Tanque = Tanque;
            recarga.PrecioLitro = Convert.ToDouble(Precio);
            recarga.Cantidad = Cantidad;
            recarga.Factura = Factura;
            recarga.Proveedor = Proveedor;
            recarga.Lectura = Lectura;
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
            rangoInicial.startValue = Convert.ToInt64(Tanque.Cantidad);
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

        //public bool MismoCandado(UnidadDeTrabajo Unidad, int IDUnidad, string Candado)
        //{
        //    //UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
        //    //COMBUSTIBLE.BL.Diesel Diesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);
        //    XPView DieselAnterior = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid;CandadoActual", new BinaryOperator("Unidad.Oid", IDUnidad));
        //    DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
        //    string CandadoAnterior = string.Empty;
        //    if (DieselAnterior.Count > 1)
        //        CandadoAnterior = DieselAnterior[1]["CandadoActual"].ToString();

        //    if (string.IsNullOrEmpty(CandadoAnterior))
        //        return true;
        //    if (CandadoAnterior == Candado)
        //        return true;
        //    else
        //        return false;

        //}

        [WebMethod(EnableSession = true)]
        public bool MismoCandado(int IDDiesel, string Candado)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            COMBUSTIBLE.BL.Diesel Diesel = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Diesel>(IDDiesel);
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Unidad.Oid", Diesel.Unidad.Oid));
            go.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
            XPView DieselAnterior = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Diesel), "Oid;CandadoActual", go);
            DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            string CandadoAnterior = string.Empty;
            if (DieselAnterior.Count > 1)
                CandadoAnterior = DieselAnterior[0]["CandadoActual"].ToString();

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
            
                COMBUSTIBLE.BL.Diesel Diesel = new COMBUSTIBLE.BL.Diesel(Unidad);
                Diesel.Empleado = Unidad.FindObject<Usuario>(new BinaryOperator("Oid", IDEmpleado));
                Diesel.Unidad = UnidadCamion;
                Diesel.Fecha = DateTime.Now.Date;
                Diesel.Save();
                Unidad.CommitChanges();
                return "La unidad se ha se registrado.";
        }

        [WebMethod(EnableSession = true)]
        public List<Unidades> ObternerUnidadesDiesel()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Combustible", Combustible.Ninguno));
            GroupOperator goCombustible = new GroupOperator(GroupOperatorType.Or);
            goCombustible.Operands.Add(new BinaryOperator("Combustible", Combustible.Diesel));
            goCombustible.Operands.Add(go);
            List<Unidades> ListaUnidades = new List<Unidades>();
            XPView xpUnidades = new XPView(Unidad, typeof(UNIDADES.BL.Unidad));
            xpUnidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            xpUnidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            xpUnidades.Criteria = goCombustible;
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
                  new ViewProperty("NumEmpleado", SortDirection.None, "[NumEmpleado]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "ToStr([NumEmpleado]) + ' - ' + [Nombre]", false, true)
                 });
            xpEmpleados.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("NumEmpleado", DevExpress.Xpo.DB.SortingDirection.Ascending)));
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
        #endregion

        #region Gasolina
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Gasolina> PedidosGasolina()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Gasolina> ListaGasolina = new List<Gasolina>();
            XPView PedidosDiesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Gasolina));
            PedidosDiesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Unidad.Nombre", SortDirection.None, "[Unidad.Nombre]", false, true),
                  new ViewProperty("Empleado.Nombre", SortDirection.None, "[Empleado.Nombre]", false, true),
                  new ViewProperty("Llenado", SortDirection.None, "[Llenado]", false, true),
                  //new ViewProperty("CandadoActual", SortDirection.None, "[CandadoActual]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });
            PedidosDiesel.Criteria = new BinaryOperator("Fecha", DateTime.Now.Date);
            PedidosDiesel.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Unidad.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord PedidoDiesel in PedidosDiesel)
            {
                Gasolina Gasolina = new Gasolina();
                Gasolina.ID = Convert.ToInt32(PedidoDiesel["Oid"]);
                Gasolina.Unidad = PedidoDiesel["Unidad.Nombre"].ToString();
                Gasolina.Empleado = PedidoDiesel["Empleado.Nombre"].ToString();
                Gasolina.Llenado = Convert.ToBoolean(PedidoDiesel["LLenado"]);
                Gasolina.Litros = Convert.ToDecimal(PedidoDiesel["Litros"]);
                ListaGasolina.Add(Gasolina);
            }
            return ListaGasolina;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<MedidorTanques> MedidoresGasolina()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<MedidorTanques> ListaMedidor = new List<MedidorTanques>();
            XPView Medidores = new XPView(Unidad, typeof(COMBUSTIBLE.BL.MedidorDiesel));
            Medidores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Fecha", SortDirection.None, "[FechaAlta]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Tanque.Descripcion]", false, true),
                  new ViewProperty("Inicial", SortDirection.None, "[Inicial]", false, true),
                  new ViewProperty("Final", SortDirection.None, "[Final]", false, true),
                  new ViewProperty("Total", SortDirection.None, "([Final] - [Inicial])", false, true)
                 });
            Medidores.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending)));
            Medidores.Criteria = new BinaryOperator("Tanque.TipoCombustible", 1);
            int cont = 1;
            foreach (ViewRecord viewMedidor in Medidores)
            {

                XPView Diesel = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Gasolina));
                Diesel.Criteria = new BinaryOperator("MedidorGasolinas.Oid", viewMedidor["Oid"]);
                Diesel.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                 });

                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                MedidorTanques Medidor = new MedidorTanques();
                Medidor.Fecha = Convert.ToDateTime(viewMedidor["Fecha"]).ToShortDateString();
                Medidor.Nombre = viewMedidor["Nombre"].ToString();
                Medidor.Inicial = viewMedidor["Inicial"].ToString();
                Medidor.Final = viewMedidor["Final"].ToString();
                Medidor.TotalMedidor = viewMedidor["Total"].ToString();
                Medidor.TotalTanque = TotalTanque.ToString();
                Medidor.Diferencia = (Convert.ToInt32(viewMedidor["Total"]) - TotalTanque).ToString();
                ListaMedidor.Add(Medidor);
                cont++;
                if (cont == 10)
                    break;
            }
            return ListaMedidor;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Tanque> TanquesActualesGasolina()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Tanque> ListTanques = new List<Tanque>();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque.TipoCombustible", Enums.Combustible.Gasolina));
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
        public List<Tanque> TanquesGasolina()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Tanque> ListTanques = new List<Tanque>();
            XPView Tanques = new XPView(Unidad, typeof(COMBUSTIBLE.BL.DieselActual), "Oid;Descripcion;Cantidad", new BinaryOperator("TipoCombustible", Enums.Combustible.Gasolina));
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
        public string DetalleGasolinaUnidad(int IDGasolina, Int32 Millas, int CandadoAnterior, int CandadoActual, decimal Litros, int IDTanque)
        {
            try
            {
                Session["OidAdministrador"] = 1;
                UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
                DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
                COMBUSTIBLE.BL.Gasolina Gasolina = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Gasolina>(IDGasolina);

                if (Tanque != null)
                {
                    //if (Tanque.Cantidad >= 0)
                    //{
                    XPView UltimaRecarga = new XPView(Unidad, typeof(RecargaDiesel), "Oid", new BinaryOperator("Tanque", Tanque));
                    UltimaRecarga.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));
                    UltimaRecarga.TopReturnedRecords = 1;
                    if (UltimaRecarga.Count > 0)
                    {
                        GroupOperator go = new GroupOperator();
                        go.Operands.Add(new BinaryOperator("Final", 0));
                        go.Operands.Add(new BinaryOperator("Tanque", Tanque));
                        XPView Medidor = new XPView(Gasolina.Session, typeof(MedidorDiesel), "Oid", go);
                        Medidor.Sorting.Add(new SortProperty("Oid", SortingDirection.Descending));

                        if (!MismoCandadoGasolina(IDGasolina, CandadoAnterior.ToString()))
                        {
                            GuardarProblemaCandadoGasolina(IDGasolina, "");
                        }

                        Gasolina.Millas = Millas;
                        Gasolina.MillasRecorridas = Millas - Convert.ToInt64(Gasolina.Unidad.Millas);
                        Gasolina.Unidad.Millas = Millas.ToString();
                        Gasolina.CandadoAnterior = CandadoAnterior;
                        Gasolina.CandadoActual = CandadoActual;
                        Gasolina.Litros = Litros;
                        Gasolina.Llenado = true;
                        Gasolina.MedidorGasolinas = (Medidor[0].GetObject()) as MedidorDiesel;
                        Gasolina.UltimaRecarga = (UltimaRecarga[0].GetObject()) as RecargaDiesel;
                        Tanque.Cantidad -= Litros;
                        Tanque.Save();
                        Gasolina.Save();

                        Unidad.CommitChanges();

                        
                        return "";
                    }
                    else
                    {
                        return "No hay diesel.";
                    }
                    //}
                    //else
                    //{
                    //    return "No hay diesel.";
                    //}
                }
                return "Ocurrio un problema.";
            }
            catch (Exception e)
            {
                return "No hay diesel.";
            }
        }

        [WebMethod(EnableSession = true)]
        public int GuardarTanquesGasolina(int IDTanque, Int32 Inicial, Int32 Final)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
            XPView Medidores = new XPView(Unidad, typeof(MedidorDiesel), "Oid;Inicial", go);
            if (Medidores.Count > 0)
            {
                MedidorDiesel Medidor = Medidores[0].GetObject() as MedidorDiesel;

                XPView Diesel = new XPView(Unidad, Tanque.TipoCombustible == Enums.Combustible.Diesel ? typeof(COMBUSTIBLE.BL.Diesel) : typeof(COMBUSTIBLE.BL.Gasolina));
                Diesel.Criteria = new BinaryOperator("MedidorGasolinas.Oid", Medidor.Oid);
                Diesel.Properties.AddRange(new ViewProperty[] {
                        new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                        new ViewProperty("Litros", SortDirection.None, "[Litros]", false, true)
                        });
                Int32 TotalTanque = (from ViewRecord sP in Diesel select Convert.ToInt32(sP["Litros"])).Sum();

                Medidor.LitrosCapturados = TotalTanque;
                Medidor.LitrosEnTanque = Convert.ToInt32(Tanque.Cantidad);
                Medidor.Inicial = Inicial;
                Medidor.Final = Final;
                //Medidor.Tanque = Tanque;
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
        public List<RangosGrafica> RangosTanqueGasolina(int IDTanque)
        {
            List<RangosGrafica> Rangos = new List<RangosGrafica>();
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            DieselActual Tanque = Unidad.GetObjectByKey<DieselActual>(IDTanque);
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Final", 0));
            go.Operands.Add(new BinaryOperator("Tanque", Tanque.Oid));
            XPView Medidor = new XPView(Unidad, typeof(MedidorDiesel), "Oid;Inicial", go);
            int div = Tanque.Capacidad / 3;

            RangosGrafica rangoInicial = new RangosGrafica();
            rangoInicial.startValue = Convert.ToInt64(Tanque.Cantidad);
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
        public bool MismoCandadoGasolina(int IDGasolina, string Candado)
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            COMBUSTIBLE.BL.Gasolina Gasolina = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Gasolina>(IDGasolina);
            GroupOperator go = new GroupOperator(GroupOperatorType.And);
            go.Operands.Add(new BinaryOperator("Unidad.Oid", Gasolina.Unidad.Oid));
            go.Operands.Add(new NotOperator(new NullOperator("UltimaRecarga")));
            XPView DieselAnterior = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Gasolina), "Oid;CandadoActual", go);
            DieselAnterior.Sorting.Add(new SortProperty("Oid", DevExpress.Xpo.DB.SortingDirection.Descending));
            string CandadoAnterior = string.Empty;
            if (DieselAnterior.Count > 1)
                CandadoAnterior = DieselAnterior[0]["CandadoActual"].ToString();

            if (string.IsNullOrEmpty(CandadoAnterior))
                return true;
            if (CandadoAnterior == Candado)
                return true;
            else
                return false;

        }

        [WebMethod(EnableSession = true)]
        public int GuardarProblemaCandadoGasolina(int IDGasolina, string Problema)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            COMBUSTIBLE.BL.Gasolina Gasolina = Unidad.GetObjectByKey<COMBUSTIBLE.BL.Gasolina>(IDGasolina);
            DetallesCandados Candado = new DetallesCandados(Unidad);
            Candado.Empleado = Utilerias.ObtenerUsuarioActual(Unidad);
            Candado.Unidad = Gasolina.Unidad;
            Candado.Problema = Problema;
            Candado.Save();
            Unidad.CommitChanges();

            return 0;
        }

        [WebMethod(EnableSession = true)]
        public string GuardarUnidadGasolina(int IDUnidad, int IDEmpleado)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UNIDADES.BL.Unidad UnidadCamion = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(IDUnidad);
            Usuario Usuario = Unidad.GetObjectByKey<Usuario>(IDEmpleado);

            //GroupOperator go = new GroupOperator();
            //go.Operands.Add(new BinaryOperator("Unidad", UnidadCamion));
            //go.Operands.Add(new BinaryOperator("Fecha", DateTime.Now.Date));
            //XPView UnidadesConGasolina = new XPView(Unidad, typeof(COMBUSTIBLE.BL.Gasolina), "Oid", go);

            COMBUSTIBLE.BL.Gasolina Diesel = new COMBUSTIBLE.BL.Gasolina(Unidad);
            Diesel.Empleado = Unidad.FindObject<Usuario>(new BinaryOperator("Oid", IDEmpleado));
            Diesel.Unidad = UnidadCamion;
            Diesel.Fecha = DateTime.Now.Date;
            Diesel.Save();
            Unidad.CommitChanges();
            return "La unidad se ha se registrado.";
        }

        [WebMethod(EnableSession = true)]
        public List<Unidades> ObternerUnidadesGasolina()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("Combustible", Combustible.Ninguno));
            GroupOperator goCombustible = new GroupOperator(GroupOperatorType.Or);
            goCombustible.Operands.Add(new BinaryOperator("Combustible", Combustible.Gasolina));
            goCombustible.Operands.Add(go);
            List<Unidades> ListaUnidades = new List<Unidades>();
            XPView xpUnidades = new XPView(Unidad, typeof(UNIDADES.BL.Unidad));
            xpUnidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true)
                 });
            xpUnidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            xpUnidades.Criteria = goCombustible;
            foreach (ViewRecord viewUnidad in xpUnidades)
            {
                Unidades UnidadCamion = new Unidades();
                UnidadCamion.ID = Convert.ToInt32(viewUnidad["Oid"]);
                UnidadCamion.Nombre = viewUnidad["Nombre"].ToString();
                ListaUnidades.Add(UnidadCamion);
            }
            return ListaUnidades;
        }
        #endregion
        
        #region Inventario
        [WebMethod(EnableSession = true)]
        public List<Extintor> Extintores()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Extintor> ListaExtintores = new List<Extintor>();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("Unidad.EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("Unidad.EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("Unidad.EstadoUnidad"));
            XPView xpExtintores = new XPView(Unidad, typeof(UNIDADES.BL.Extintores));
            xpExtintores.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Revisado", SortDirection.None, "iif(GETMONTH([FechaInventario]) == GETMONTH(NOW()), True, False)", false, true),
                  new ViewProperty("NumExtintor", SortDirection.None, "[NumExtintor]", false, true),
                  new ViewProperty("FechaRecarga", SortDirection.None, "[FechaRecarga]", false, true),
                  new ViewProperty("FechaVencimiento", SortDirection.None, "[FechaVencimiento]", false, true),
                  new ViewProperty("Ubicacion", SortDirection.None, "[UbicacionExtintor]", false, true),
                  new ViewProperty("UbicacionExtintor", SortDirection.None,  "iif([UbicacionExtintor] == 0,[Unidad.Nombre],iif([UbicacionExtintor] == 1, [Oficina], 'Almacen'))", false, true),
                  new ViewProperty("Destino", SortDirection.None,  "iif([UbicacionExtintor] == 0,ToStr([Unidad.Oid]),iif([UbicacionExtintor] == 1, [Oficina], 'Almacen'))", false, true),
                  new ViewProperty("Peso", SortDirection.None,  "[Peso]", false, true),
                  new ViewProperty("Tipo", SortDirection.None,  "[Tipo]", false, true),
                  new ViewProperty("EstadoExtintor", SortDirection.None,  "[EstadoExtintor]", false, true),
                  new ViewProperty("FechaInventario", SortDirection.None,  "[FechaInventario]", false, true),
                  new ViewProperty("UltimoComentario", SortDirection.None,  "[UltimoComentario]", false, true)
            });
            xpExtintores.Criteria = go;
            foreach (ViewRecord viewExtintor in xpExtintores)
            {
                Extintor Extintor = new Extintor();
                Extintor.ID = Convert.ToInt32(viewExtintor["Oid"]);
                Extintor.Revisado = Convert.ToBoolean(viewExtintor["Revisado"]);
                Extintor.NumExtintor = Convert.ToInt32(viewExtintor["NumExtintor"]);
                Extintor.FechaRecarga = Convert.ToDateTime(viewExtintor["FechaRecarga"]).Date;
                Extintor.FechaVencimiento = Convert.ToDateTime(viewExtintor["FechaVencimiento"]).Date;
                Extintor.Ubicacion = (int)viewExtintor["Ubicacion"];
                Extintor.UbicacionExtintor = viewExtintor["UbicacionExtintor"].ToString();
                Extintor.Destino = viewExtintor["Destino"].ToString();
                Extintor.Peso = viewExtintor["Peso"].ToString();
                Extintor.Tipo = viewExtintor["Tipo"].ToString();
                Extintor.EstadoExtintor = (int)viewExtintor["EstadoExtintor"];
                Extintor.FechaInventario = Convert.ToDateTime(viewExtintor["FechaInventario"]);
                Extintor.UltimoComentario = viewExtintor["UltimoComentario"] == null ? "" : viewExtintor["UltimoComentario"].ToString();
                ListaExtintores.Add(Extintor);
            }
            return ListaExtintores;
        }

        [WebMethod(EnableSession = true)]
        public List<UbicacionExtintor> UbicacionesExtintor()
        {
            List<UbicacionExtintor> Ubicaciones = new List<UbicacionExtintor>();
            foreach (Enums.UbicacionExtintor val in Enum.GetValues(typeof(Enums.UbicacionExtintor)))
            {
                UbicacionExtintor Ubicacion = new UbicacionExtintor();
                Ubicacion.ID = (int)val;
                Ubicacion.Nombre = Enum.GetName(typeof(Enums.UbicacionExtintor), val);
                Ubicaciones.Add(Ubicacion);
            }
            return Ubicaciones;
        }

        [WebMethod(EnableSession = true)]
        public List<EstadoExtintor> EstadosExtintor()
        {
            List<EstadoExtintor> Estados = new List<EstadoExtintor>();
            foreach (Enums.UbicacionExtintor val in Enum.GetValues(typeof(Enums.EstadoExtintor)))
            {
                EstadoExtintor Estado = new EstadoExtintor();
                Estado.ID = (int)val;
                Estado.Nombre = Enum.GetName(typeof(Enums.EstadoExtintor), val);
                Estados.Add(Estado);
            }
            return Estados;
        }

        [WebMethod(EnableSession = true)]
        public List<Unidades> ObternerUnidades()
        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<Unidades> ListaUnidades = new List<Unidades>();
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.BuenEstado));
            go.Operands.Add(new BinaryOperator("EstadoUnidad", Enums.EstadoUnidad.Taller));
            go.Operands.Add(new NullOperator("EstadoUnidad"));
            XPView xpUnidades = new XPView(Unidad, typeof(UNIDADES.BL.Unidad));
            xpUnidades.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Revisado", SortDirection.None, "iif(GETMONTH([FechaInventarioBaterias]) == GETMONTH(NOW()), True, False)", false, true),
                  new ViewProperty("Nombre", SortDirection.None, "[Nombre]", false, true),
                  new ViewProperty("Baterias", SortDirection.None, "[Baterias]", false, true)
                 });
            xpUnidades.Criteria = go;
            xpUnidades.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord viewUnidad in xpUnidades)
            {
                Unidades UnidadCamion = new Unidades();
                UnidadCamion.ID = Convert.ToInt32(viewUnidad["Oid"]);
                UnidadCamion.Verificado = Convert.ToBoolean(viewUnidad["Revisado"]);
                UnidadCamion.Nombre = viewUnidad["Nombre"].ToString();
                UnidadCamion.Bateria = viewUnidad["Baterias"]== null ? "" : viewUnidad["Baterias"].ToString();
                ListaUnidades.Add(UnidadCamion);
            }
            return ListaUnidades;
        }

        [WebMethod(EnableSession = true)]
        public string GuardarInventarioExtintor(int IDExtintor, string FechaRecarga, string FechaVencimiento, int Ubicacion, string oficina, int IDUnidad, string Peso, int Estado, string Comentario)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UNIDADES.BL.Extintores Extintor = Unidad.GetObjectByKey<UNIDADES.BL.Extintores>(IDExtintor);
            Extintor.FechaRecarga = Convert.ToDateTime(FechaRecarga).Date;
            Extintor.FechaVencimiento = Convert.ToDateTime(FechaVencimiento).Date;
            Extintor.UbicacionExtintor = (Enums.UbicacionExtintor)Ubicacion;
            Extintor.Peso = Convert.ToDecimal(Peso);
            Extintor.Tipo = "PQS";
            Extintor.EstadoExtintor = (Enums.EstadoExtintor)Estado;
            switch (Extintor.UbicacionExtintor)
            {
                case Enums.UbicacionExtintor.Unidad:
                    Extintor.Unidad = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(IDUnidad);
                    Extintor.Oficina = string.Empty;
                    break;
                case Enums.UbicacionExtintor.Oficina:
                    Extintor.Oficina = oficina;
                    Extintor.Unidad = null;
                    break;
            }

            Extintor.FechaInventario = DateTime.Now;
            Extintor.UltimoComentario = Comentario;

            UNIDADES.BL.Clases.HistorialExtintores HistorialExtintor = new UNIDADES.BL.Clases.HistorialExtintores(Unidad);
            HistorialExtintor.NumExtintor = Extintor.NumExtintor;
            HistorialExtintor.FechaRecarga = Extintor.FechaRecarga;
            HistorialExtintor.FechaVencimiento = Extintor.FechaVencimiento;
            HistorialExtintor.UbicacionExtintor = Extintor.UbicacionExtintor;
            HistorialExtintor.Peso = Extintor.Peso;
            HistorialExtintor.Tipo = Extintor.Tipo;
            HistorialExtintor.EstadoExtintor = Extintor.EstadoExtintor;
            switch (HistorialExtintor.UbicacionExtintor)
            {
                case Enums.UbicacionExtintor.Unidad:
                    HistorialExtintor.Unidad = Extintor.Unidad;
                    HistorialExtintor.Oficina = string.Empty;
                    break;
                case Enums.UbicacionExtintor.Oficina:
                    HistorialExtintor.Oficina = Extintor.Oficina;
                    HistorialExtintor.Unidad = null;
                    break;
            }
            HistorialExtintor.FechaInventario = DateTime.Now;
            HistorialExtintor.UltimoComentario = Extintor.UltimoComentario;

            Extintor.Save();
            HistorialExtintor.Save();
            Unidad.CommitChanges();

            return "";
        }
        #endregion

        #region Baterias
        [WebMethod(EnableSession = true)]
        public string GuardarInventarioBateria(int IDUnidad, string Baterias, string Comentario)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            UNIDADES.BL.Unidad UnidadCamion = Unidad.GetObjectByKey<UNIDADES.BL.Unidad>(IDUnidad);
            UnidadCamion.FechaInventarioBaterias = DateTime.Now;
            UnidadCamion.Baterias = Baterias;
            UnidadCamion.ComentarioBateria = Comentario;
            UnidadCamion.GenerarHistorialBaterias(Baterias, DateTime.Now, Comentario);
            UnidadCamion.Save();
            Unidad.CommitChanges();
            return "";
        }
        #endregion

        #region Anuncios

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<string> ObtenerAnuncios(int Lugar)

        {
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            List<string> ListaAnuncios = new List<string>();
            GroupOperator goMain = new GroupOperator(GroupOperatorType.And);
            goMain.Operands.Add(new BinaryOperator("Publicar", true));
            GroupOperator go = new GroupOperator(GroupOperatorType.Or);
            go.Operands.Add(new BinaryOperator("LugarPublicar", Lugar));
            go.Operands.Add(new BinaryOperator("LugarPublicar", 3));
            goMain.Operands.Add(go);

            XPView Anuncios = new XPView(Unidad, typeof(ATRCBASE.BL.AnuncioUsuario));
            Anuncios.Properties.AddRange(new ViewProperty[] {
                  new ViewProperty("Oid", SortDirection.None, "[Oid]", false, true),
                  new ViewProperty("Anuncio", SortDirection.None, "[Anuncio]", false, true)
                 });
            Anuncios.Criteria = goMain;
            //Anuncios.Criteria = new BinaryOperator("Fecha", DateTime.Now.Date);
            //Anuncios.Sorting.Add(new DevExpress.Xpo.SortingCollection(new DevExpress.Xpo.SortProperty("Unidad.Nombre", DevExpress.Xpo.DB.SortingDirection.Ascending)));
            foreach (ViewRecord Anuncio in Anuncios)
            {
                //Anuncios NuevoAnuncio = new Anuncios();
                System.IO.MemoryStream stream = new System.IO.MemoryStream(Anuncio["Anuncio"] as byte[]);
                Image returnImage = Image.FromStream(stream);
                //ATRCBASE.BL.Utilerias.GetExtension(returnImage);
                //NuevoAnuncio.Imagen = "data:image/jpeg"/*"+ ATRCBASE.BL.Utilerias.GetExtension(returnImage).ToString() + "*/+ ";base64," + Convert.ToBase64String(Anuncio["Anuncio"] as byte[]);
                ListaAnuncios.Add("data:image/jpeg"/*"+ ATRCBASE.BL.Utilerias.GetExtension(returnImage).ToString() + "*/+ ";base64," + Convert.ToBase64String(Anuncio["Anuncio"] as byte[]));
            }
            return ListaAnuncios;
        }
        #endregion

        #region RFID
        [WebMethod(EnableSession = true)]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int AccesoComedor(string IDCard)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            go.Operands.Add(new BinaryOperator("IDCard", Convert.ToInt32(IDCard)));
            go.Operands.Add(new BinaryOperator("AccesoComedor", true));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                RegistroAccesos Registro = new RegistroAccesos(Unidad);
                Registro.IDCard = Convert.ToInt32(IDCard);
                Registro.TipoAcceso = TipoAcceso.Comedor;
                Registro.Usuario = Usuario;
                Registro.Save();
                Unidad.CommitChanges();
                return Convert.ToInt32(IDCard);
            }
            else
                return 0;
        }

        [WebMethod(EnableSession = true)]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int AccesoDormitorio(string IDCard)
        {
            Session["OidAdministrador"] = 1;
            UnidadDeTrabajo Unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            GroupOperator go = new GroupOperator();
            TimeSpan Hora = DateTime.Now.TimeOfDay;
            go.Operands.Add(new BinaryOperator("IDCard", Convert.ToInt32(IDCard)));
            go.Operands.Add(new BinaryOperator("AccesoDormitorio", true));
            go.Operands.Add(new BinaryOperator("HoraDormitorioDe", Hora, BinaryOperatorType.LessOrEqual));
            go.Operands.Add(new BinaryOperator("HoraDormitorioA", Hora, BinaryOperatorType.GreaterOrEqual));
            Usuario Usuario = (Usuario)Unidad.FindObject(typeof(Usuario), go);
            if (Usuario != null)
            {
                RegistroAccesos Registro = new RegistroAccesos(Unidad);
                Registro.IDCard = Convert.ToInt32(IDCard);
                Registro.TipoAcceso = TipoAcceso.Dormitorio;
                Registro.Usuario = Usuario;
                Registro.Save();
                Unidad.CommitChanges();
                return 1;
            }
            else
                return 0;
        }
        #endregion

        #region Clases de Diesel
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
            public int Millas { set; get; }
            public int Tanque1 { set; get; }
            public int Tanque2 { set; get; }
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
            public bool Verificado { set; get; }
            public string Nombre { set; get; }
            public string Bateria { set; get; }
        }

        public class MedidorTanques
        {
            public string Nombre { set; get; }
            public string Fecha { set; get; }
            public string Inicial { set; get; }
            public string Final { set; get; }
            public string TotalMedidor { set; get; }
            public string TotalTanque { set; get; }
            public string Diferencia { set; get; }
        }
        #endregion

        #region Clases de Inventarios
        public class Extintor
        {
            public int ID { set; get; }
            public bool Revisado { set; get; }
            public int NumExtintor { set; get; }
            public DateTime FechaRecarga { set; get; }
            public DateTime FechaVencimiento { set; get; }
            public int Ubicacion { set; get; }
            public string UbicacionExtintor { set; get; }
            public string Destino { set; get; }
            public string Peso { set; get; }
            public string Tipo { set; get; }
            public int EstadoExtintor { set; get; }
            public DateTime FechaInventario { set; get; }
            public string UltimoComentario { set; get; }

        }

        public class EstadoExtintor
        {
            public int ID { set; get; }
            public string Nombre { set; get; }
        }
        public class UbicacionExtintor
        {
            public int ID { set; get; }
            public string Nombre { set; get; }
        }
        #endregion

        #region Clases de gasolina
        public class Gasolina
        {
            public int ID { set; get; }
            public string Unidad { set; get; }
            public string Empleado { set; get; }
            public bool Llenado { set; get; }
            public decimal Litros { set; get; }
        }
        #endregion

        #region Clases Anuncios
        public class Anuncios
        {
            public string Imagen { set; get; }
        }
        #endregion

    }
}
