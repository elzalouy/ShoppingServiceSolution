using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingService.SSS_DAO.SSS_Entities;
namespace ShoppingService.SSS_DAO.SSS_Context
{
    public class ShoppingServiceContext : DbContext
    {
        public ShoppingServiceContext() : base("name=ShoppingServiceContext")
        {
            Database.SetInitializer<ShoppingServiceContext>(new DropCreateDatabaseIfModelChanges<ShoppingServiceContext>());
        }
        public DbSet<Account> Accounts_Table { get; set; }
        public DbSet<Administrators> Administrators_Table { get; set; }
        public DbSet<Client> Client_Table { get; set; }
        public DbSet<ClientOrder> ClientOrder_Table { get; set; }
        public DbSet<OrderDetails> Order_Table { get; set; }
        public DbSet<Product> Product_Table { get; set; }
        public DbSet<SalesNumber> SalesNumber_Table { get; set; }
        public DbSet<Seller> Seller_Table { get; set; }
        public DbSet<SellerSales> SellerSales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}