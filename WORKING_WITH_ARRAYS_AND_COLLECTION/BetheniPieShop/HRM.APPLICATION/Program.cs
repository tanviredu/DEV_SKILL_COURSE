using System;
using System.Collections.Generic;
using HRM.APPLICATION.HR;
namespace HRM.APPLICATION
{
    class Program
    {
       public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************");
            Console.WriteLine("*******MY PIE SHOP HRM APP *******");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            string userSelection;
            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*******************************");
                Console.WriteLine("******* SELECT AN OPTION*******");
                Console.WriteLine("*******************************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1 : Register Employee");
                Console.WriteLine("2 : Register Work Hour For Employee");
                Console.WriteLine("3 : Pay Employee");
                Console.WriteLine("9 : Quit The Application");
                
                userSelection = Console.ReadLine();

                switch(userSelection){
                    case "1":RegisterEmployee();
                        break;
                    case "2": RegisterWork();
                        break;
                    case "3":PayEmployee();
                        break;
                    case "9": break;
                    default:
                    Console.WriteLine("INVALID SELECTION !!.TRY AGAIN");
                    break;

                    
                }


            }while(userSelection !="9");
            // loop will continue to run untill user press 9 
            Console.WriteLine("Thanks for using this application");
            Console.Read();
        }

        private static void PayEmployee()
        {
            Console.WriteLine("SELECT AN EMPLOYEE");
            for(int i=1;i<=employees.Count;i++){
                Console.WriteLine($"{i}. {employees[i-1].firstName} {employees[i-1].lastName}");
            }
                int selection = int.Parse(Console.ReadLine());
                Employee selectedEmployee = employees[selection-1];
                double recieveWage = selectedEmployee.RecieveWage();
                Console.WriteLine($"{selectedEmployee.firstName} {selectedEmployee.lastName} RECIEVED {recieveWage}");
            
        }

        private static void RegisterWork()
        {
            Console.WriteLine("SELECT AN EMPLOYEE");
            for (int i=1;i<=employees.Count;i++){
                Console.WriteLine($"{i}. {employees[i-1].firstName} {employees[i-1].lastName}");

            }

            int selection = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NUMBER OF HOURS WORKED : ");
            int hours = int.Parse(Console.ReadLine());
            Employee selectedEmployee = employees[selection-1];
            int numberOfHourWorked = selectedEmployee.PerformWork(hours);
            Console.WriteLine($"{selectedEmployee.firstName} {selectedEmployee.lastName} now worked {numberOfHourWorked}");


        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("CREATING AN EMPLOYEE");
            Console.WriteLine("ENTER YOUR FIRST NAME : ");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("ENTER YOUR LAST NAME : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("ENTER HOURLY RATE : ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            // create an Employee object
            Employee employee = new Employee(firstName,lastName,rate);
            employees.Add(employee);
            Console.WriteLine("Employee is created");

        }
    }
}
