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
        public DbSet<Post> Posts { get; set; }
        public DbSet<Taxonomy> Taxonomies { get; set; }
        public DbSet<Post_Tax> Post_taxs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}