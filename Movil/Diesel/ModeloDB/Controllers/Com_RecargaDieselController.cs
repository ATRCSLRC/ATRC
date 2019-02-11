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
    builder.EntitySet<Com_Diesel>("Com_Diesel");
    builder.EntitySet<Com_DieselActual>("Com_DieselActual");
    builder.EntitySet<Com_Gasolina>("Com_Gasolina");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Com_RecargaDieselController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Com_RecargaDiesel
        [EnableQuery]
        public IQueryable<Com_RecargaDiesel> GetCom_RecargaDiesel()
        {
            return db.Com_RecargaDiesel;
        }

        // GET: odata/Com_RecargaDiesel(5)
        [EnableQuery]
        public SingleResult<Com_RecargaDiesel> GetCom_RecargaDiesel([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_RecargaDiesel.Where(com_recargadiesel => com_recargadiesel.OID == key));
        }

        // POST: odata/Com_RecargaDiesel
        public IHttpActionResult Post(Com_RecargaDiesel com_recargadiesel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Com_RecargaDiesel.Add(com_recargadiesel);
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

            return Created(com_recargadiesel);
        }

        // PATCH: odata/Com_RecargaDiesel(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Com_RecargaDiesel> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Com_RecargaDiesel com_recargadiesel = db.Com_RecargaDiesel.Find(key);
            if (com_recargadiesel == null)
            {
                return NotFound();
            }

            patch.Patch(com_recargadiesel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_RecargaDieselExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(com_recargadiesel);
        }

        // DELETE: odata/Com_RecargaDiesel(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Com_RecargaDiesel com_recargadiesel = db.Com_RecargaDiesel.Find(key);
            if (com_recargadiesel == null)
            {
                return NotFound();
            }

            db.Com_RecargaDiesel.Remove(com_recargadiesel);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_RecargaDieselExists(key))
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

        // GET: odata/Com_RecargaDiesel(5)/Com_Diesel
        [EnableQuery]
        public IQueryable<Com_Diesel> GetCom_Diesel([FromODataUri] Int32 key)
        {
            return db.Com_RecargaDiesel.Where(m => m.OID == key).SelectMany(m => m.Com_Diesel);
        }

        // GET: odata/Com_RecargaDiesel(5)/Com_DieselActual
        [EnableQuery]
        public SingleResult<Com_DieselActual> GetCom_DieselActual([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_RecargaDiesel.Where(m => m.OID == key).Select(m => m.Com_DieselActual));
        }

        // GET: odata/Com_RecargaDiesel(5)/Com_Gasolina
        [EnableQuery]
        public IQueryable<Com_Gasolina> GetCom_Gasolina([FromODataUri] Int32 key)
        {
            return db.Com_RecargaDiesel.Where(m => m.OID == key).SelectMany(m => m.Com_Gasolina);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Com_RecargaDieselExists(Int32 key)
        {
            return db.Com_RecargaDiesel.Count(e => e.OID == key) > 0;
        }
    }
}
