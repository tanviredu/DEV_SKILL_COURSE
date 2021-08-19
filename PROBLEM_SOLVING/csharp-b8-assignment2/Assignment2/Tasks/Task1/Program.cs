using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = IsPrime(19);
            Console.WriteLine(result);
        }

        public static bool IsPrime(int number)
        {
            //Task 1
            if (number <= 1)
                return false;
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;

        }
    }
}
