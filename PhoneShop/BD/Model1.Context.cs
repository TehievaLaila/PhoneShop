﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneShop.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prog13Entities : DbContext
    {
        public prog13Entities()
            : base("name=prog13Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActRepair> ActRepair { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TypePhone> TypePhone { get; set; }
        public DbSet<TypeProblem> TypeProblem { get; set; }
        public DbSet<User> User { get; set; }
    }
}