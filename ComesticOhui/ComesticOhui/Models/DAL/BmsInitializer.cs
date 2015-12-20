using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models.DAL
{
    public class BmsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BmsContext>
    {
        protected override void Seed(BmsContext context)
        {
            var Posts = new List<Post>
            {
                new Post{Content = "DesSP1",Post_type = "product",Parent_Id = 0, Name = "sssdf", IsDeleted = 0, Post_Status = "publish", Excerpt = "", Title = "", Post_date = DateTime.Parse("2015-09-01"), Post_Modifield = DateTime.Parse("2015-09-01")},
            };

            Posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();


            var Taxonomies = new List<Taxonomy>
            {
                new Taxonomy{Name = "tax1", IsDeleted = 0, Slug= "tax1", Date_Add = DateTime.Parse("2015-09-01"),Date_modified = DateTime.Parse("2015-09-01")},
            };

            Taxonomies.ForEach(s => context.Taxonomies.Add(s));
            context.SaveChanges();

            var Post_taxs = new List<Post_Tax>
            {
                new Post_Tax{Post_Id = 1, Tax_Id = 1},
            };

            Post_taxs.ForEach(s => context.Post_taxs.Add(s));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}