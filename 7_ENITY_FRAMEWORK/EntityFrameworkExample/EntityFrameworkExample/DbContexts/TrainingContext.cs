using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using EntityFrameworkExample.Entities;
namespace EntityFrameworkExample.DbContexts
{

    // inherit from the base classs
    // which is provided in Microsodr.EntityFrameworkCore
    public class TrainingContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public TrainingContext()
        {
            // setting the connection string when the class in initiate
            _connectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";
            //_assemblyName = typeof(Program).Assembly.FullName; //optional


        }

        // this function signeture comes from the base class
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            // override the DBContextoptionsbuilder and edit the settings
            // then call the base 

            if (!dbContextOptionsBuilder.IsConfigured) {
                // configure it
                dbContextOptionsBuilder.UseSqlServer(_connectionString);
            }

            // if you change a part of the inherited class not everything
            // in this case the inside the Onconfiguring the dbContextoption builder only
            // then after the change you need to call the base class
            // rest of the class remain the same just change in the dbContextOptionBuilder

            base.OnConfiguring(dbContextOptionsBuilder); 
            
            
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            // for many to many it is must
            // for one to many one to one optional 
            builder.Entity<CourseStudent>().HasKey(cs => new { cs.CourseId, cs.StudentId });

            // optional if you follow convension
            // one to many relation
            builder.Entity<Course>().HasMany(p => p.Topics).WithOne(i => i.Course);
        }
        
        

        
    }
}


/* 
 
  you need to install the dotnet-ef tools 
  =>dotnet tool install --global dotnet-ef
    then you use this command in the package manager console
  =>dotnet ed migrations add <migration_name_anything> --context <dbContext you inherited> --project <project name>
  =>dotnet ef migrations add AddStudentTable --context TrainingContext --project EntityFrameworkExample
  =>dotnet ef database update --context TrainingContext --project EntityFrameworkExample
 
 */