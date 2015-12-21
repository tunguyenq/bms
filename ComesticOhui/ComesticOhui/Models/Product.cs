using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models
{
    public class Product
    
    {
        public int Id { get; set; }
        public string Post_type { get; set; }
        public string Slug { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime Post_date { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Post_Status { get; set; }
        public string Name { get; set; }
        public DateTime Post_Modifield { get; set; }
        public int IsDeleted { get; set; }
        public int Author { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Category_Product> Category_Product { get; set; }
    }
}