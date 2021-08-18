using System;


namespace FINALPROJECT
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string firstName {get;set;}
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime birthDay { get; set; }


        public int numberofHourWorked { get; set; }
        public double wage { get; set; }
        public double HourlyRate { get; set; }
        public static double taxRate = 0.15;


        public Employee(int empId,string first,string last,string em,DateTime bd,double rate)
        {
            Id = empId;
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            HourlyRate = rate;


        }


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID : {Id} \nFirstName: {firstName}\nLastName: {lastName}\n Email : {email}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{firstName} {lastName} recieved a generic bonus of 100");
        }

        public void GiveComplement()
        {
            Console.WriteLine($"You have done a great job {firstName}");
        }

        public void PerformWork()
        {
            numberofHourWorked++;
            Console.WriteLine($"{firstName} {lastName} is now working");
        }

        public double RecieveWage()
        {
            double wagebeforetax = numberofHourWorked * HourlyRate;
            double taxAmmount = wagebeforetax * taxRate;
            wage = wagebeforetax - taxAmmount;
            Console.WriteLine($"The wage for {numberofHourWorked} hours working {wage}");
            return wage;
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} is stopped working");
        }
    }
}
