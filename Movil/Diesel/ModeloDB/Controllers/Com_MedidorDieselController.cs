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
    builder.EntitySet<Com_DieselActual>("Com_DieselActual");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Com_MedidorDieselController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/Com_MedidorDiesel
        [EnableQuery]
        public IQueryable<Com_MedidorDiesel> GetCom_MedidorDiesel()
        {
            return db.Com_MedidorDiesel;
        }

        // GET: odata/Com_MedidorDiesel(5)
        [EnableQuery]
        public SingleResult<Com_MedidorDiesel> GetCom_MedidorDiesel([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_MedidorDiesel.Where(com_medidordiesel => com_medidordiesel.OID == key));
        }

        // POST: odata/Com_MedidorDiesel
        public IHttpActionResult Post(Com_MedidorDiesel com_medidordiesel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Com_MedidorDiesel.Add(com_medidordiesel);
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

            return Created(com_medidordiesel);
        }

        // PATCH: odata/Com_MedidorDiesel(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<Com_MedidorDiesel> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Com_MedidorDiesel com_medidordiesel = db.Com_MedidorDiesel.Find(key);
            if (com_medidordiesel == null)
            {
                return NotFound();
            }

            patch.Patch(com_medidordiesel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_MedidorDieselExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(com_medidordiesel);
        }

        // DELETE: odata/Com_MedidorDiesel(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            Com_MedidorDiesel com_medidordiesel = db.Com_MedidorDiesel.Find(key);
            if (com_medidordiesel == null)
            {
                return NotFound();
            }

            db.Com_MedidorDiesel.Remove(com_medidordiesel);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Com_MedidorDieselExists(key))
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

        // GET: odata/Com_MedidorDiesel(5)/Com_DieselActual
        [EnableQuery]
        public SingleResult<Com_DieselActual> GetCom_DieselActual([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.Com_MedidorDiesel.Where(m => m.OID == key).Select(m => m.Com_DieselActual));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Com_MedidorDieselExists(Int32 key)
        {
            return db.Com_MedidorDiesel.Count(e => e.OID == key) > 0;
        }
    }
}
