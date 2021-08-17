using System;

namespace BetheniPieShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int monthlyWage = 1234;
            int months = 12;
            int bonus = 1000;
            bool isActive = true;
            double rating = 99.25;
            //byte numberOfEmployees = 300; // byte can hold value 0-255
            double ratePerHour = 12.34;
            int numberOfHourWorked = 165;
            long verylongmonth = numberOfHourWorked;
            double d = 123456789.0;
            int x = (int)d;
            ratePerHour += 3;
            int intverylongmonth = (int) verylongmonth;
            double currentMonthWage = (ratePerHour * numberOfHourWorked)+bonus;

            if(currentMonthWage > 2000)
            {
                Console.WriteLine("Top Paid employee");
            }
            int numberOfEmployees = 15;
            numberOfEmployees--;
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;


            Console.WriteLine(intMaxValue);
            Console.WriteLine(intMinValue);

            char mychar = 'a';
            // make this uppercase
            char upperversion = char.ToUpper(mychar);
            char lowerversion = char.ToLower(mychar);
            bool isWhiteSpace = char.IsWhiteSpace(mychar);
            bool isDigit = char.IsDigit(mychar);
            bool isPuntuation = char.IsPunctuation(mychar);

            // working with Dates
            // DateTime is a value type


            DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);
            Console.WriteLine(hireDate);

            DateTime startDate = hireDate.AddDays(15);


            DateTime exitDate = new DateTime(2021, 12, 11);
            Console.WriteLine(exitDate);

            DateTime startHour = DateTime.Now;

            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);



            // format the output
            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToShortTimeString());







            Console.ReadLine();
        }
    }
}
