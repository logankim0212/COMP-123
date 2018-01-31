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
            Console.Write("How many number do you want to compare (2 or 3): ");
            string choice = Console.ReadLine();
            int first, second, third;
            switch(choice)
            {
                case "2":
                    Console.Write("First Number = ");
                    first = int.Parse(Console.ReadLine());
                    Console.Write("Second Number = ");
                    second = int.Parse(Console.ReadLine());
                    Console.WriteLine("Largest of two: " + Maximum(first, second));
                    break;
                case "3":
                    Console.Write("First Number = ");
                    first = int.Parse(Console.ReadLine());
                    Console.Write("Second Number = ");
                    second = int.Parse(Console.ReadLine());
                    Console.Write("Third Number = ");
                    third = int.Parse(Console.ReadLine());
                    Console.WriteLine("Largest of three: " + Maximum(first, second, third));
                    break;
                default:
                    break;
            }
        }
        public static int Maximum(int x, int y)
        {
            return Math.Max(x, y);
        }

        public static int Maximum(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }
    }
}
