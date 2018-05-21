using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.EFBasics.Web.Entities
{
    public class StudentCourse
    {
        //long omdat de student entity ook een long heeft voor zijn ID
        public long StudentId { get; set; }

        //Guid omdat de course entity ook een Guid heeft voor zijn ID
        public Guid CourseId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }

    }
}
