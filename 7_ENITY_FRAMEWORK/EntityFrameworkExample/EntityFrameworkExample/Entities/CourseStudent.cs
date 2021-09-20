using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample.Entities
{

    // this is the pivot table for many to many relationship
    // name is the join of two entity name
    // CourseEntity
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
