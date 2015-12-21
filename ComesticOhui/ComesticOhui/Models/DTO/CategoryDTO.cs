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
        public int IsDeleted { get; set; }


        private BmsContext db = new BmsContext();
      


       

    }

   
}