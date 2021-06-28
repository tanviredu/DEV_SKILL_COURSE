using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;
        
        public Book(string name)
        {
               grades = new List<double>();
               this.name = name;
        }
        
        public void AddGrade(double grade){
            // implementation 
            grades.Add(grade);
        }

        public void ShowStatistics(){
            var result = 0.00;
            var highGrade = double.MinValue;
            var lowgrade  = double.MaxValue;

            foreach (var number in this.grades)
            {
                lowgrade = Math.Min(number,lowgrade);
                highGrade = Math.Max(number,highGrade);
                result +=number;
                
            }

            result = result/this.grades.Count;
            Console.WriteLine($"THE AVERAGE IS {result}");
            Console.WriteLine($"THE HIGHEST IS {highGrade}");
            Console.WriteLine($"THE LOWEST IS {lowgrade}");

        }
        
    }
}
