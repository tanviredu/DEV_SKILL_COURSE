using System;
using System.Collections.Generic;
namespace Practice.Entities
{
    public class Course {

        public int Id {get;set;}
        public string Title {get;set;}
        public double Fees {get;set;}

        public List<Topic>Topics {get;set;}
        public List<CourseStudent>CourseStudents {get;set;}


    }
}

//_connectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";