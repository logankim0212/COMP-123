using System;
/*
 * Write an app which contains the following two overloaded functions:
 * a)  private static int Maximum(int, int) which returns the largest of two numbers
 * b)  private static int Maximum(int, int, int) which returns the largest of three numbers
 */
namespace Exercise01
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
                Console.WriteLine("***Hit 0 to end program***");
                //prompt for choices
                Console.Write("How many number do you want to compare (2 or 3): ");
                choice = Console.ReadLine();
                int first, second, third;

                //menu choices
                switch (choice)
                {
                    //calling method for find maximum of 2
                    case "2":
                        //prompt for 2 numbers
                        Console.Write("First Number = ");
                        first = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Second Number = ");
                        second = Convert.ToInt32(Console.ReadLine());

                        //print largest of two
                        Console.WriteLine("Largest of two: " + Maximum(first, second));
                        break;

                        //calling method for find maximum of 3
                    case "3":
                        //prompt for 3 numbers
                        Console.Write("First Number = ");
                        first = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Second Number = ");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Third Number = ");
                        third = Convert.ToInt32(Console.ReadLine());

                        //print largest of three
                        Console.WriteLine("Largest of three: " + Maximum(first, second, third));
                        break;
                    default:
                        break;
                }
            } while (choice != "0");
        }
        //method for find maximum of 2
        private static int Maximum(int x, int y)
        {
            return Math.Max(x, y);
        }//end method

        //method for find maximum of 3
        private static int Maximum(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }//end method
    }//end class
}//end namespace
