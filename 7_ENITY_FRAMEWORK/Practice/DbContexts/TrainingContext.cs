using System;
using Microsoft.EntityFrameworkCore;
using Practice.Entities;
using Practice.ConnectionString;
namespace Practice.DbContexts{

    public class TrainingContext:DbContext{

            private readonly string _connectionString;
            public TrainingContext()
            {   
                _connectionString = ConnectionStringReader.ConnectionString; 
                
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

                optionsBuilder.UseSqlServer(_connectionString);
                base.OnConfiguring(optionsBuilder);
            }


            // fluent api for many to many relation

            protected override void OnModelCreating(ModelBuilder builder){

                builder.Entity<CourseStudent>().HasKey(cs=>new {cs.StudentId,cs.CourseId});
                base.OnModelCreating(builder);
            }




            public DbSet<Student>Students {get;set;}
            public DbSet<Course> Courses {get;set;}


    }
}