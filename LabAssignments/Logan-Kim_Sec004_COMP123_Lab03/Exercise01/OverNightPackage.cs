using System;
namespace Exercise01
{
    class OverNightPackage : Package
    {
        // instant variable
        private const double expressChargesValue = 0.10;
        private double expressChargeRate;

        // properties
        public double ExpressChargeRate
        {
            get
            {
                return expressChargeRate;
            } // end get
            set
            {
                // validation
                if (expressChargeRate >= 0)
                {
                    expressChargeRate = value;
                }
                else
                {
                    Console.WriteLine("Express charges should not be negative.");
                }
            } // end set
        } // end ExpressChargeRate

        // constructors
        public OverNightPackage(string packageId, string senderName, string senderAddress,
                int packageWeight, double ratePerGram)
            : base(packageId, senderName, senderAddress, packageWeight, ratePerGram)
        {
            ExpressChargeRate = RatePerGram + expressChargesValue;
        } // end constructors

        // method for calculating package cost
        public override double CalculatePackageCost()
        {
            return PackageWeight * ExpressChargeRate;
        } // end CalculatePackageCost

        // displaying datas
        public override string ToString()
        {
            return string.Format("{0} \nExpress Charge Rate: {1:C}", base.ToString(),
                                 ExpressChargeRate);
        } // end ToString
    } // end class
} // end namespace
