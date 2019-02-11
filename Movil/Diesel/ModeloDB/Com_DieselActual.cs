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
    
    public partial class Com_DieselActual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Com_DieselActual()
        {
            this.Com_MedidorDiesel = new HashSet<Com_MedidorDiesel>();
            this.Com_RecargaDiesel = new HashSet<Com_RecargaDiesel>();
        }
    
        public int OID { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioAlta { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Capacidad { get; set; }
        public Nullable<long> Cantidad { get; set; }
        public Nullable<int> TipoCombustible { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Com_MedidorDiesel> Com_MedidorDiesel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Com_RecargaDiesel> Com_RecargaDiesel { get; set; }
    }
}
