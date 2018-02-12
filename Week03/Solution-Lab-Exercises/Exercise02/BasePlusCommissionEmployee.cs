using System;
/*
 * Create a BasePlusCommissionEmployee class (BasePlusCommissionEmployee.cs)
 * that has the following instance variables:
 *      - First name , last name , social security number, base salary, gross
 *        sales ( amount in dollars) and commission rate
 *      - Define properties with validations for all the above.
 *      - Social Security number should only have getter method.
 *      - Gross sales and base salary cannot be negative and commission rate
 *        should be between 0.1 and 1.0%
 *      - Class should have defined two overloaded constructors:
 *             o One for initializing all the instance data members
 *             o Second for initializing first name, last name and social
 *               security number only.
 *      - Define a public method double earnings() which calculates employee’s
 *        commission ( commission rate * gross sales + base salary )
 *      - Define a public method – String toString() which is used to display
 *        the object’s data
 */
namespace Exercise02
{
    public class BasePlusCommissionEmployee
    {
        private double grossSales;
        private double commissionRate;
        private double baseSalary;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialSecurityNumber { get; }
        public double BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                if (value > 0.0)
                    baseSalary = value;
            }
        } // end property

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
                if (value > 0.1 && value <= 1.0)
                    commissionRate = value;
            }
        } // end property

        public BasePlusCommissionEmployee(string firstName, string lastName,
                                  int socialSecurityNumber, double basesalary, double grossSales,
                                   double commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            BaseSalary = basesalary;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        } // end constructor

        public BasePlusCommissionEmployee(string firstName, string lastName,
                                  int socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        } // end constructor

        public double earnings()
        {
            return GrossSales * CommissionRate / 100 + BaseSalary;
        } // end method

        public override string ToString()
        {
            return string.Format("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2} " +
                                 "\nBase Salary: {3} \nGross Sales: {4} \nCommission Rate: {5}", FirstName,
                                 LastName, SocialSecurityNumber, BaseSalary, GrossSales,
                                 CommissionRate);
        }
    }
}
