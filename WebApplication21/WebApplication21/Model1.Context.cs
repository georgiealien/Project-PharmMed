﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication21
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hrb2_dbEntities : DbContext
    {
        public hrb2_dbEntities()
            : base("name=hrb2_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<help> helps { get; set; }
        public virtual DbSet<med_order> med_order { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<medicine> medicines { get; set; }
    }
}
