using System;

namespace About_Classes
{
    public class Employee
    {
        public Employee(string first,string last,string em,DateTime bd,EmployeeType empType,double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            employeeType = empType;
            hourlyRate = rate;

        }


        // constructor overloading
        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType) : this(first,
            last, em, bd, empType, 0)
        { 
        
        
        }

        public string firstName { get; }
        public string lastName { get; }
        public string email { get; }
        public int numbersOfHoursWorked { get; private set; }
        public double wage { get; private set; }
        public double hourlyRate { get;  }
        public DateTime birthDay { get;  }
        public EmployeeType employeeType { get; }

        public void PerdformWork()
        {
            numbersOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} is working");

        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working");
        }

        public double RecieveWage()
        {
            wage = numbersOfHoursWorked * hourlyRate;
            Console.WriteLine($"The wage for {numbersOfHoursWorked} hours of work is {wage}");
            numbersOfHoursWorked = 0;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\n firstname :{firstName}\n lastname : {lastName} \n Email : {email}\n birthday : {birthDay} Employee : {employeeType}");
        }

        
    }
}
