﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MonografiasEntities1 : DbContext
    {
        public MonografiasEntities1()
            : base("name=MonografiasEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Defensa> Defensa { get; set; }
        public virtual DbSet<Detalle_Revision_Protocolo> Detalle_Revision_Protocolo { get; set; }
        public virtual DbSet<Doc_Prof> Doc_Prof { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Est_Doc> Est_Doc { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Predefensa> Predefensa { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TipoDoc> TipoDoc { get; set; }
    }
}
