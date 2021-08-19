using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = StringValue("Hello World");
            Console.WriteLine(result);
        }

        public static int StringValue(string aText)
        {
            var totalvalue = 0;
            foreach (char i in aText)
            {
                var value = (int)i;
                totalvalue += value;
            }
            return totalvalue;
        }
    }
}
