using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models.DAL
{
    public class BmsContext:DbContext
    {
        public BmsContext() : base("BmsContext")
        {

        }
        public DbSet<Product> Posts { get; set; }
        public DbSet<Category> Taxonomies { get; set; }
        public DbSet<Category_Product> Category_Product { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}