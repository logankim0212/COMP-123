using System;
/*
 * Create a test class – CommissionEmployeeTest (CommissionEmployeeTest.cs)
 * which tests above class by at least creating two objects of the
 * CommissionEmployee class.
 */
namespace Exercise01
{
    class CommissionEmployeeTest
    {
        public static void Main(string[] args)
        {
            // Creating an object
            CommissionEmployee employee1 = new CommissionEmployee("Sujeet", "Lohan",
                                                 123456789, 10000.00, 2.5);
            CommissionEmployee employee2 = new CommissionEmployee("Sujeet2", "Lohan2",
                                                 123456789, 50000.00, 1);
            Console.WriteLine(employee1.ToString());
            employee1.GrossSales = 45000;
            employee1.CommissionRate = 1.2;
            Console.WriteLine(employee1);
        }
    }
}
