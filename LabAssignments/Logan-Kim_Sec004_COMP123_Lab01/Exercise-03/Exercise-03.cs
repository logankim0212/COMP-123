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

            //loop for recalling menu
            do
            {
                //print menu
                Console.WriteLine("|----------------------------|");
                Console.WriteLine(" 1. Swap 2 numbers");
                Console.WriteLine(" 2. Get Average of 2 numbers");
                Console.WriteLine(" 0. End program");
                Console.WriteLine("|----------------------------|");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                //menu choices
                switch (choice)
                {
                    //calling swapping method
                    case "1":
                        //prompt user
                        Console.Write("Enter the first number: ");
                        int a = Convert.ToInt32(Console.ReadLine()); 
                        Console.Write("Enter the second number: ");  
                        int b = Convert.ToInt32(Console.ReadLine());

                        //Before swapping 2 numbers
                        Console.WriteLine("Value of first and second number before sawapping");  
                        Console.WriteLine("a = " + a);  
                        Console.WriteLine("b = " + b);

                        //After swapping 2 numbers
                        Swap(ref a, ref b);  
                        Console.WriteLine("Value of first and second number after sawapping");  
                        Console.WriteLine("a = " + a);  
                        Console.WriteLine("b = " + b); 

                        break;

                    //getting average
                    case "2":
                        //initialize number
                        Initialize(out a, out b);

                        //calculate average
                        double average = ((double)a + b) / 2;

                        //print 2 numbers that are initialized
                        Console.WriteLine("First number: {0}, Second number: {1}", a, b);

                        //print average
                        Console.WriteLine("Average: {0:F}", average);
                        break;
                    case "0":
                        break;
                }
                //end choices
            } while (choice != "0");
            //end loop
        }//end main()

        //method for swapping
        private static void Swap(ref int number1, ref int number2)
        {
            int swapvalue;
            swapvalue = number1;
            number1 = number2;
            number2 = swapvalue;
        }
        //end of swapping method

        //method for initializing 2 values
        private static void Initialize(out int a, out int b)
        {
            a = 10;
            b = 5;
        }
        //end of initializer
    }//end class
}//end namespace
