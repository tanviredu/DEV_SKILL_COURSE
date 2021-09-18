using System;

namespace OOP.ADO.NET.EXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new ADO_OOP();
            Console.WriteLine("===============================");
            database.READ("SELECT * FROM Students");
            Console.WriteLine("===============================");
            database.CREATE("INSERT INTO Students(Name,DateOfBirth,CGPA) VALUES ('Hasan','2010-2-20',3.62)");
            Console.WriteLine("===============================");
            database.READ("SELECT * FROM Students");
            Console.WriteLine("===============================");
            database.DELETE("DELETE FROM Students WHERE Name='Hasan'");
            Console.WriteLine("===============================");
            database.READ("SELECT * FROM Students");
            Console.WriteLine("===============================");

        }
    }
}
