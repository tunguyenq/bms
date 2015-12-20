using ComesticOhui.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public int IsDeleted { get; set; }


        private BmsContext db = new BmsContext();
        public IQueryable<CategoryDTO> getCategory(int id)
        {

            var category = from b in db.Posts
                           select new CategoryDTO(){
                               Id = b.Id,
                               Slug = b.Slug,
                               Name = b.Name,
                               IsDeleted = b.IsDeleted
                           };
            return category;
        }

        public IQueryable<CategoryDTO> getCategory()
        {
            var category = from b in db.Posts where b.IsDeleted == 0
                           select new CategoryDTO()
                           {
                               Id = b.Id,
                               Slug = b.Slug,
                               Name = b.Name,
                               IsDeleted = b.IsDeleted
                           };
            return category;
        }

    }

   
}