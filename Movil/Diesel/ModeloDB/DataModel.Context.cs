﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ATRCPRODUCCIONEntities : DbContext
    {
        public ATRCPRODUCCIONEntities()
            : base("name=ATRCPRODUCCIONEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Com_DetallesCandados> Com_DetallesCandados { get; set; }
        public virtual DbSet<Com_Diesel> Com_Diesel { get; set; }
        public virtual DbSet<Com_DieselActual> Com_DieselActual { get; set; }
        public virtual DbSet<Com_Gasolina> Com_Gasolina { get; set; }
        public virtual DbSet<Com_MedidorDiesel> Com_MedidorDiesel { get; set; }
        public virtual DbSet<Com_RecargaDiesel> Com_RecargaDiesel { get; set; }
        public virtual DbSet<gen_Puesto> gen_Puesto { get; set; }
        public virtual DbSet<gen_Usuario> gen_Usuario { get; set; }
        public virtual DbSet<Uni_Unidad> Uni_Unidad { get; set; }
    }
}
