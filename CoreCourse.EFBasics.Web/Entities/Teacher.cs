﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.EFBasics.Web.Entities
{
    public class Teacher
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public decimal? YearlyWage { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
