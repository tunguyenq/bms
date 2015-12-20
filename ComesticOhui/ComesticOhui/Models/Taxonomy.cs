using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models
{
    public class Taxonomy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime Date_Add { get; set; }
        public DateTime Date_modified { get; set; }
        public int IsDeleted { get; set; }

        public virtual ICollection<Post_Tax> Post_tax { get; set; }
    }
}