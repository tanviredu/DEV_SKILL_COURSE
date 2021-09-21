namespace Practice.Entities
{
    public class CourseStudent{
        public int CourseId {get;set;}
        public Course Course {get;set;}
        public int StudentId {get;set;}
        public Student Student {get;set;}

    }
}

//_connectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";