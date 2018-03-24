using System;

// Logan Kim: 300973239

namespace LoganKim_Exercise01
{
    public abstract class Mortgage
    {
        // instance data members
        private readonly int mortgageNumber;
        private double mortgageAmount;
        private double yearlyInterestRate;
        private string customerAddress;
        private string customerName;

        // Properties
        public int MortgageNumber
        {
            get
            {
                return mortgageNumber;
            } // end get
        } // end property

        // Properties
        public double MortgageAmount
        {
            get
            {
                return mortgageAmount;
            } // end get
            set
            {
                if (value > 0)
                {
                    mortgageAmount = value;
                }
                else
                {
                    Console.WriteLine("Mortgage amount should be positive.");
                }
            }// end set
        } // end property

        // Properties
        public double YearlyInterestRate
        {
            get
            {
                return yearlyInterestRate;
            } // end get
            set
            {
                if (value > 0 && value <= 5.0)
                {
                    yearlyInterestRate = value;
                }
                else
                {
                    Console.WriteLine("Yearly interest rate should be greater " +
                                      "than 0 and should not be more than 5.");
                }
            } // end set
        } // end property

        // Properties
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            } // end get
            set
            {
                customerAddress = value;
            } // end set
        } // end property

        // Properties
        public string CustomerName
        {
            get
            {
                return customerName;
            } // end get
            set
            {
                customerName = value;
            }  // end set
        } // end property

        // Constructor
        public Mortgage(int mortgageNumber, string customerName, double mortgageAmount,
                        double yearlyInterestRate, string customerAddress)
        {
            this.mortgageNumber = mortgageNumber;
            MortgageAmount = mortgageAmount;
            YearlyInterestRate = yearlyInterestRate;
            CustomerAddress = customerAddress;
            CustomerName = customerName;
        } // end constructor

        // Constructor
        public Mortgage(int mortgageNumber, string customerName, string customerAddress)
            : this(mortgageNumber, customerName, 0, 0, customerAddress)
        { }// end constructor

        // Abstract Method
        public abstract double CalculateMonthlyMortgageInstallment();

        public override string ToString()
        {
            return string.Format("Mortgage Number: {0} \nCustomer Name: {1} " +
                                 "\nMortgage Amount: {2:C} \nYearly Interest " +
                                 "Rate: {3:F}% \nCustomer Address: {4}",
                                 mortgageNumber, CustomerName, MortgageAmount,
                                 YearlyInterestRate, CustomerAddress);
        }
    } // end class
} // end namespace
