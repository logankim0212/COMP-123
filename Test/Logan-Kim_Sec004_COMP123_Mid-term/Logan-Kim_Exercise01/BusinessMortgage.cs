using System;

// Logan Kim: 300973239

namespace LoganKim_Exercise01
{
    class BusinessMortgage : Mortgage
    {
        // instance data member
        private double businessInsuranceAmount;

        // Properties
        public double BusinessInsuranceAmount
        {
            get
            {
                return businessInsuranceAmount;
            } // end get
            set
            {
                if (value > 0)
                {
                    businessInsuranceAmount = value;
                }
                else
                {
                    Console.WriteLine("Business insurance amount should be positive.");
                }
            } // end set
        } // end property

        // Constructor
        public BusinessMortgage(int mortgageNumber, string customerName,
                             double mortgageAmount, double yearlyInterestRate,
                             string customerAddress, double businessInsuranceAmount)
            : base(mortgageNumber, customerName, mortgageAmount,
                    yearlyInterestRate, customerAddress)
        {
            BusinessInsuranceAmount = businessInsuranceAmount;
        } // end constructor

        // Method definition
        public override double CalculateMonthlyMortgageInstallment()
        {
            return MortgageAmount * ( YearlyInterestRate / 100 ) / 12 + BusinessInsuranceAmount;
        } // end method

        public override string ToString()
        {
            return string.Format("{0} \nBusiness Insurance Amount: {1:C}",
                                 base.ToString(), BusinessInsuranceAmount);
        }
    } // end class
} // end namespace
