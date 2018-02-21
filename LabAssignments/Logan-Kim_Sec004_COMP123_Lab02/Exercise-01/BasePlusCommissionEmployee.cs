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
            // initialize the choice
            string choice;

            // loop for continuing the program (instead of creating two objects)
            do
            {
                // prompt user first name
                Console.Write("Enter your first name: ");
                string first = Console.ReadLine();

                // prompt user last name
                Console.Write("Enter your last name: ");
                string last = Console.ReadLine();

                // prompt user employee ID
                Console.Write("Enter your employee ID: ");
                string id = Console.ReadLine();

                // prompt user base salary
                Console.Write("Enter your base salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // prompt user gorss sales
                Console.Write("Enter your gross sales: ");
                double sales = Convert.ToDouble(Console.ReadLine());

                // prompt user commission rate
                Console.Write("Enter your commission rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());

                // call class BasePlusCommissionEmployee
                BasePlusCommissionEmployee employee1 = new BasePlusCommissionEmployee
                    (first, last, id, salary, sales, rate);

                // print employee1 via the class BasePlusCommissionEmployee
                Console.WriteLine(employee1);

                // print earnings from the class BasePlusCOmmissionEmployee
                Console.WriteLine("Earnings with Base Salary: {0:C}", employee1.earnings());

                // prompt if the user want to continue
                Console.Write("Enter 'y' (without quotation marks) if you want to continue: ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y"); // end loop
        } // end main
    } // end class
} // end namespace
