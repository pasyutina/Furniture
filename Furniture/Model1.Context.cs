﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Furniture
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FurnitureEntities3 : DbContext
    {
        public FurnitureEntities3()
            : base("name=FurnitureEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgentSet> AgentSet { get; set; }
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<DealSet> DealSet { get; set; }
        public virtual DbSet<ProductSet> ProductSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
