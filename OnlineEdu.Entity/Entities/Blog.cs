﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }       
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        //blog category relation -- 1 to many
        public int BlogCategoryId { get; set; }        
        public BlogCategory BlogCategory { get; set; }
    }
}
