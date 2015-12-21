namespace ComesticOhui.Migrations
{
    using ComesticOhui.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ComesticOhui.Models.DAL.BmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ComesticOhui.Models.DAL.BmsContext context)
        {
            //var Posts = new List<Post>
            //{
            //    new Post{Content = "DesSP1",Post_type = "category",Parent_Id = 0, Name = "SPkjkjj", IsDeleted = 0, Post_Status = "publish", Excerpt = "", Title = "", Post_date = DateTime.Parse("2015-09-01"), Post_Modifield = DateTime.Parse("2015-09-01")},
            //};

            //Posts.ForEach(s => context.Posts.Add(s));
            //context.SaveChanges();


            //var Taxonomies = new List<Category>
            //{
            //    new Category{Name = "tax1", Tax_Type = "Category", IsDeleted = 0, Slug= "tax1", Date_Add = DateTime.Parse("2015-09-01"),Date_modified = DateTime.Parse("2015-09-01")},
            //};

            //Taxonomies.ForEach(s => context.Taxonomies.Add(s));
            //context.SaveChanges();

            //var Post_taxs = new List<Post_Tax>
            //{
            //    new Post_Tax{PostId = 1, TaxononyId = 1},
            //};

            //Post_taxs.ForEach(s => context.Post_taxs.Add(s));
            //context.SaveChanges();
        }
    }
}
