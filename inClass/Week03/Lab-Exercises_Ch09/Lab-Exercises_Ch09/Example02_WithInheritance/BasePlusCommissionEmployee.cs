using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02_WithInheritance
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        // only for BasePlusCommissionEmployee
        private double baseSalary;

        // Properties
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

        // Constructor
        public BasePlusCommissionEmployee(string firstName, string lastName,
                                  int socialSecurityNumber, double grossSales,
                                          double commissionRate, double baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        } // end constructor

        public BasePlusCommissionEmployee(string firstName, string lastName,
                                          int socialSecurityNumber) : this(firstName, lastName,
                                                                         socialSecurityNumber,
                                                                           0, 0, 0)
        { } // end constructor
        // Method definition
        public override double earnings()
        {
            return base.earnings() + baseSalary;
        } // end method

        public override string ToString()
        {
            return string.Format("{0} \nBase Salary: {1:C}", base.ToString(), BaseSalary);
        }
    } // end class
} // end namespace
