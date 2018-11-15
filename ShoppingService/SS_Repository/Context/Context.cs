using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
namespace SS_Repository.Context
{
    class Context : DbContext
    {
        public Context() : base("ShoppingServiceDB")
        {
        }
        public DbSet<Account> AccountSet { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove(conventions:new System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention());
        }
    }
}
