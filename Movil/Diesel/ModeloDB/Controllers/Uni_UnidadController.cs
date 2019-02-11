using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.OData.Routing;


namespace ModeloDB {
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using ModeloDB;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Com_DetallesCandados>("Com_DetallesCandados");
    builder.EntitySet<Com_Diesel>("Com_Diesel");
    builder.EntitySet<Com_Gasolina>("Com_Gasolina");
    builder.EntitySet<gen_Usuario>("gen_Usuario");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Uni_UnidadController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Uni_Unidad
        [EnableQuery]
        public IQueryable<Uni_Unidad> GetUni_Unidad()
        {
            return db.Uni_Unidad;
        }

        // GET: odata/Uni_Unidad(5)
        [EnableQuery]
        public SingleResult<Uni_Unidad> GetUni_Unidad([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Uni_Unidad.Where(uni_unidad => uni_unidad.OID == key));
        }

        // POST: odata/Uni_Unidad
        public IHttpActionResult Post(Uni_Unidad uni_unidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uni_Unidad.Add(uni_unidad);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }
                throw new System.Data.Entity.Validation.DbEntityValidationException("Entity Validation Failed - errors follow:\n" + sb.ToString(), ex );
            }

            return Created(uni_unidad);
        }

        // PATCH: odata/Uni_Unidad(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Uni_Unidad> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Uni_Unidad uni_unidad = db.Uni_Unidad.Find(key);
            if (uni_unidad == null)
            {
                return NotFound();
            }

            patch.Patch(uni_unidad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Uni_UnidadExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(uni_unidad);
        }

        // DELETE: odata/Uni_Unidad(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Uni_Unidad uni_unidad = db.Uni_Unidad.Find(key);
            if (uni_unidad == null)
            {
                return NotFound();
            }

            db.Uni_Unidad.Remove(uni_unidad);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Uni_UnidadExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Uni_Unidad(5)/Com_DetallesCandados
        [EnableQuery]
        public IQueryable<Com_DetallesCandados> GetCom_DetallesCandados([FromODataUri] Int32 key)
        {
            return db.Uni_Unidad.Where(m => m.OID == key).SelectMany(m => m.Com_DetallesCandados);
        }

        // GET: odata/Uni_Unidad(5)/Com_Diesel
        [EnableQuery]
        public IQueryable<Com_Diesel> GetCom_Diesel([FromODataUri] Int32 key)
        {
            return db.Uni_Unidad.Where(m => m.OID == key).SelectMany(m => m.Com_Diesel);
        }

        // GET: odata/Uni_Unidad(5)/Com_Gasolina
        [EnableQuery]
        public IQueryable<Com_Gasolina> GetCom_Gasolina([FromODataUri] Int32 key)
        {
            return db.Uni_Unidad.Where(m => m.OID == key).SelectMany(m => m.Com_Gasolina);
        }

        // GET: odata/Uni_Unidad(5)/gen_Usuario
        [EnableQuery]
        public SingleResult<gen_Usuario> Getgen_Usuario([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Uni_Unidad.Where(m => m.OID == key).Select(m => m.gen_Usuario));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Uni_UnidadExists(Int32 key)
        {
            return db.Uni_Unidad.Count(e => e.OID == key) > 0;
        }
    }
}
