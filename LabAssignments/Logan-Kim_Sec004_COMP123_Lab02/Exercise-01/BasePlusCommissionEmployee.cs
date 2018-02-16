using System;
/*
 * Create a test class - BasePlusCommissionEmployeeTest
 * (BasePlusCommissionEmployeeTest.cs) which tests above class by at least
 * creating two objects of the BasePlusCommissionEmployee class.
 */
namespace Exercise01
{
    class BasePlusCommissionEmployeeTest
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.Write("Enter your first name: ");
                string first = Console.ReadLine();
                Console.Write("Enter your last name: ");
                string last = Console.ReadLine();
                Console.Write("Enter your employee ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter your base salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your gross sales: ");
                double sales = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your commission rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());
                BasePlusCommissionEmployee employee1 = new BasePlusCommissionEmployee
                    (first, last, id, salary, sales, rate);
                Console.WriteLine(employee1);
                Console.WriteLine("Earnings with Base Salary: {0:C}", employee1.earnings());
                Console.Write("Hit 'y' if you want to continue?: ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

        }
    }
}
