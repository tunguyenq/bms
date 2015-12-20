using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short_Content { get; set; }
        public string Long_Content { get; set; }
        public int IsDeleted { get; set; }
        public int Author { get; set; }
        public int Category { get; set; }
        public int Company { get; set; }
    }
}