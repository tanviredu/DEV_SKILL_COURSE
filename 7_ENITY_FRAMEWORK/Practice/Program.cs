using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Practice.DbContexts;
using Practice.Entities;


using System;

namespace Practice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //AddStudent();
            //GetAllTheStudent();
            //AddCourseWithTopics();
            //GetAllTheCourses();
            //ManytoMany1();
            //getFromManytoMany();
            

        }

        private static void AddStudent()
        {
            var _context = new TrainingContext();
            Student student = new Student();
            student.Name = "Tareq";
            student.CGPA = 3.2;
            student.DateOfBirth = new DateTime(2010, 12, 23);
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public static void GetAllTheStudent(){
            var _context = new TrainingContext();
            var students = _context.Students.ToList(); 
            foreach( var student in students){
                Console.WriteLine($"{student.Id} | {student.Name} | {student.CGPA} ");

            }
        }

        public static void GetAllTheCourses(){

            var _context = new TrainingContext();
            var courses = _context.Courses.ToList();
            foreach(var course in courses){
                Console.WriteLine(course.Title);

            }

        }

        public static void AddCourseWithTopics(){
            var _context = new TrainingContext();
            Course course = new Course();
            course.Title = "c#";
            course.Fees = 8000;
            course.Topics = new List<Topic>();
            course.Topics.Add(new Topic{Name="Getting Started"});
            course.Topics.Add(new Topic{Name="Intermidiate"});
            course.Topics.Add(new Topic{Name="Advanced"});
            course.Topics.Add(new Topic{Name="Professional"});
            _context.Courses.Add(course);
            _context.SaveChanges();

        }

        public static void ManytoMany1(){
            var _context = new TrainingContext();
            // fetch a course
            // with its Topic 
            // join query
            var course = _context.Courses.Where(x=>x.Id==1).Include(s=>s.Topics).FirstOrDefault();
            Console.WriteLine($"Course Name : {course.Title}");
            foreach(var t in course.Topics){
                Console.WriteLine($"COURSE TOPIC {t.Name}");
            }
            var student1 = _context.Students.Where(x=>x.Id==1).FirstOrDefault();
            Console.WriteLine($"Student Name : {student1.Name} ");

            // attach the student with the course
            course.CourseStudents = new List<CourseStudent>();
            course.CourseStudents.Add(new CourseStudent{Student = student1});
            // you dont need to add the course it will be provided autometically
            _context.SaveChanges();
            Console.WriteLine("Student Aded in course");


        }
        public static void getFromManytoMany(){
            var _context = new TrainingContext();
            // remember Courses has a relation with the CourseCtudent
            //so we first fetch the CourseStudent with Include
            // then this Student Table is related with the CourseStudent
            // so we ThenInclude the Student  because 
            // Theninclude er maddhome ami boltesi
            // Course Student er moddhe foreignkey ase student er 
            // setao join er maddhome ber kore ano
            // first Course join CourseStudent
            // then join CourseStudent with Student because courseStudent have a foreign Key
            // in of student
            // so course has CourseStudent List one to many
            // so courses.join(CourseStudent)
            // then from CourseStudent get the student 

            
            //easy
            var courses  = _context.Courses.Include(b=>b.CourseStudents)
            .ThenInclude(c=>c.Student)
            .Include(d=>d.Topics)
            .ToList();

            foreach(var c in courses){
                Console.WriteLine($"Course Title {c.Title}");
                Console.WriteLine("--------------------------");
                foreach(var s in c.CourseStudents){
                    // ekta course er under a CourseStudent er list thake
                    // ekta course nilam
                    // then set course er CourseStudent list take access kore
                    // sei Course student er student property ta nilam

                    Console.WriteLine($"STUDENT :{s.Student.Name}");
                }
            }

        }


      
    }
}
