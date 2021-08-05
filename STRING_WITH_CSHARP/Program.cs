using System;

namespace STRING_WITH_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "  Mirpur,  Dhaka,Bangladesh";
            // address.Contains
            Console.WriteLine($"Contains commna {address.Contains(",")}"); // return boolean
            Console.WriteLine($"Contains Ban {address.Contains("Ban")}");
            Console.WriteLine($"TO UPPER {address.ToUpper()}");
            Console.WriteLine($"to lower {address.ToLower()}");
            Console.WriteLine("Address starts With {address.StartsWith('d')}");
            Console.WriteLine(address.StartsWith("Dhak"));
            Console.WriteLine(address.EndsWith("esh"));
            Console.WriteLine(address.IndexOf(",")); // return the position index
            Console.WriteLine("index of any ");
            Console.WriteLine(address.IndexOfAny(new char[] {',','.',';'}));
            Console.WriteLine(address.IndexOfAny(new char[]{',','.',';'},7,10)); 
            // start with 7 and search the next 10 character
            // will give multiple option 
            // and any thing match the index will
            // immedietly return
            Console.WriteLine(address.LastIndexOf(','));
            // find the index of the last comma
            Console.WriteLine(address.LastIndexOfAny(new char[]{',','.',';'}));
            // find the index of the character in the character list

            //padding
            var address1 = address.PadLeft(50); // how many total padding you want
            Console.WriteLine(address1);
            var address2 = address.PadRight(50,'a'); // which character you want for padding
            // padding with a character
            Console.WriteLine(address2);
            Console.WriteLine(address.Trim()); 
            // remove space from the beginning and the top
            var startswithindex=0;
            var nextcount = 5;
            Console.WriteLine(address.Remove(startswithindex,nextcount));
            Console.WriteLine(address.Replace("Dhaka","Chittagong"));
            //split the string based on a character
            Console.WriteLine("--------------------");
            string[] parts = address.Split(",");

            foreach(var part in parts){
                Console.Write($"{part},");
            }
            Console.WriteLine("-------------------");
            foreach (var part in parts)
            {
                Console.WriteLine(part.TrimStart());
                // trim with the start    
            }
            var start = 10;
            var nextCount = 10;
            // 10 theke suru next 10 theke sesh
            Console.WriteLine(address.Substring(start,nextCount));
            char[] chararray = address.ToCharArray();
            // foreach(var ch in chararray){
            //     Console.WriteLine(ch);
            // }

            
            
            
            // static method work with 
            // direct class
            Console.WriteLine(string.Concat("hello ","world"));

            var text1 = string.Empty;
            

            // you cant assign  null in var
            string text2 = null;
            var text4 = "   ";
            Console.WriteLine(string.IsNullOrEmpty(text1));
            Console.WriteLine(string.IsNullOrEmpty(text2));
            Console.WriteLine(string.IsNullOrWhiteSpace(text4));


            /* Character function */

            Console.WriteLine(char.ToUpper('c'));
            Console.WriteLine(char.ToLower('D'));
            Console.WriteLine(char.IsDigit('8'));
            Console.WriteLine(char.IsNumber("9"));


        }
    }
}
