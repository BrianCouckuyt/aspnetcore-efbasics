using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCourse.EFBasics.Web.Entities
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public Teacher Lecturer { get; set; }

        public string Description { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
