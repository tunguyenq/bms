using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models
{
    public class Post_Tax
    {
        public int Id { get; set; }
        public int Post_Id { get; set; }
        public int Tax_Id { get; set; }

        public string test { get; set; }
        public virtual Post Post { get; set; }
        public virtual Taxonomy Taxonomy { get; set; }

    }
}