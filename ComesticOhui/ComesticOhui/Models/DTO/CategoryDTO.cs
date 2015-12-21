using ComesticOhui.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComesticOhui.Models.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsSelected { get; set; }

        private BmsContext db = new BmsContext();
        public List<CategoryDTO> getCategoriesByProductId(int productId)
        {
            var allcategories = db.Taxonomies.ToList();
            var categoriesproductid = db.Category_Product.Where(x => x.ProductId == productId);
            List<CategoryDTO> lstCate = new List<CategoryDTO>();
            foreach (var item in allcategories)
            {
                CategoryDTO cate = new CategoryDTO();
                cate.IsSelected = false;
                cate.Name = item.Name;
                cate.Value = item.Id.ToString();
                foreach (var inp in categoriesproductid)
                {
                    if (item.Id == inp.CategoryId)
                    {
                        cate.IsSelected = true;
                    }
                }
                lstCate.Add(cate);
            }
            return lstCate;
        }
    }

   
}