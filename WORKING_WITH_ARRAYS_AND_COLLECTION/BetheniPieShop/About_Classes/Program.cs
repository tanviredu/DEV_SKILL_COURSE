using System;

namespace About_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating an employee");
            Console.WriteLine("---------------------------------");
            Employee bethany = new Employee("bethany","smith","bethanysmith@gmail.com",new DateTime(1994,12,23),EmployeeType.Manager,25);
            
            // display employee Details
            bethany.DisplayEmployeeDetails();
            Console.WriteLine("---------------------");
            bethany.PerdformWork();
            bethany.PerdformWork();
            bethany.PerdformWork();
            bethany.PerdformWork();
            bethany.PerdformWork();
            bethany.PerdformWork();
            bethany.RecieveWage();

            Employee gorge = new Employee("gorge", "jones", "gorge@gmail.com", new DateTime(1994, 12, 24), EmployeeType.Research, 30);

            gorge.DisplayEmployeeDetails();
            Console.WriteLine("-------------------------------");
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.PerdformWork();
            gorge.RecieveWage();


            Console.ReadLine();
        }
    }
}
