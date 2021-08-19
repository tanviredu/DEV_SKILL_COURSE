using System;
using System.Linq;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = CountVowels("Hellow World");
            Console.WriteLine(result);
        }

        public static bool isVowel(char ch)
        {
            ch = char.ToUpper(ch);
            return (ch == 'A' || ch == 'a' || ch == 'E' || ch == 'e'||
                    ch == 'I' || ch == 'i' || ch == 'O' || ch == 'o' ||
                                  ch == 'U' || ch == 'u');
        }




        public static int CountVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {


                if (isVowel(str[i]))
                {
                    ++count;
                }
            }
            return count;

        }
    }
}
