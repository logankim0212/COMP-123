using System;
/*
 * Write an app which contains the following function which makes use of 
 * variable number of arguments by use of params keyword:
 * a)  private static int Addition(params int[] numbers) which returns the sum 
 * of three different numbers , four different numbers and five different
 * numbers. So you need to call this method in the Main() according to above
 * requirements.
 */

namespace Exercise02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The sum of 3 numbers: {0}", Addition(1, 2, 3));
            Console.WriteLine("The sum of 4 numbers: {0}", Addition(1, 2, 3, 4));
            Console.WriteLine("The sum of 5 numbers: {0}", Addition(1, 2, 3, 4, 5));
        }
        private static int Addition(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
