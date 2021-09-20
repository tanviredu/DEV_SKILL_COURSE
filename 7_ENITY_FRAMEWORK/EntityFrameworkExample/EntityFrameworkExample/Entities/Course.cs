using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkExample.Entities
{
    public class Course
    {
        public int id { get; set; }
        
        [StringLength(250)]
        public string Title { get; set; }
        public double Fees { get; set; }
        public List<Topic> Topics { get; set; }

        // you need to have a list of pivot entites
        // in each entity to make a many to many relationship
        public List<CourseStudent> CourseStudents { get; set; }
    }
}
