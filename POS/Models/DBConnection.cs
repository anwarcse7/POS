using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;  

namespace POS.Models
{
    public class DBConnection : DbContext
    {
        public DbSet<Assets> Assets { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<DamageProduct> DamageProduct { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalary { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductGroup> ProductGroup { get; set; }
        public DbSet<ProductReturn> ProductReturn { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }
        public DbSet<SalesInvoice> SalesInvoice { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<ShopBranch> ShopBranch { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 
    }
}