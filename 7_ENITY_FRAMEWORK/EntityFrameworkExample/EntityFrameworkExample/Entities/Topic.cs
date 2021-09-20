using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample.Entities
{
    public class Topic
    {
        public int id {get;set;}
        public string Name { get; set; }

        // this is the relation
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
