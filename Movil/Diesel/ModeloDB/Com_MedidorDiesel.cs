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
    
    public partial class Com_MedidorDiesel
    {
        public int OID { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioAlta { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
        public Nullable<long> Inicial { get; set; }
        public Nullable<long> Final { get; set; }
        public Nullable<int> Tanque { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual Com_DieselActual Com_DieselActual { get; set; }
    }
}
