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
    builder.EntitySet<Com_RecargaDiesel>("Com_RecargaDiesel");
    builder.EntitySet<Uni_Unidad>("Uni_Unidad");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Com_DieselController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Com_Diesel
        [EnableQuery]
        public IQueryable<Com_Diesel> GetCom_Diesel()
        {
            return db.Com_Diesel;
        }

        // GET: odata/Com_Diesel(5)
        [EnableQuery]
        public SingleResult<Com_Diesel> GetCom_Diesel([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_Diesel.Where(com_diesel => com_diesel.OID == key));
        }

        // POST: odata/Com_Diesel
        public IHttpActionResult Post(Com_Diesel com_diesel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Com_Diesel.Add(com_diesel);
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

            return Created(com_diesel);
        }

        // PATCH: odata/Com_Diesel(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Com_Diesel> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Com_Diesel com_diesel = db.Com_Diesel.Find(key);
            if (com_diesel == null)
            {
                return NotFound();
            }

            patch.Patch(com_diesel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DieselExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(com_diesel);
        }

        // DELETE: odata/Com_Diesel(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Com_Diesel com_diesel = db.Com_Diesel.Find(key);
            if (com_diesel == null)
            {
                return NotFound();
            }

            db.Com_Diesel.Remove(com_diesel);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DieselExists(key))
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

        // GET: odata/Com_Diesel(5)/gen_Usuario
        [EnableQuery]
        public SingleResult<gen_Usuario> Getgen_Usuario([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_Diesel.Where(m => m.OID == key).Select(m => m.gen_Usuario));
        }

        // GET: odata/Com_Diesel(5)/Com_RecargaDiesel
        [EnableQuery]
        public SingleResult<Com_RecargaDiesel> GetCom_RecargaDiesel([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_Diesel.Where(m => m.OID == key).Select(m => m.Com_RecargaDiesel));
        }

        // GET: odata/Com_Diesel(5)/Uni_Unidad
        [EnableQuery]
        public SingleResult<Uni_Unidad> GetUni_Unidad([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_Diesel.Where(m => m.OID == key).Select(m => m.Uni_Unidad));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Com_DieselExists(Int32 key)
        {
            return db.Com_Diesel.Count(e => e.OID == key) > 0;
        }
    }
}
