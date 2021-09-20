using System;
using System.Linq;
using EntityFrameworkExample.Entities;
using EntityFrameworkExample.DbContexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingContext context = new TrainingContext();
            /* Student student1 = new Student();
             student1.Name = "Tanvir Rahman ornob";
             student1.DateOfBirth = new DateTime(1993, 12, 23);
             student1.CGPA = 3.61;
             context.Students.Add(student1);
             context.SaveChanges();

             Course course = new Course();
             course.Title = "F#";
             course.Fees = 8000;
             course.Topics = new List<Topic>();
             course.Topics.Add(new Topic { Name = "Getting Started" });
             course.Topics.Add(new Topic { Name = "Intermidiate" });
             course.Topics.Add(new Topic { Name = "Professional" });
             course.Topics.Add(new Topic { Name = "Advance" });

             context.Courses.Add(course);
             context.SaveChanges();
             Console.WriteLine("Course Added");*/

          /*  var courses = context.Courses.ToList(); // all courses
            var coursesingle = context.Courses.Where(x => x.id == 3).FirstOrDefault();// this will bring only the course lazy loading

            //egar loading
            var courses_egar = context.Courses.Where(x => x.id == 3)
                .Include("Topics")
                .FirstOrDefault();
            var student = context.Students.FirstOrDefault(); // take the first
            Console.WriteLine(student.Name);

            courses_egar.CourseStudents = new List<CourseStudent>();
            courses_egar.CourseStudents.Add(new CourseStudent { Student = student });// you dont need to add course manually it will be autometically taken
            context.SaveChanges();*/
            // Console.WriteLine($"Course Name {courses_egar.Title}");
           /* foreach (var topic in courses_egar.Topics) {

                Console.WriteLine($"TOPIC NAME {topic.Name}");
            
            }*/

            var courses_many = context.Courses.Include(b => b.CourseStudents).ThenInclude(c => c.Student).Include(d => d.Topics).ToList();
            // take all the value that is going to need
            // it first take all the course then all the CourseStudents
            // in each Courses
            // then the student in that CourseStudent
            // then again the topics of all the courses
            Console.WriteLine("----------------------------------");
            foreach (var c in courses_many) {
                Console.WriteLine($"COURSES {c.Title}");
                foreach (var s in c.CourseStudents) {
                    Console.WriteLine($"Student Name {s.Student.Name}");
                }
            
            }
        }
    }
}
