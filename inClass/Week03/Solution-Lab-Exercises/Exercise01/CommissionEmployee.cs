/*
 * Create a CommissionEmployee class (CommissionEmployee.cs) that has the
 * following instance variables:
 *      - First name , last name , social security number, gross sales
 *        (amount in dollars) and commission rate
 *      - Define properties with validations (e.g. gross sales and commission
 *        rate should be positive) for all the above.
 *      - Social Security number should only have getter method.
 *      - Gross sales cannot be negative and commission rate should be between
 *        0.1 and 2%
 *      - Class should have defined two overloaded constructors:
 *           o One for initializing all the instance data members
 *           o Second for initializing only first name, last name and social
 *             security number.
 *      - Define a public method double earnings() which calculates employee’s
 *        commission ( commission rate gross sales )
 *      - Define a public method – String toString() which is used to display
 *        the object’s data
 */
using System;

namespace Exercise01
{
    public class CommissionEmployee
    {
        // instance data members
        //private string firstName;
        //private string lastName;
        private int socialSecurityNumber;
        private double grossSales;
        private double commissionRate = 0.1;

        // Auto Implemented Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FirstName
        //{
        //    get
        //    {
        //        return firstName;
        //    } // end get
        //    set
        //    {
        //        firstName = value;
        //    }
        //} // end property

        //public string LastName
        //{
        //    get
        //    {
        //        return lastName;
        //    } // end get
        //    set
        //    {
        //        lastName = value;
        //    }
        //} // end property

        public int SocialSecurityNumber // read-only property
        {
            get
            {
                return socialSecurityNumber;
            } // end get
        } // end property

        // Properties
        public double GrossSales
        {
            get
            {
                return grossSales;
            } // end get
            set
            {
                if (value > 0.0)
                    grossSales = value;
            }
        } // end property

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                if (value > 0.1 && value <= 2.0)
                    commissionRate = value;
            }
        } // end property

        // Constructor
        public CommissionEmployee(string firstName, string lastName,
                                  int socialSecurityNumber, double grossSales,
                                   double commissionRate)
        {
            //this.firstName = firstName;
            FirstName = firstName;
            //this.lastName = lastName;
            LastName = lastName;

            this.socialSecurityNumber = socialSecurityNumber;
            //this.grossSales = grossSales;
            GrossSales = grossSales;

            //this.commissionRate = commissionRate;
            CommissionRate = commissionRate;
        } // end constructor

        public CommissionEmployee(string firstName, string lastName,
                                  int socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
        } // end constructor

        // Method definition
        public double earnings()
        {
            //return (grossSales * commissionRate)/100;
            return (GrossSales * CommissionRate) / 100;
        } // end method

        public override string ToString()
        {
            return string.Format("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2} " +
                                 "\nGross Sales: {3} \nCommission Rate: {4}", FirstName, 
                                 LastName, SocialSecurityNumber, GrossSales,
                                 CommissionRate);
        }

        ~CommissionEmployee() //destructor definition
        {
            Console.WriteLine("Destructor executed");
        }
    }// end class
}// end namespace
