﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class courseExampleEntities : DbContext
{
    public courseExampleEntities()
        : base("name=courseExampleEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<assignment> assignments { get; set; }
    public virtual DbSet<Cours> Courses { get; set; }
    public virtual DbSet<enrolled> enrolleds { get; set; }
    public virtual DbSet<grade> grades { get; set; }
    public virtual DbSet<User> Users { get; set; }
}
