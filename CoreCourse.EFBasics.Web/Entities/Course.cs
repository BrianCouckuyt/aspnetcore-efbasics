﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.EFBasics.Web.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Teacher Lecturer { get; set; }
    }
}
