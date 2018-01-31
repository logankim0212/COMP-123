using System;

namespace Example01
{
    class ParameterDemo1
    {
        public static void Main(string[] args)
        {
            int x = 4, y = 10, z = 12;
            Console.WriteLine("In Main x is {0}", x);
            DisplayValueParameter(x);
            x = 10;
            Console.WriteLine("In Main x is {0}", x);
            DisplayValueParameter(x);
            Console.WriteLine("In Main x is {0}", x);
            int sumResult = Sum(x, y);
            Console.WriteLine("Sum: {0}", sumResult);
            double averageResult = Average(x, y, z);
            Console.WriteLine("Average: {0:F}", averageResult);
        }
        static void DisplayValueParameter(int x)
        {
            x = 777;
            Console.WriteLine("In method, x is {0}", x);
            x = 10;
        }
        static int Sum(int x1, int x2)
        {
            int sum = x1 + x2;
            return sum;
        }
        static double Average(int x, int y, int z)
        {
            double average = ((double)x + y + z) / 3;
            return average;
        }
    }
}