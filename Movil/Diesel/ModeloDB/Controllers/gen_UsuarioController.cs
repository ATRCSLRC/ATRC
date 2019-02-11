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
    builder.EntitySet<gen_Puesto>("gen_Puesto");
    builder.EntitySet<Uni_Unidad>("Uni_Unidad");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class gen_UsuarioController : ODataController
    {
        private ATRCPRODUCCIONEntities db = new ATRCPRODUCCIONEntities();

        // GET: odata/gen_Usuario
        [EnableQuery]
        public IQueryable<gen_Usuario> Getgen_Usuario()
        {
            return db.gen_Usuario;
        }

        // GET: odata/gen_Usuario(5)
        [EnableQuery]
        public SingleResult<gen_Usuario> Getgen_Usuario([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.gen_Usuario.Where(gen_usuario => gen_usuario.OID == key));
        }

        // POST: odata/gen_Usuario
        public IHttpActionResult Post(gen_Usuario gen_usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.gen_Usuario.Add(gen_usuario);
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

            return Created(gen_usuario);
        }

        // PATCH: odata/gen_Usuario(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] Int32 key, Delta<gen_Usuario> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gen_Usuario gen_usuario = db.gen_Usuario.Find(key);
            if (gen_usuario == null)
            {
                return NotFound();
            }

            patch.Patch(gen_usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gen_UsuarioExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(gen_usuario);
        }

        // DELETE: odata/gen_Usuario(5)
        public IHttpActionResult Delete([FromODataUri] Int32 key)
        {
            gen_Usuario gen_usuario = db.gen_Usuario.Find(key);
            if (gen_usuario == null)
            {
                return NotFound();
            }

            db.gen_Usuario.Remove(gen_usuario);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gen_UsuarioExists(key))
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

        // GET: odata/gen_Usuario(5)/Com_DetallesCandados
        [EnableQuery]
        public IQueryable<Com_DetallesCandados> GetCom_DetallesCandados([FromODataUri] Int32 key)
        {
            return db.gen_Usuario.Where(m => m.OID == key).SelectMany(m => m.Com_DetallesCandados);
        }

        // GET: odata/gen_Usuario(5)/Com_Diesel
        [EnableQuery]
        public IQueryable<Com_Diesel> GetCom_Diesel([FromODataUri] Int32 key)
        {
            return db.gen_Usuario.Where(m => m.OID == key).SelectMany(m => m.Com_Diesel);
        }

        // GET: odata/gen_Usuario(5)/Com_Gasolina
        [EnableQuery]
        public IQueryable<Com_Gasolina> GetCom_Gasolina([FromODataUri] Int32 key)
        {
            return db.gen_Usuario.Where(m => m.OID == key).SelectMany(m => m.Com_Gasolina);
        }

        // GET: odata/gen_Usuario(5)/gen_Puesto
        [EnableQuery]
        public SingleResult<gen_Puesto> Getgen_Puesto([FromODataUri] Int32 key)
        {
            return SingleResult.Create(db.gen_Usuario.Where(m => m.OID == key).Select(m => m.gen_Puesto));
        }

        // GET: odata/gen_Usuario(5)/Uni_Unidad
        [EnableQuery]
        public IQueryable<Uni_Unidad> GetUni_Unidad([FromODataUri] Int32 key)
        {
            return db.gen_Usuario.Where(m => m.OID == key).SelectMany(m => m.Uni_Unidad);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool gen_UsuarioExists(Int32 key)
        {
            return db.gen_Usuario.Count(e => e.OID == key) > 0;
        }
    }
}
