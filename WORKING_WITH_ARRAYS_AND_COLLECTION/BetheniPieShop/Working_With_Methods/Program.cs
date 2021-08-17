using System;

namespace Working_With_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int monthlywage = 1234;
            int months = 12;
            int bonus = 1000;
            int yearly_wage1 = CalculateYearltWage(monthlywage, months);
            Console.WriteLine($"Yearly wage is {yearly_wage1}");
            var yearly_wage2 = CalculateYearltWage(monthlywage, months, bonus);
            Console.WriteLine($"Yeary wage with bonus{ yearly_wage2}");
            UsingParams();
            Console.ReadLine();
        }



        // method overloading




        // method for calcuating the yearly wage
        // it will return an integer

        public static int CalculateYearltWage(int monthlywage,int numberofmonths)
        {

            if (numberofmonths == 12) {

                int result = monthlywage * numberofmonths;
                return result;
            }
            else
            {
                return 0;
            }
            
            //var yearlywage = monthlywage * numberofmonths;

            // Console.WriteLine($"Yearly wage {yearlywage}");

        }

        public static double CalculateYearltWage(double monthlywage, double numberofmonths,double bonus) {

            double result = (monthlywage * numberofmonths) + bonus;
            return result;
        
        }

        private static void UsingParams()
        {
            int m1wage = 100;
            int m2wage = 200;
            int m3wage = 200;
            int m4wage = 500;

            double wagesAvg = CalculateaverageWage(m1wage, m2wage, m3wage, m4wage);
            Console.WriteLine($" AVG IS : {wagesAvg}");
        }



        // dynamic ammount of parameter 
        // using params

        private static double CalculateaverageWage(params double[] wages) {

            double total = 0;
            int numberofwages = wages.Length;
            for(int i = 0; i < wages.Length; i++)
            {
                total += wages[i];
            }

            return total/numberofwages;
        
        }
    }
}
