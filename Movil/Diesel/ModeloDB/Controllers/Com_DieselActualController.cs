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
    builder.EntitySet<Com_MedidorDiesel>("Com_MedidorDiesel");
    builder.EntitySet<Com_RecargaDiesel>("Com_RecargaDiesel");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Com_DieselActualController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Com_DieselActual
        [EnableQuery]
        public IQueryable<Com_DieselActual> GetCom_DieselActual()
        {
            return db.Com_DieselActual;
        }

        // GET: odata/Com_DieselActual(5)
        [EnableQuery]
        public SingleResult<Com_DieselActual> GetCom_DieselActual([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_DieselActual.Where(com_dieselactual => com_dieselactual.OID == key));
        }

        // POST: odata/Com_DieselActual
        public IHttpActionResult Post(Com_DieselActual com_dieselactual)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Com_DieselActual.Add(com_dieselactual);
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

            return Created(com_dieselactual);
        }

        // PATCH: odata/Com_DieselActual(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Com_DieselActual> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Com_DieselActual com_dieselactual = db.Com_DieselActual.Find(key);
            if (com_dieselactual == null)
            {
                return NotFound();
            }

            patch.Patch(com_dieselactual);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DieselActualExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(com_dieselactual);
        }

        // DELETE: odata/Com_DieselActual(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Com_DieselActual com_dieselactual = db.Com_DieselActual.Find(key);
            if (com_dieselactual == null)
            {
                return NotFound();
            }

            db.Com_DieselActual.Remove(com_dieselactual);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_DieselActualExists(key))
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

        // GET: odata/Com_DieselActual(5)/Com_MedidorDiesel
        [EnableQuery]
        public IQueryable<Com_MedidorDiesel> GetCom_MedidorDiesel([FromODataUri] Int32 key)
        {
            return db.Com_DieselActual.Where(m => m.OID == key).SelectMany(m => m.Com_MedidorDiesel);
        }

        // GET: odata/Com_DieselActual(5)/Com_RecargaDiesel
        [EnableQuery]
        public IQueryable<Com_RecargaDiesel> GetCom_RecargaDiesel([FromODataUri] Int32 key)
        {
            return db.Com_DieselActual.Where(m => m.OID == key).SelectMany(m => m.Com_RecargaDiesel);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Com_DieselActualExists(Int32 key)
        {
            return db.Com_DieselActual.Count(e => e.OID == key) > 0;
        }
    }
}
