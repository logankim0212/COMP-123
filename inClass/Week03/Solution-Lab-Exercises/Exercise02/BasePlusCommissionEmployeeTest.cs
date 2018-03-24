using System;
/*
 * Create a driver class – BasePlusCommissionEmployeeTest
 * (BasePlusCommissionEmployeeTest.cs) which tests above class by at least
 * creating two objects of the BasePlusCommissionEmployee class.
 */
namespace Exercise02
{
    class BasePlusCommissionEmployeeTest
    {
        public static void Main(string[] args)
        {
            BasePlusCommissionEmployee employee1 = new BasePlusCommissionEmployee("Logan", "Kim",
                                                 123456789, 80000, 50000, 0.8);
            Console.WriteLine(employee1);
            Console.WriteLine("Earnings with Base Salary: {0:C}", employee1.earnings());
        }
    }
}
