using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Parent_Id { get; set; }
        public string Post_type { get; set; }
        public string Slug { get; set; }
        public DateTime Post_date { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Post_Status { get; set; }
        public string Name { get; set; }
        public DateTime Post_Modifield { get; set; }
        public int IsDeleted { get; set; }
        public int Author { get; set; }
      

        public virtual ICollection<Post_Tax> Post_Tax { get; set; }
    }
}