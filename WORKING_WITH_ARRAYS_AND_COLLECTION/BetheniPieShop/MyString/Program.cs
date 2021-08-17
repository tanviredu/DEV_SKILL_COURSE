using System;
using System.Text;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = " Smith";
            string fullname = firstName + lastName;
            string noValueString = null;

            if (fullname.Contains("beth") || fullname.Contains("Beth")) {


                Console.WriteLine("Ït Is Bethany Smith");
            }




            var username = "BethanyS";
            var mystring = "HelloWorld";
            int l = mystring.Length; // return the length
            string upper = mystring.ToUpper();
            string lower = mystring.ToLower();
            bool b = mystring.Contains("hello");
            string s = mystring.Replace("e", "b");
            string sub = mystring.Substring(1, 3); // start at second and ends with the fourth
                                                    
            Console.WriteLine(sub);

            string escapedFilePath = @"C:\Documents\readme.txt";
            Console.WriteLine(escapedFilePath);
            
            
            var s1 = "learning c#";
            var s2 = " is awesome";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            string s4 = String.Concat(s1, s2);

            // string interpolation
            string employeeName = "Bethany";
            int age = 34;
            string greetingText = $"Hello {employeeName}, you are {age} years old";

            
            // generating the employeeid
            string empId = firstName.Trim().ToLower() + "-" + lastName.Trim().ToLower();
            // Trim will remove the space from before and after the string
            var length = empId.Length;
            Console.WriteLine(empId);


            string displayName = $"welcome \n{firstName}\t{lastName}";

            Console.WriteLine(displayName);



            // Comparing the string 

            string fname = "Bethany";
            bool b1 = fname == "Bethany";  //return true
            bool b2 = fname == "bethany";   // return false
            bool b3 = firstName.Equals("Bethany"); // return true


            // make a case insensetive approach

            // make the first and second string 
            // to the uppercase than 
            // compare between them


            bool b4 = fname.ToUpper().Equals("bethany".ToUpper()); // return true


            // remember everytime you worked with the 
            // string a new string will be created
            // the main one will not change
            // because string are immutable
            // working with the String Builder

            StringBuilder builder = new StringBuilder(); // create a new String builder instance
            builder.Append("Last Name : ");
            builder.AppendLine(lastName);  // this will add a newline after the lastname
            builder.Append("First Name : ");
            builder.Append(firstName);
            string result = builder.ToString();

            Console.WriteLine(result);



            // Parsing the string
            //Console.WriteLine("Enter the wage \n =>");
            //var wage = Console.ReadLine(); // take the input
            //var wagevalue = int.Parse(wage); // parsing the value from the string
            //Console.WriteLine($"The Wage is {wagevalue}");


            // using TryParse
            Console.WriteLine("Enter The Wage: ");
            string wage = Console.ReadLine();
            int wagevalue;
            if (int.TryParse(wage, out wagevalue)) {
                Console.WriteLine($"Parsing Success : {wagevalue}");

            }
            else
            {
                Console.WriteLine($"Parsing Failed");
            }


            // DateTime Parse in c#
            string hiredateString = "12/23/2021"; //month-date-year
            DateTime hireDate = DateTime.Parse(hiredateString);
            Console.WriteLine(hireDate);


            
            Console.ReadLine();
        }
    }
}
