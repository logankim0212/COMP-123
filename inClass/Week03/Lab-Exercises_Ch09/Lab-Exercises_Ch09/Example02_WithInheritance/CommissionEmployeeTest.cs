using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02_WithInheritance
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            // Creating an object
            CommissionEmployee employee1 = new CommissionEmployee("Sujeet", "Lohan",
                                                 123, 10000.00, 2.5);

            // Creating an object
            BasePlusCommissionEmployee employee2 = new BasePlusCommissionEmployee("Sujeet2", "Lohan2",
                                                 222, 22222, 2.2, 2222);

            // Creating an object
            BasePlusCommissionEmployee employee3 = new BasePlusCommissionEmployee("Sujeet3", "Lohan3",
                                                 333);
            
            // Printing the object data

            Console.WriteLine(employee2);
            Console.WriteLine(employee2.GetType());
            Console.WriteLine(employee2.GetHashCode());


            /*
            Console.WriteLine("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                "\nGross Sales: {3} \nCommission Rate: {4}", employee1.FirstName,
                employee1.LastName, employee1.SocialSecurityNumber, employee1.GrossSales,
                employee1.CommissionRate); */

            double salary = employee2.earnings();
            Console.WriteLine("Salary1: {0:C}", salary);
            BasePlusCommissionEmployee employee4;
            employee4 = employee2;

            // update the gross sales
            //employee2.GrossSales = -5000.00;
            //salary = employee2.earnings();
            //Console.WriteLine("Salary2: {0:C}", salary);
            /*
            Console.WriteLine("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                "\nGross Sales: {3} \nCommission Rate: {4}", employee1.FirstName,
                employee1.LastName, employee1.SocialSecurityNumber, employee1.GrossSales,
                employee1.CommissionRate);*/


            // update the commisson rate
            // employee1.CommissionRate = 2.5; // this is not in the range
            // salary = employee1.earnings();
            // Console.WriteLine("Salary: {0}", salary);
            //Console.WriteLine(employee1.ToString());
        }
    }
}
