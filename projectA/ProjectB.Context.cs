﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectBEntities : DbContext
    {
        public ProjectBEntities()
            : base("name=ProjectBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<pond> ponds { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<fish> fish { get; set; }
        public virtual DbSet<fish_set> fish_set { get; set; }
        public virtual DbSet<food> foods { get; set; }
        public virtual DbSet<sell> sells { get; set; }
        public virtual DbSet<fish_food> fish_food { get; set; }
        public virtual DbSet<additional_cost> additional_cost { get; set; }
        public virtual DbSet<total_cost> total_cost { get; set; }
        public virtual DbSet<pond_detail> pond_detail { get; set; }
        public virtual DbSet<result> results { get; set; }
    }
}