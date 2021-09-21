using System;
using System.Collections.Generic;

namespace Practice.Entities
{

    public class Student{

        public int Id {get;set;}
        public string Name {get;set;}
        public DateTime DateOfBirth {get;set;}
        public double CGPA {get;set;}
        public List<CourseStudent>StudentCourses {get;set;}

    }
}

//_connectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";