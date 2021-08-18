using System;
namespace HRM.APPLICATION.HR
{
    public class Employee
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int numberOfHourWorked {get;set;}
        public double wage {get; set;}
        public double hourlyRate {get;set;}

        
        // constructor for Employee
        public Employee(string first,string last,double rate)
        {
            firstName = first;
            lastName = last;
            hourlyRate = rate;
            
        }

        public int PerformWork(int hours){
            numberOfHourWorked+=hours;
            return numberOfHourWorked;
        }

        public double RecieveWage(){
            wage = numberOfHourWorked*hourlyRate;
            Console.WriteLine($"The wage for {numberOfHourWorked} hours is {wage}");
            numberOfHourWorked = 0;
            return wage;
        }
      
    }
}
