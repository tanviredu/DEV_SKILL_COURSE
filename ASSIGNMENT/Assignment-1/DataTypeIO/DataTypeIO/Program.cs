using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {

            /// variable declaration
            int i = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            string pattern = "MM/dd/yyyy";
            int[] intdata = new int[5];
            double[] doubledata = new double[5];
            float[] floatdata = new float[5];
            string[] stringdata = new string[5];
            DateTime[] datetimedata = new DateTime[5];
            long[] Longdata = new long[5];
            Decimal[] decimaldata = new Decimal[5];
            bool[] booldata = new bool[5];


            while (i < 5) {
                Console.WriteLine("Ënter  int data => ");
                intdata[i++] = int.Parse(Console.ReadLine());
                
                
            }

            for (int j = 0; j < 5; j++) {

                Console.Write(intdata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            
            while (k < 5)
            {
                Console.WriteLine("Ënter double data => ");
                doubledata[k++] =double.Parse(Console.ReadLine());


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(doubledata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (l < 5)
            {
                Console.WriteLine("Ënter float data => ");
                floatdata[l++] = float.Parse(Console.ReadLine());


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(floatdata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (m < 5)
            {
                Console.WriteLine("Ënter string  data => ");
                stringdata[m++] =Console.ReadLine();


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(stringdata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (n < 5)
            {
                // mm/dd/yyyy 
                Console.WriteLine("Ënter Datetime data (mm/dd/yyyy) => ");
                datetimedata[n++] = DateTime.ParseExact(Console.ReadLine(),pattern,null);


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(datetimedata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (o < 5)
            {
                // dd/mm/yyyy 
                Console.WriteLine("Ënter long data => ");
                Longdata[o++] = long.Parse(Console.ReadLine());


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(Longdata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (p < 5)
            {
                // dd/mm/yyyy 
                Console.WriteLine("Ënter Decimal data => ");
                decimaldata[p++] = decimal.Parse(Console.ReadLine());


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(decimaldata[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
            while (q < 5)
            {
                // dd/mm/yyyy 
                Console.WriteLine("Ënter bool data => ");
                booldata[q++] = bool.Parse(Console.ReadLine());


            }
            for (int j = 0; j < 5; j++)
            {

                Console.Write(booldata[j]);
            }




        }
    }
}
