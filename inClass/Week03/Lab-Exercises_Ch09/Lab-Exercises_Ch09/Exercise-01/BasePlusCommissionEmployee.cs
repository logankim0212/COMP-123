using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class BasePlusCommissionEmployee
    {
        // instance data members
        private string firstName;
        private string lastName;
        private int socialSecurityNumber;
        private double grossSales;
        private double commissionRate = 0.1;

        // only for baseplus class
        private double baseSalary;

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            } // end get
            set
            {
                firstName = value;
            }
        } // end property

        public string LastName
        {
            get
            {
                return lastName;
            } // end get
            set
            {
                lastName = value;
            }
        } // end property

        public int SocialSecurityNumber // read-only property
        {
            get
            {
                return socialSecurityNumber;
            } // end get
        }

        // Properties
        public double GrossSales
        {
            get
            {
                return grossSales;
            } // end get
            set
            {
                if(value > 0.0)
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
                if (value > 0.1 && value <=2.0)
                    commissionRate = value;
            }
        } // end property

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

            BaseSalary = baseSalary;
        } // end constructor

        public BasePlusCommissionEmployee(string firstName, string lastName,
                                          int socialSecurityNumber) : this(firstName, lastName,
                                                                         socialSecurityNumber,
                                                                           0, 0, 0)
        {
            //this.firstName = firstName;
            //this.lastName = lastName;
            //this.socialSecurityNumber = socialSecurityNumber;

        } // end constructor
        // Method definition
        public double earnings()
        {
            //return (grossSales * commissionRate)/100;
            return (GrossSales * CommissionRate) / 100;
        } // end method

        public override string ToString()
        {
           return string.Format("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                                "\nGross Sales: {3:C} \nCommission Rate: {4}" +
                                "\nBase Salary: {5:C}", FirstName, LastName,
                                SocialSecurityNumber, GrossSales, CommissionRate, BaseSalary);
        }
    } // end class
} // end namespace
