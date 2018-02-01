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
            //initialize 3 numbers and print the sum
            Console.WriteLine("The sum of 3 numbers: {0}", Addition(1, 2, 3));

            //initialize 4 numbers and print the sum
            Console.WriteLine("The sum of 4 numbers: {0}", Addition(1, 2, 3, 4));

            //initialize 5 numbers and print the sum
            Console.WriteLine("The sum of 5 numbers: {0}", Addition(1, 2, 3, 4, 5));
        }//end main()

        //method for addition
        private static int Addition(params int[] numbers)
        {
            int sum = 0;

            //loop for keep adding numbers in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }//end addition method
    }//end class
}//end namespace
