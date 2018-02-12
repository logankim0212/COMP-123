using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class CommissionEmployee
    {
        // instance data members
        private string firstName;
        private string lastName;
        private int socialSecurityNumber;
        private double grossSales;
        private double commissionRate = 0.1;
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
            this.firstName = firstName;
            this.lastName = lastName;
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
           return string.Format("First Name: {0} \nLast Name: {1} \nSocial Security Number: {2}" +
                "\nGross Sales: {3} \nCommission Rate: {4}", FirstName,
                LastName, SocialSecurityNumber, GrossSales,
                CommissionRate);
        }
    } // end class
} // end namespace
