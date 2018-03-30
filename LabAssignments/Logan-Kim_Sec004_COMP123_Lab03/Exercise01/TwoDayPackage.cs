using System;
namespace Exercise01
{
    class TwoDayPackage : Package
    {
        // instant data members
        private double adminCharges;

        // properties
        public double AdminCharges
        {
            get
            {
                return adminCharges;
            } // end get
            set
            {
                // validation
                if (adminCharges >= 0)
                {
                    adminCharges = value;
                }
                else
                {
                    Console.WriteLine("Admin charges should not be negative.");
                }
            } // end set
        } // end AdminCharges

        // constructors
        public TwoDayPackage(string packageId, string senderName, string senderAddress,
                int packageWeight, double ratePerGram, double adminCharges)
            : base(packageId, senderName, senderAddress, packageWeight, ratePerGram)
        {
            AdminCharges = adminCharges;
        } // end constructors

        // method for calculating package cost
        public override double CalculatePackageCost()
        {
            return PackageWeight * RatePerGram + AdminCharges;
        } // end CalculatePackageCost

        // displaying datas
        public override string ToString()
        {
            return string.Format("{0} \nAdmin Charges: {1:C}", base.ToString(),
                                 AdminCharges);
        } // end ToString
    } // end class
} // end namespace
