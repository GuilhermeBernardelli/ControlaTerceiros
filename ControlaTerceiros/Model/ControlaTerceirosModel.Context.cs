﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlaTerceiros.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GTIEntities : DbContext
    {
        public GTIEntities()
            : base("name=GTIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Apoio_Aplicabilidade> Apoio_Aplicabilidade { get; set; }
        public DbSet<Apoio_Grupo> Apoio_Grupo { get; set; }
        public DbSet<Apoio_Item> Apoio_Item { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Pessoa_Empresa> Pessoa_Empresa { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
    }
}