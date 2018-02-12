using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            // Creating an object
            CommissionEmployee employee1 = new CommissionEmployee("Sujeet", "Lohan",
                                                 123, 10000.00, 2.5);


            // Printing the object data

            Console.WriteLine(employee1.ToString());
            /*
           Console.WriteLine("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                "\nGross Sales: {3} \nCommission Rate: {4}", employee1.FirstName,
                employee1.LastName, employee1.SocialSecurityNumber, employee1.GrossSales,
                employee1.CommissionRate); */

            double salary = employee1.earnings();
            Console.WriteLine("Salary: {0}", salary);

            // update the gross sales
           employee1.GrossSales = -5000.00;
           salary = employee1.earnings();
            Console.WriteLine("Salary: {0}", salary);
            /*
            Console.WriteLine("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                "\nGross Sales: {3} \nCommission Rate: {4}", employee1.FirstName,
                employee1.LastName, employee1.SocialSecurityNumber, employee1.GrossSales,
                employee1.CommissionRate);*/


            // update the commisson rate
            // employee1.CommissionRate = 2.5; // this is not in the range
            // salary = employee1.earnings();
            // Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine(employee1.ToString());
        }
    }
}
