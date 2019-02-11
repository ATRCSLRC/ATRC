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
    builder.EntitySet<gen_Usuario>("gen_Usuario");
    builder.EntitySet<Uni_Unidad>("Uni_Unidad");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Com_DetallesCandadosController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Com_DetallesCandados
        [EnableQuery]
        public IQueryable<Com_DetallesCandados> GetCom_DetallesCandados()
        {
            return db.Com_DetallesCandados;
        }

        // GET: odata/Com_DetallesCandados(5)
        [EnableQuery]
        public SingleResult<Com_DetallesCandados> GetCom_DetallesCandados([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_DetallesCandados.Where(com_detallescandados => com_detallescandados.OID == key));
        }

        // POST: odata/Com_DetallesCandados
        public IHttpActionResult Post(Com_DetallesCandados com_detallescandados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Com_DetallesCandados.Add(com_detallescandados);
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

            return Created(com_detallescandados);
        }

        // PATCH: odata/Com_DetallesCandados(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Com_DetallesCandados> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Com_DetallesCandados com_detallescandados = db.Com_DetallesCandados.Find(key);
            if (com_detallescandados == null)
            {
                return NotFound();
            }

            patch.Patch(com_detallescandados);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DetallesCandadosExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(com_detallescandados);
        }

        // DELETE: odata/Com_DetallesCandados(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Com_DetallesCandados com_detallescandados = db.Com_DetallesCandados.Find(key);
            if (com_detallescandados == null)
            {
                return NotFound();
            }

            db.Com_DetallesCandados.Remove(com_detallescandados);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DetallesCandadosExists(key))
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

        // GET: odata/Com_DetallesCandados(5)/gen_Usuario
        [EnableQuery]
        public SingleResult<gen_Usuario> Getgen_Usuario([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_DetallesCandados.Where(m => m.OID == key).Select(m => m.gen_Usuario));
        }

        // GET: odata/Com_DetallesCandados(5)/Uni_Unidad
        [EnableQuery]
        public SingleResult<Uni_Unidad> GetUni_Unidad([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_DetallesCandados.Where(m => m.OID == key).Select(m => m.Uni_Unidad));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Com_DetallesCandadosExists(Int32 key)
        {
            return db.Com_DetallesCandados.Count(e => e.OID == key) > 0;
        }
    }
}
