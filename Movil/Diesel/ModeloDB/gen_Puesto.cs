//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class gen_Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gen_Puesto()
        {
            this.gen_Usuario = new HashSet<gen_Usuario>();
        }
    
        public int OID { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioAlta { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gen_Usuario> gen_Usuario { get; set; }
    }
}