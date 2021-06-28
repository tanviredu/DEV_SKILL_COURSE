using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Tanvirs GradeBook");
            book.AddGrade(100.00);
            book.AddGrade(60.00);
            book.AddGrade(100.00);
            book.AddGrade(100.00);
            book.ShowStatistics();
            

           
            
            

        }
    }
}
