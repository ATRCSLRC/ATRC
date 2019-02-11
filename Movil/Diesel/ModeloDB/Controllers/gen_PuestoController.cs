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
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class gen_PuestoController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/gen_Puesto
        [EnableQuery]
        public IQueryable<gen_Puesto> Getgen_Puesto()
        {
            return db.gen_Puesto;
        }

        // GET: odata/gen_Puesto(5)
        [EnableQuery]
        public SingleResult<gen_Puesto> Getgen_Puesto([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.gen_Puesto.Where(gen_puesto => gen_puesto.OID == key));
        }

        // POST: odata/gen_Puesto
        public IHttpActionResult Post(gen_Puesto gen_puesto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.gen_Puesto.Add(gen_puesto);
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

            return Created(gen_puesto);
        }

        // PATCH: odata/gen_Puesto(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<gen_Puesto> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gen_Puesto gen_puesto = db.gen_Puesto.Find(key);
            if (gen_puesto == null)
            {
                return NotFound();
            }

            patch.Patch(gen_puesto);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gen_PuestoExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(gen_puesto);
        }

        // DELETE: odata/gen_Puesto(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            gen_Puesto gen_puesto = db.gen_Puesto.Find(key);
            if (gen_puesto == null)
            {
                return NotFound();
            }

            db.gen_Puesto.Remove(gen_puesto);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gen_PuestoExists(key))
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

        // GET: odata/gen_Puesto(5)/gen_Usuario
        [EnableQuery]
        public IQueryable<gen_Usuario> Getgen_Usuario([FromODataUri] Int32 key)
        {
            return db.gen_Puesto.Where(m => m.OID == key).SelectMany(m => m.gen_Usuario);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool gen_PuestoExists(Int32 key)
        {
            return db.gen_Puesto.Count(e => e.OID == key) > 0;
        }
    }
}
