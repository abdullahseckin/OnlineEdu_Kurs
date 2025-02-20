﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }    
        public string Description { get; set; }
        public bool IsShown { get; set; }

        //course relation -- 1 to many
        public List<Course> Courses { get; set; }
       
    }
}
