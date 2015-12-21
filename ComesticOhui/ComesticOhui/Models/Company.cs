﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComesticOhui.Models
{
    public enum State
    {
        Draft, Publish
    }
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string IsDeleted { get; set; }
        public State ? State { get; set; }

        public virtual ICollection<Product> product { get; set; }
    }
}