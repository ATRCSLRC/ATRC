using System;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ModeloDB {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.SetTimeZoneInfo(TimeZoneInfo.Utc);

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<Com_DetallesCandados>("Com_DetallesCandados");
            builder.EntityType<Com_DetallesCandados>().HasKey(entity => entity.OID);
            builder.EntityType<Com_DetallesCandados>().HasOptional<gen_Usuario>(entity => entity.gen_Usuario, (entity, tergetEntity) => entity.Empleado == tergetEntity.OID);
            builder.EntityType<Com_DetallesCandados>().HasOptional<Uni_Unidad>(entity => entity.Uni_Unidad, (entity, tergetEntity) => entity.Unidad == tergetEntity.OID);

            builder.EntitySet<Com_Diesel>("Com_Diesel");
            builder.EntityType<Com_Diesel>().HasKey(entity => entity.OID);
            builder.EntityType<Com_Diesel>().HasOptional<gen_Usuario>(entity => entity.gen_Usuario, (entity, tergetEntity) => entity.Empleado == tergetEntity.OID);
            builder.EntityType<Com_Diesel>().HasOptional<Com_RecargaDiesel>(entity => entity.Com_RecargaDiesel, (entity, tergetEntity) => entity.UltimaRecarga == tergetEntity.OID);
            builder.EntityType<Com_Diesel>().HasOptional<Uni_Unidad>(entity => entity.Uni_Unidad, (entity, tergetEntity) => entity.Unidad == tergetEntity.OID);

            builder.EntitySet<Com_DieselActual>("Com_DieselActual");
            builder.EntityType<Com_DieselActual>().HasKey(entity => entity.OID);

            builder.EntitySet<Com_Gasolina>("Com_Gasolina");
            builder.EntityType<Com_Gasolina>().HasKey(entity => entity.OID);
            builder.EntityType<Com_Gasolina>().HasOptional<gen_Usuario>(entity => entity.gen_Usuario, (entity, tergetEntity) => entity.Empleado == tergetEntity.OID);
            builder.EntityType<Com_Gasolina>().HasOptional<Com_RecargaDiesel>(entity => entity.Com_RecargaDiesel, (entity, tergetEntity) => entity.UltimaRecarga == tergetEntity.OID);
            builder.EntityType<Com_Gasolina>().HasOptional<Uni_Unidad>(entity => entity.Uni_Unidad, (entity, tergetEntity) => entity.Unidad == tergetEntity.OID);

            builder.EntitySet<Com_MedidorDiesel>("Com_MedidorDiesel");
            builder.EntityType<Com_MedidorDiesel>().HasKey(entity => entity.OID);
            builder.EntityType<Com_MedidorDiesel>().HasOptional<Com_DieselActual>(entity => entity.Com_DieselActual, (entity, tergetEntity) => entity.Tanque == tergetEntity.OID);

            builder.EntitySet<Com_RecargaDiesel>("Com_RecargaDiesel");
            builder.EntityType<Com_RecargaDiesel>().HasKey(entity => entity.OID);
            builder.EntityType<Com_RecargaDiesel>().HasOptional<Com_DieselActual>(entity => entity.Com_DieselActual, (entity, tergetEntity) => entity.Tanque == tergetEntity.OID);

            builder.EntitySet<gen_Puesto>("gen_Puesto");
            builder.EntityType<gen_Puesto>().HasKey(entity => entity.OID);

            builder.EntitySet<gen_Usuario>("gen_Usuario");
            builder.EntityType<gen_Usuario>().HasKey(entity => entity.OID);
            builder.EntityType<gen_Usuario>().HasOptional<gen_Puesto>(entity => entity.gen_Puesto, (entity, tergetEntity) => entity.Puesto == tergetEntity.OID);

            builder.EntitySet<Uni_Unidad>("Uni_Unidad");
            builder.EntityType<Uni_Unidad>().HasKey(entity => entity.OID);
            builder.EntityType<Uni_Unidad>().HasOptional<gen_Usuario>(entity => entity.gen_Usuario, (entity, tergetEntity) => entity.Usuario == tergetEntity.OID);

            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
