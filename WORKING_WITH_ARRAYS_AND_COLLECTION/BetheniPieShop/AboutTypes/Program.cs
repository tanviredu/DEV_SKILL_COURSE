using System;

namespace AboutTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingEnumuration();

            Console.ReadLine();
        }

        private static void UsingEnumuration()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;
            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType) {

            int calculatedwage = 0;
            if (employeeType == EmployeeType.Manager) {

                calculatedwage = baseWage * 3;
            }
            else
            {
                calculatedwage = baseWage * 2;
            }
            if (storeType == StoreType.FullPieResturant) {
                calculatedwage += 500;
                
            }
            Console.WriteLine($"The Calculated wage is {calculatedwage}");
        }
    }


    // by default indexing will happen
    enum EmployeeType
    {
        Sales,       // 0
        Manager,     //1
        Research,    //2
        StoreManager //3

    }

    // named values

    enum StoreType { 
    
        PieCorner = 10,
        Seating = 20,
        FullPieResturant = 100,
        undefined = 99

    }


}
