using System;

// Logan Kim: 300973239

namespace LoganKim_Exercise01
{
    class HouseMortgage : Mortgage
    {
        // instance data members
        private double propertyTax;
        private double infrastructureTax = 100;

        // Properties
        public double PropertyTax
        {
            get
            {
                return propertyTax;
            } // end get
            set
            {
                if (value > 0)
                {
                    propertyTax = value;
                }
                else
                {
                    Console.WriteLine("Property tax should be positive.");
                }
            } // end set
        } // end property

        // Properties
        public double InfrastructureTax
        {
            get
            {
                return infrastructureTax;
            } // end get
        } // end property

        // Constructor
        public HouseMortgage(int mortgageNumber, string customerName,
                             double mortgageAmount, double yearlyInterestRate,
                             string customerAddress, double propertyTax)
            : base (mortgageNumber, customerName, mortgageAmount,
                    yearlyInterestRate, customerAddress)
        {
            PropertyTax = propertyTax;
        } // end constructor

        // Method definition
        public override double CalculateMonthlyMortgageInstallment()
        {
            return MortgageAmount * ( YearlyInterestRate / 100 ) / 12 + PropertyTax + InfrastructureTax;
        } // end method

        public override string ToString()
        {
            return string.Format("{0} \nProperty Tax: {1:C} \nInfrastructure Tax: {2:C}", base.ToString(), PropertyTax, InfrastructureTax);
        }
    } // end class
} // end namespace
