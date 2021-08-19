using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryToDecimal("11110101010101010101011");
            Console.WriteLine(result);
        }

        public static int BinaryToDecimal(string n)
        {
            String num = n;
            int dec_value = 0;


            int base1 = 1;

            int len = num.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                if (num[i] == '1')
                    dec_value += base1;
                base1 = base1 * 2;
            }

            return dec_value;

        }
    }
}
