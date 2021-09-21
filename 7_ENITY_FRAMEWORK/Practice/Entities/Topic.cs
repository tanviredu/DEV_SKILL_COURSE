namespace Practice.Entities
{
    public class Topic{
        public int Id {get;set;}
        public string Name {get;set;}
        public Course Course {get;set;}
        public int CourseId {get;set;}
    }
}

//_connectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";