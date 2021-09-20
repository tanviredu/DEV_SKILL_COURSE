using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double CGPA { get; set; }

        // you need to have a list of pivot entites
        // in each entity to make a many to many relationship

        public List<CourseStudent> StudentCourses { get; set; }
    }
}
