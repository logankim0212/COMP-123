using System;
/*
 * Write an app which contains the following functions which make use of ref
 * and out parameters:
 * a)  private static void Swap(ref int, ref int) which exchanges the contents
 *     of two variables
 * b)  private static void Initialize(out int, out int) which initializes two
 *     numbers and then you need to find their average in Main() and print the
 *     result.
 */

namespace Exercise03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("|----------------------------|");
                Console.WriteLine(" 1. Swap 2 numbers");
                Console.WriteLine(" 2. Get Average of 2 numbers");
                Console.WriteLine(" 0. End program");
                Console.WriteLine("|----------------------------|");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the first number: ");
                        int a = int.Parse(Console.ReadLine()); 
                        Console.Write("Enter the second number: ");  
                        int b = int.Parse(Console.ReadLine()); 
                        Console.WriteLine("Value of first and second number before sawapping");  
                        Console.WriteLine("a = " + a);  
                        Console.WriteLine("b = " + b);   
                        Swap(ref a, ref b);  
                        Console.WriteLine("Value of first and second number after sawapping");  
                        Console.WriteLine("a = " + a);  
                        Console.WriteLine("b = " + b);  
                        break;
                    case "2":
                        Initialize(out a, out b);
                        double average = ((double)a + b) / 2;
                        Console.WriteLine("Average: {0:F}", average);
                        break;
                    case "0":
                        break;
                }
            } while (choice != "0");
        }
        private static void Swap(ref int number1, ref int number2)
        {
            int swapvalue;
            swapvalue = number1;
            number1 = number2;
            number2 = swapvalue;
        }
        private static void Initialize(out int a, out int b)
        {
            a = 10;
            b = 5;
        }
    }
}
